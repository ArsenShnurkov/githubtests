using System;

public class BitcoinLibrary
{
	public static bool IsValidAddress (string address)
	{
		if (address.Contains (".aspx")) {
			return false;
		}
		if (address.Contains ("/")) {
			return false;
		}
		if (string.IsNullOrWhiteSpace (address)) {
			return false;
		}
		return true;
	}
}


