using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
    {
	    public static string GetUserPluginDirectory()
	    {
		    return UnsafeUtils.TakeUtf8String(
			    NativeMethods.BNGetUserPluginDirectory()
		    );
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// char* BNGetUserPluginDirectory()
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetUserPluginDirectory"
	    )]
	    internal static extern IntPtr BNGetUserPluginDirectory();
    }
}