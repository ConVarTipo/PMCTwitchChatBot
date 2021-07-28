namespace PMCBotEditor
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.BotName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Channels = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.AccessTokens = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Newss = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Senss = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Ress = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BotName
            // 
            this.BotName.Location = new System.Drawing.Point(12, 25);
            this.BotName.Multiline = true;
            this.BotName.Name = "BotName";
            this.BotName.Size = new System.Drawing.Size(217, 20);
            this.BotName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bot name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Channel";
            // 
            // Channels
            // 
            this.Channels.Location = new System.Drawing.Point(12, 64);
            this.Channels.Multiline = true;
            this.Channels.Name = "Channels";
            this.Channels.Size = new System.Drawing.Size(217, 20);
            this.Channels.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.label.Location = new System.Drawing.Point(9, 89);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 13);
            this.label.TabIndex = 6;
            this.label.Text = "AccessToken";
            // 
            // AccessTokens
            // 
            this.AccessTokens.Location = new System.Drawing.Point(12, 105);
            this.AccessTokens.Multiline = true;
            this.AccessTokens.Name = "AccessTokens";
            this.AccessTokens.Size = new System.Drawing.Size(217, 20);
            this.AccessTokens.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "News";
            // 
            // Newss
            // 
            this.Newss.Location = new System.Drawing.Point(12, 145);
            this.Newss.Multiline = true;
            this.Newss.Name = "Newss";
            this.Newss.Size = new System.Drawing.Size(217, 20);
            this.Newss.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.label5.Location = new System.Drawing.Point(9, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sens";
            // 
            // Senss
            // 
            this.Senss.Location = new System.Drawing.Point(12, 185);
            this.Senss.Multiline = true;
            this.Senss.Name = "Senss";
            this.Senss.Size = new System.Drawing.Size(217, 20);
            this.Senss.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.label6.Location = new System.Drawing.Point(9, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Res";
            // 
            // Ress
            // 
            this.Ress.Location = new System.Drawing.Point(12, 226);
            this.Ress.Multiline = true;
            this.Ress.Name = "Ress";
            this.Ress.Size = new System.Drawing.Size(217, 20);
            this.Ress.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(71)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(12, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(247, 330);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Senss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Newss);
            this.Controls.Add(this.label);
            this.Controls.Add(this.AccessTokens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Channels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotName);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BotName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Channels;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox AccessTokens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Newss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Senss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Ress;
        private System.Windows.Forms.Button button2;
    }
}