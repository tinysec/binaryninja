using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
    {
	    public static string GetAutoDemangledTypeIdSource()
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNGetAutoDemangledTypeIdSource()
		    );
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// char* BNGetAutoDemangledTypeIdSource()
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetAutoDemangledTypeIdSource"
	    )]
	    internal static extern IntPtr BNGetAutoDemangledTypeIdSource();
    }
}