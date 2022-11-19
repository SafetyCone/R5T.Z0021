using System;

using R5T.F0000;
using R5T.T0132;
using R5T.Z0015;


namespace R5T.Z0021
{
	[FunctionalityMarker]
	public partial interface ICodeFilePathOperator : IFunctionalityMarker
	{
		public string GetTemporaryCodeFilePath(string typeName)
		{
			var codeFilePath = PathOperator.Instance.GetFilePath(
				DirectoryPaths.Instance.Temp,
				$"{typeName}.cs");

			return codeFilePath;
		}
	}
}