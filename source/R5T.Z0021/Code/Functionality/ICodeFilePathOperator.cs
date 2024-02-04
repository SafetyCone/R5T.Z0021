using System;

using R5T.T0132;
using R5T.Z0015;


namespace R5T.Z0021
{
	[FunctionalityMarker]
	public partial interface ICodeFilePathOperator : IFunctionalityMarker
	{
		public string GetTemporaryCodeFilePath(string typeName)
		{
			var codeFilePath = Instances.PathOperator.Get_FilePath(
                Instances.DirectoryPaths.Temp,
				$"{typeName}.cs");

			return codeFilePath;
		}
	}
}