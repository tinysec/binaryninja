using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNClearDataBuffer(BNDataBuffer* buf)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNClearDataBuffer"
        )]
		internal static extern void BNClearDataBuffer(
			
			// BNDataBuffer* buf
		    IntPtr buf  
		);
	}
}