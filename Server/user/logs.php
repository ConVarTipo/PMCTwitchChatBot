<?php
    date_default_timezone_set('Europe/Moscow');
    include '../helpers/db.php';
    include '../Helpers/AES256.php';

    if($_POST['channel'] == null || $_POST['action'] == null)
        die("error:post");

    $controller = new mysqli(DB_HOST, DB_LOGIN, DB_PASSWORD, DB_NAME);

    $u_channel =  Decrypt($_POST['channel'], "123");
    $time = strtotime(date("h:i:s"))-3600;
    $u_time = date('h:i:s', $time);
    $u_action = Decrypt($_POST['action'], "123");

    $get_db = $controller->query("SELECT * FROM channels WHERE channel='$u_channel'");
        if($get_db->num_rows == 0)
            die("error:data");
    
    $log_insert = $controller->query("INSERT INTO logs(channel, time, action) VALUES ('$u_channel', '$u_time', '$u_action')");
        die("ok");
    