using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAssignDataBuffer(BNDataBuffer* dest, BNDataBuffer* src)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNAssignDataBuffer"
        )]
		internal static extern void BNAssignDataBuffer(
			
			// BNDataBuffer* dest
		    IntPtr dest  , 
			
			// BNDataBuffer* src
		    IntPtr src  
			
		);
	}
}