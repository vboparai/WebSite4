<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddApptByAdminPage.aspx.cs" Inherits="AddApptByAdminPage" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Registration Page</title>

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


    <!-- DATE SELECTOR -->
   <script language="C#" runat="server">

      void Selection_Change(Object sender, EventArgs e) 
      {
         dateLab.Text = dateCal.SelectedDate.ToShortDateString();
      }

   </script>


</head>
<body>

	<!-- NAVIGATION -->
	<div class="navbar navbar-inverse navbar-fixed-top">
			<div class="container">
				<div class="navbar-header">
					<button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
					</button>
					<a href="Login" class="navbar-brand">Application name</a>
				</div>
				<div class="navbar-collapse collapse">
					<ul class="nav navbar-nav">
						<li><a href="Login">Home</a></li>
						<li><a href="#">About</a></li>
						<li><a href="#">Contact</a></li>
					</ul>
					
					<ul class="nav navbar-nav navbar-right">
						<li><a href="ClientRegistrationPage">Register</a></li>
						<li><a href="Login">Log in</a></li>
					</ul>                        
				</div>
			</div>
		</div><!-- END OF NAVIGATION -->

	<br /><br />
	<form id="form1" runat="server">
		<div>
			<asp:Label ID="companyNameLabel" runat="server" Text="MyCompanyName"></asp:Label><br />
			<asp:Label ID="apptLabel" runat="server" Text="Book Your Next Appointment"></asp:Label><br /><br />        
            <asp:TextBox ID="emailTb" runat="server" placeholder="Email"></asp:TextBox><br /><br />
            <div style="width:200px;margin-left:auto;margin-right:auto">
                <asp:Label ID="dateLab" runat="server" Text="Select Date" ></asp:Label>
                <asp:Calendar ID="dateCal" runat="server" 
                    SelectionMode="Day" 
                    ShowGridLines="True"
                    OnSelectionChanged="Selection_Change"></asp:Calendar><br />
            </div>
            <asp:DropDownList ID="missionList" runat="server">
                <asp:ListItem Enabled="true" Text="Select Mission Type" Value="-1"></asp:ListItem>
                <asp:ListItem Text="Air2Air" Value="1"></asp:ListItem>
                <asp:ListItem Text="Air2Ground" Value="2"></asp:ListItem>
                <asp:ListItem Text="PilotEssentials" Value="3"></asp:ListItem>
            </asp:DropDownList><br /><br /> 
            <asp:RequiredFieldValidator ID="reqMission" runat="server" ControlToValidate="missionList"
                InitialValue="-1">
            </asp:RequiredFieldValidator>

            
            <asp:DropDownList ID="durationList" runat="server">
                <asp:ListItem Enabled="true" Text="Select Duration" Value="-1"></asp:ListItem>
                <asp:ListItem Text="1 Hour" Value="1"></asp:ListItem>
                <asp:ListItem Text="1.5 Hours" Value="2"></asp:ListItem>
                <asp:ListItem Text="2 Hours" Value="3"></asp:ListItem>
            </asp:DropDownList><br /><br /> 
            <asp:RequiredFieldValidator ID="durationValidator" runat="server" ControlToValidate="durationList"
                InitialValue="-1">
            </asp:RequiredFieldValidator>
			
			<asp:Button ID="bookButon" runat="server" OnClick="loginButton_Click" Text="Book Appointment" /><br /><br />

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


