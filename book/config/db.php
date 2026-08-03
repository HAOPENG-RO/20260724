<?php
$host="localhost";
$user="root";
$password="lv243899633";
$daname="book_management";

$conn = new mysqli($host, $user, $password, $daname,3309);
if($conn->connect_error){
    die("データベース連携失敗".$conn->connect_error);
}

$conn->set_charset("utf8mb4");
?>