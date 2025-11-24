using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAppendDataBuffer(BNDataBuffer* dest, BNDataBuffer* src)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAppendDataBuffer"
        )]
		internal static extern void BNAppendDataBuffer(
			
			// BNDataBuffer* dest
		    IntPtr dest  , 
			
			// BNDataBuffer* src
		    IntPtr src  
		);
	}
}