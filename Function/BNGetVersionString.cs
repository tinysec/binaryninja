using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
    {
	    public static string GetVersionString()
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetVersionString()
		    );
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// char* BNGetVersionString()
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetVersionString"
	    )]
	    internal static extern IntPtr BNGetVersionString();
    }
}