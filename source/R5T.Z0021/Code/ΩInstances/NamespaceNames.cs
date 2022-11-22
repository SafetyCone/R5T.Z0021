using System;


namespace R5T.Z0021
{
	public class NamespaceNames : INamespaceNames
	{
		#region Infrastructure

	    public static INamespaceNames Instance { get; } = new NamespaceNames();

	    private NamespaceNames()
	    {
        }

	    #endregion
	}
}