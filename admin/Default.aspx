<%@ Page Language="C#" Inherits="githubtests.Admin" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Administrative pages</title>
</head>
<body>
	<form id="form1" runat="server">
	Current Environment: <asp:Label runat="server" id="Environment1" />
	<br />
	<a href="./statistics/">Statistics</a>
	<br />
	<a href="./telecoms/">List of telecoms</a>
	<br />
	<a href="./team/">Team</a>
	</form>
</body>
</html>
