using System;
using System.Runtime.InteropServices;

namespace BinaryNinja
{
	public static class LocalTest
	{
		public static void Test()
		{
			NativeLibrary.SetDllImportResolver(
				typeof(BinaryNinja.Core).Assembly,
				new LibraryResolver().ResolveDllImport
			);
		
			BinaryNinja.Core.InitPlugins(true);

			BinaryView? view = BinaryView.LoadFile("/data/afd.sys.bndb");

			if (null == view)
			{
				throw new Exception("load file fail");
			}

			view.ChooseFunction();
		
			BinaryNinja.Core.Shutdown();
		}
	}
}
