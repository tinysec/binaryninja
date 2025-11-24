using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    public static string GetRepositoriesDirectory()
	    {
		    return UnsafeUtils.TakeUtf8String(
			    BinaryNinja.NativeMethods.BNGetRepositoriesDirectory()
		    );
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// char* BNGetRepositoriesDirectory()
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetRepositoriesDirectory"
	    )]
	    internal static extern IntPtr BNGetRepositoriesDirectory();
    }
}