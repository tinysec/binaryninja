using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    public static partial class Core
    {
	    public static string GetUniqueIdentifierString()
	    {
		    return UnsafeUtils.TakeAnsiString(
			    BinaryNinja.NativeMethods.BNGetUniqueIdentifierString()
		    );
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// char* BNGetUniqueIdentifierString()
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetUniqueIdentifierString"
	    )]
	    internal static extern IntPtr BNGetUniqueIdentifierString();
    }
}