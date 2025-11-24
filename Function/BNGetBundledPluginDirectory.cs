using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
    {
	    public static string GetBundledPluginDirectory()
	    {
		    return UnsafeUtils.TakeUtf8String(
			    NativeMethods.BNGetBundledPluginDirectory()
		    );
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// const char* BNGetBundledPluginDirectory()
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetBundledPluginDirectory"
	    )]
	    internal static extern IntPtr BNGetBundledPluginDirectory();
    }
}