using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
	{
		public static void DisablePlugins()
		{
			NativeMethods.BNDisablePlugins();
		}
	}
	
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNDisablePlugins()
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDisablePlugins"
        )]
		public static extern void BNDisablePlugins();
	}
}