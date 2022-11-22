using System;

using R5T.T0131;


namespace R5T.Z0021
{
	[ValuesMarker]
	public partial interface ICodeFilePaths : IValuesMarker
	{
        public string TempCSharp => @"C:\Temp\Temp.cs";
    }
}