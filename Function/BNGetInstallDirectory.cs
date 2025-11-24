using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
    {
	    public static string GetInstallDirectory()
	    {
		    return UnsafeUtils.TakeUtf8String(
			    NativeMethods.BNGetInstallDirectory()
		    );
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// const char* BNGetInstallDirectory()
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetInstallDirectory"
	    )]
	    internal static extern IntPtr BNGetInstallDirectory();
    }
}