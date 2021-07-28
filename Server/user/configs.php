<?php
    include '../helpers/db.php';
    include '../helpers/AES256.php';

    if($_POST['channel'] == null || $_POST['token'] == null)
        die("error:post");
    
    $controller = new mysqli(DB_HOST, DB_LOGIN, DB_PASSWORD, DB_NAME);

    $u_channel = Decrypt($_POST['channel'], "123");
    $u_token = Decrypt($_POST['token'], "123");

    $get_db = $controller->query("SELECT * FROM tokens WHERE channel='$u_channel' AND token='$u_token'");
        if($get_db->num_rows == 0)
            die("error:data");
    
    $get_command = $controller->query("SELECT * FROM configs WHERE channel='$u_channel'");
    
    $delete_token = $controller->query("DELETE FROM tokens WHERE token = '$u_token'");

    $row = $get_command->fetch_assoc();

    $answer = array('valide' => "ok", 'sens' => $row["sens"], 'res' => $row["res"]);

    die(json_encode($answer));