
namespace githubtests
{
	using System;
	using System.Text;
	using System.Web;
	using System.Web.UI;

	public partial class BitcoinAddress : System.Web.UI.Page
	{
		protected void Page_Load (object sender, EventArgs args)
		{
			Address1.Text = Request.Params["addr"];
		}
		public void button1Clicked (object sender, EventArgs args)
		{
			button1.Text = "done";
			button1.Enabled = false;
		}
	}
}

