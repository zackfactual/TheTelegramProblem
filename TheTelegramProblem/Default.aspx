<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TheTelegramProblem.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>The Telegram Problem</title>
</head>
<body>
    <form id="form1" runat="server">
		<div>
    		<h1>The Telegram Problem</h1>
			<p style="font-style:italic;">Given an integer (X) and a string containing no words longer than X characters, output that string in lines no longer than X characters without breaking any word across multiple lines.</p>
			<p>
				Enter an integer: 
				<asp:TextBox ID="integerTextBox" runat="server"></asp:TextBox>
			</p>
			<p>
				Enter a string:
				<asp:TextBox ID="stringTextBox" runat="server"></asp:TextBox>
			</p>
			<asp:Button ID="goButton" runat="server" OnClick="goButton_Click" Text="Go" />
			<br />
			<br />
			<asp:Label ID="resultLabel" runat="server"></asp:Label>
		</div>
    </form>
</body>
</html>
