﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WelcomePage.aspx.cs" Inherits="WelcomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Page</title>

    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!-- CSS -->
    <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:400,100,300,500" />
    <link rel="stylesheet" href="Content/assets/bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="Content/assets/font-awesome/css/font-awesome.min.css" />
	<link rel="stylesheet" href="Content/assets/css/form-elements.css" />
    <link rel="stylesheet" href="Content/assets/css/style.css" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

    <!-- Favicon and touch icons -->
    <link rel="shortcut icon" href="Content/assets/ico/favicon.png" />
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="Content/assets/ico/apple-touch-icon-144-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="Content/assets/ico/apple-touch-icon-114-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="Content/assets/ico/apple-touch-icon-72-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" href="Content/assets/ico/apple-touch-icon-57-precomposed.png" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="welcomeLabel" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="dateLabel" runat="server" Text="Label"></asp:Label>
        </div>
    </form>









    <!-- Javascript -->
    <script src="Content/assets/js/jquery-1.11.1.min.js"></script>
    <script src="Content/assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="Content/assets/js/jquery.backstretch.min.js"></script>
    <script src="Content/assets/js/scripts.js"></script>
        
    <!--[if lt IE 10]>
    <script src="Content/assets/js/placeholder.js"></script>
    <![endif]-->
    
</body>
</html>
