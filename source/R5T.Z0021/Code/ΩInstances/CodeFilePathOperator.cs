using System;


namespace R5T.Z0021
{
	public class CodeFilePathOperator : ICodeFilePathOperator
	{
		#region Infrastructure

	    public static ICodeFilePathOperator Instance { get; } = new CodeFilePathOperator();

	    private CodeFilePathOperator()
	    {
        }

	    #endregion
	}
}