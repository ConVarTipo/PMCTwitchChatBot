using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace TwitchProductionUI.helpers
{

    class Requester
    {
        static AES256 aes = new AES256();

        // Запрос к серверу на авторизацию клиента  
        public static void Auth(string login, string password)
        {
            HttpRequest req = new HttpRequest();
            RequestParams data = new RequestParams();

            data["login"] = login;
            data["password"] = password;

            string rsp = req.Post(Settings.api + "auth.php", data).ToString();

            Account ans = JsonConvert.DeserializeObject<Account>(rsp);

            if(ans.valide == "ok")
            {
                MessageBox.Show("ok");
                Config(ans.channel, aes.Decrypt(ans.token, "123"));
            }
            else if(rsp == "error:post")
            {
                MessageBox.Show("post error");
            }
            else if(rsp == "error:data")
            {
                MessageBox.Show("login error");
            }
        }

        // Запрос к серверу на загрузку конфига пользователя
        public static void Config(string channel, string token)
        {
            HttpRequest req = new HttpRequest();
            RequestParams data = new RequestParams();

            data["channel"] = aes.Encrypt(channel, "123");
            data["token"] = aes.Encrypt(token, "123");

            string rsp = req.Post(Settings.api + "configs.php", data).ToString();
            Config ans = JsonConvert.DeserializeObject<Config>(rsp);

            if (ans.valide == "ok")
            {
                MessageBox.Show("ok config" + " " + ans.res + " " + ans.sens);
                Thread log = new Thread(() => Log(channel, "successful auth"));
                log.Start();
            }
            else if (rsp == "error:post")
            {
                MessageBox.Show("post error");
            }
            else if (rsp == "error:data")
            {
                MessageBox.Show("login error");
                Thread log = new Thread(() => Log(channel, "auth error"));
                log.Start();
            }
        }

        // Запрос на отправку логов на сервер
        public static void Log(string channel, string action)
        {
            HttpRequest req = new HttpRequest();
            RequestParams data = new RequestParams();

            data["channel"] = aes.Encrypt(channel, "123");
            data["action"] = aes.Encrypt(action, "123");

            string rsp = req.Post(Settings.api + "logs.php", data).ToString();

            switch (rsp)
            {
                case "ok":
                    MessageBox.Show("ok log sended");
                    break;

                case "error:post":
                    MessageBox.Show("post error");
                    break;

                case "error:data":
                    MessageBox.Show("login error");
                    break;              
            }
        }
    }
}
     