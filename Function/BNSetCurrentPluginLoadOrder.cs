using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
	{
		public static void SetCurrentPluginLoadOrder(PluginLoadOrder order)
		{
			NativeMethods.BNSetCurrentPluginLoadOrder(order);
		}
	}
	
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetCurrentPluginLoadOrder(BNPluginLoadOrder order)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetCurrentPluginLoadOrder"
        )]
		internal static extern void BNSetCurrentPluginLoadOrder(
			
			// BNPluginLoadOrder order
		    PluginLoadOrder order 
		);
	}
}