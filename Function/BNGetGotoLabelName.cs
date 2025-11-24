using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// char* BNGetGotoLabelName(BNFunction* func, uint64_t labelId)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetGotoLabelName"
        )]
		internal static extern IntPtr BNGetGotoLabelName(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint64_t labelId
		    ulong labelId  
		);
	}
}