using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNInsertViewBuffer(BNBinaryView* view, uint64_t offset, BNDataBuffer* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNInsertViewBuffer"
        )]
		internal static extern ulong BNInsertViewBuffer(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t offset
		    ulong offset  , 
			
			// BNDataBuffer* data
		    IntPtr data  
		);
	}
}