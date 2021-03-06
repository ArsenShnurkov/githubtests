
namespace githubtests
{
	using System;
	using System.Text;
	using System.Web;
	using System.Web.UI;

	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load (object sender, EventArgs args)
		{
			if (IsPostBack) {
			} else {
				//PanelBitcoinAddress1.Visible = false;
				PanelDone1.Visible = false;
			}
			// Populate the first panel
			StringBuilder finalLocation = new StringBuilder (1024);
			string addr1 = HttpContext.Current.Request.UserHostAddress;
			finalLocation.AppendFormat ("IP: {0}", addr1);
			string addr2 = Request.ServerVariables ["HTTP_X_FORWARDED_FOR"];
			if (!string.IsNullOrWhiteSpace (addr2)) {
				finalLocation.AppendFormat (", Proxy: {0}", addr2);
			}
			using (var objClient = new System.Net.WebClient()) {
				var strFile = objClient.DownloadString ("http://freegeoip.net/xml/" + addr2);

				finalLocation.AppendFormat (", GeoProvider: {0}", strFile);
				LocationLabel1.Text = finalLocation.ToString ();
			}
		}
		public void button1Clicked (object sender, EventArgs args)
		{
			button1.Text = "done";
			button1.Enabled = false;
			PanelDone1.Visible = true;

			string targetURL = GetWalletURL (BitcoinAddress1.Text);
			BitcoinUrl1.Text = targetURL;
			BitcoinUrl1.NavigateUrl = targetURL;
		}
		string GetWalletURL (string bitcoinAddr)
		{
			string authority = Request.Url.GetLeftPart (UriPartial.Authority);
			if (Global.Environment.CompareTo("AppHarbor") == 0) 
			{
				int index = authority.LastIndexOf (":");
				if (index >= 0)
				{
					authority = authority.Substring (0, index);
				}
			}
			Uri target = new Uri(new Uri(authority), bitcoinAddr);
			return target.ToString ();
		}
	}
}

