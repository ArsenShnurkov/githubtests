
using System;
using System.Web;
using System.Web.UI;

namespace githubtests
{
	public partial class Admin : System.Web.UI.Page
	{
		protected void Page_Load (object sender, EventArgs args)
		{
			Environment1.Text = Global.Environment;
		}
	}
}

