<%@ Page Language="C#" Inherits="githubtests.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
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
