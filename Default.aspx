<%@ Page Language="C#" Inherits="githubtests.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
	
		<div runat="server" id="PanelTelecomCompanyChooser1">
		<br />
		<asp:Label id="LocationLabel1" runat="server" />
		</div>
		
		
		<div runat="server" id="PanelBitcoinAddress1">
		<br />
		Please enter bitcoin address:
		<asp:TextBox id="BitcoinAddress1" runat="server" Text="" />
		<asp:Button id="button1" runat="server" Text="Go!" OnClick="button1Clicked" />
		</div>

		<div runat="server" id="PanelDone1">
		<br />
		New page <asp:HyperLink id="BitcoinUrl1" runat="server" /> was created, you shound receive an SMS with confirmation code, and enter it there
		</div>
	</form>
</body>
</html>
