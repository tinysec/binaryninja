using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
    {
	    public static string GetAutoDebugTypeIdSource()
	    {
		    return UnsafeUtils.TakeAnsiString(
			    BinaryNinja.NativeMethods.BNGetAutoDebugTypeIdSource()
		    );
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// char* BNGetAutoDebugTypeIdSource()
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetAutoDebugTypeIdSource"
	    )]
	    internal static extern IntPtr BNGetAutoDebugTypeIdSource();
    }
}