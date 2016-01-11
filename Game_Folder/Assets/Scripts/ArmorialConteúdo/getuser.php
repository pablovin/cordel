<?php

 

    // Send variables for the MySQL database class.

    $database = mysql_connect('localhost', 'root', '') or die('Could not connect: ' . mysql_error());

    mysql_select_db('armorial') or die('Could not select database');

 

 

    $username = $_REQUEST['username'];

    $password = $_REQUEST['password'];

 

    $qry="SELECT * FROM jogadores WHERE usuario='".mysql_real_escape_string($username)."'

   AND senha='".md5($password)."'"; 

    $result=mysql_query($qry);

 

    if (mysql_num_rows($result)>0)

    {

        echo "right";

    }

    else

    {

        echo "wrong";

    }

 

?>