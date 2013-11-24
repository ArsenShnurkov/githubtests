using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
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
		application.EndRequest += 
        (new EventHandler (this.Application_EndRequest));
	}

	private void Application_BeginRequest (Object source, EventArgs e)
	{
		HttpApplication application = (HttpApplication)source;
		HttpContext context = application.Context;
		string address = context.Request.Url.PathAndQuery.Substring(1);
		if (BitcoinLibrary.IsValidAddress(address)) {
			context.RewritePath("/BitcoinAddress.aspx");

			SetReadonly(context.Request.Params, false);
			context.Request.Params.Add ("addr", address);
			SetReadonly(context.Request.Params, true);
		}
	}

	private void Application_EndRequest (Object source, EventArgs e)
	{
	}

	public void Dispose ()
	{
	}
	private static void SetReadonly(NameValueCollection collection, bool isReadOnly)
    {
        // Both the form and query string collections are read-only by 
        // default, so use Reflection to make them writable:
        PropertyInfo readonlyProperty = collection.GetType()
            .GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);

        readonlyProperty.SetValue(collection, isReadOnly, null);
    }
}
