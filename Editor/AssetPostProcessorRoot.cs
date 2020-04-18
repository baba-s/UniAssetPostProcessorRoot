using UnityEditor;

namespace UniAssetPostprocessorRoot
{
	public sealed class AssetPostprocessorRoot : AssetPostprocessor
	{
		public delegate void OnPostprocessAllAssetsCallback
		(
			string[] importedAssets,
			string[] deletedAssets,
			string[] movedAssets,
			string[] movedFromAssetPaths
		);

		public static event OnPostprocessAllAssetsCallback OnPostprocessAllAssetsImpl;

		private static void OnPostprocessAllAssets
		(
			string[] importedAssets,
			string[] deletedAssets,
			string[] movedAssets,
			string[] movedFromAssetPaths
		)
		{
			OnPostprocessAllAssetsImpl?.Invoke
			(
				importedAssets,
				deletedAssets,
				movedAssets,
				movedFromAssetPaths
			);
		}
	}
}