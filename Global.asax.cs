
namespace githubtests
{
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Web;
	using System.Web.SessionState;

	public class Global : System.Web.HttpApplication
	{
		public static IHttpModule Module = new BitcoinAddressModule ();

		public override void Init ()
		{
			base.Init ();
			Module.Init (this);
		}

		protected void Application_Start (Object sender, EventArgs e)
		{
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

