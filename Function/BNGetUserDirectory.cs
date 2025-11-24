using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
    {
	    public static string GetUserDirectory()
	    {
		    return UnsafeUtils.TakeUtf8String(
			    NativeMethods.BNGetUserDirectory()
		    );
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// char* BNGetUserDirectory()
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetUserDirectory"
	    )]
	    internal static extern IntPtr BNGetUserDirectory();
    }
}