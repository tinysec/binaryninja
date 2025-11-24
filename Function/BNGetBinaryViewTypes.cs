using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// 
	    /// BNBinaryViewType** BNGetBinaryViewTypes(uint64_t* count)
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetBinaryViewTypes"
	    )]
	    public static extern IntPtr BNGetBinaryViewTypes(
			    
		    // uint64_t* count
		    out ulong count  
	    );
    }
}