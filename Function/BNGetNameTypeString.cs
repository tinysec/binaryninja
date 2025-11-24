using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
    {
	    public static string GetNameTypeString(NameType classFunctionType  )
	    {
		    return UnsafeUtils.TakeAnsiString(

			    NativeMethods.BNGetNameTypeString(
				    classFunctionType
			    )
		    );
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// char* BNGetNameTypeString(BNNameType classFunctionType)
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetNameTypeString"
	    )]
	    internal static extern IntPtr BNGetNameTypeString(
			
		    // BNNameType classFunctionType
		    NameType classFunctionType  
	    );
    }
}