<%@ Page Language="C#" Inherits="githubtests.BitcoinAddress" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Bitcoin Address</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Label runat="server" id="Address1" />
		<br />
		<br />
		Please enter confirmation code:
		<asp:TextBox id="ConfirmationCode1" runat="server" Text="" />
		<asp:Button id="button1" runat="server" Text="Go!" OnClick="button1Clicked" />	</form>
</body>
</html>
