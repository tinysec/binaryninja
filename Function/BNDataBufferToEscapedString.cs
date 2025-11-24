using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNDataBufferToEscapedString(BNDataBuffer* buf, bool nullTerminates, bool escapePrintable)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDataBufferToEscapedString"
        )]
		internal static extern IntPtr BNDataBufferToEscapedString(
			
			// BNDataBuffer* buf
		    IntPtr buf  , 
			
			// bool nullTerminates
		    bool nullTerminates  , 
			
			// bool escapePrintable
		    bool escapePrintable  
		);
	}
}