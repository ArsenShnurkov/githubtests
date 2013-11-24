using System;
using System.Text;
using System.Web;
using System.Web.UI;

public class BitcoinAddressModule : IHttpModule
{
	public BitcoinAddressModule ()
	{
	}

	public String ModuleName {
		get { return "BitcoinAddressModule"; }
	}

	/// <Docs>
	/// To be added: an object of type 'HttpApplication'
	/// </Docs>
	/// <remarks>
	/// To be added
	/// </remarks>
	/// <summary>
	/// In the Init function, register for HttpApplication 
	/// events by adding your handlers.
	/// </summary>
	/// <param name='application'>
	/// Application.
	/// </param>
	public void Init (HttpApplication application)
	{
		application.BeginRequest += 
        (new EventHandler (this.Application_BeginRequest));
	}

	private void Application_BeginRequest (Object source, EventArgs e)
	{
		HttpApplication application = (HttpApplication)source;
		HttpContext context = application.Context;
		string address = context.Request.Url.PathAndQuery.Substring(1);
		if (BitcoinLibrary.IsValidAddress(address)) {
			context.RewritePath("/BitcoinAddress.aspx", "/BitcoinAddress.aspx", "addr=" + address);
		}
	}

	public void Dispose ()
	{
	}
}
