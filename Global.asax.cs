
namespace githubtests
{
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Web;
	using System.Web.SessionState;
	using System.Configuration;
	using System.Web.Configuration;

	public class Global : System.Web.HttpApplication
	{
		public static IHttpModule Module = new BitcoinAddressModule ();
		public static string Environment = "localhost";

		public override void Init ()
		{
			base.Init ();
			Module.Init (this);
		}

		protected void Application_Start (Object sender, EventArgs e)
		{
			Configuration rootWebConfig1 =
				WebConfigurationManager.OpenWebConfiguration (null);
			if (rootWebConfig1.AppSettings.Settings.Count > 0) {
				KeyValueConfigurationElement customSetting = 
					rootWebConfig1.AppSettings.Settings ["Environment"];
				Environment = customSetting.Value;
			}
		}

		protected void Session_Start (Object sender, EventArgs e)
		{
		}

		protected void Application_BeginRequest (Object sender, EventArgs e)
		{
		}

		protected void Application_EndRequest (Object sender, EventArgs e)
		{
		}

		protected void Application_AuthenticateRequest (Object sender, EventArgs e)
		{
		}

		protected void Application_Error (Object sender, EventArgs e)
		{
		}

		protected void Session_End (Object sender, EventArgs e)
		{
		}

		protected void Application_End (Object sender, EventArgs e)
		{
		}
	}
}

