<?php
    include '../Helpers/db.php';
    include '../Helpers/random.php';
    include '../Helpers/AES256.php';

    if($_POST['login'] == null || $_POST['password'] == null)
        die("error:post");
    
    $controller = new mysqli(DB_HOST, DB_LOGIN, DB_PASSWORD, DB_NAME);

    $u_login = $_POST['login'];
    $u_password = $_POST['password'];

    $get_db = $controller->query("SELECT * FROM channels WHERE login='$u_login' AND password='$u_password'");
        if($get_db->num_rows == 0)
            die("error:data");

    $u_data = $get_db->fetch_assoc();
    $u_channel = $u_data['channel'];

    $randomtoken = generateRandomString();
    $tokens = $controller->query("INSERT INTO tokens(channel, token) values ('$u_channel','$randomtoken')");

    $answer = array('valide' => "ok", 'channel' => $u_channel, 'token' => Encrypt($randomtoken, "123"));

    die(json_encode($answer));
