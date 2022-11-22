using System;


namespace R5T.Z0021
{
	public class CodeFilePaths : ICodeFilePaths
	{
		#region Infrastructure

	    public static ICodeFilePaths Instance { get; } = new CodeFilePaths();

	    private CodeFilePaths()
	    {
        }

	    #endregion
	}
}