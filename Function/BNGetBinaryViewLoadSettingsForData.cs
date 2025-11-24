using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSettings* BNGetBinaryViewLoadSettingsForData(BNBinaryViewType* type, BNBinaryView* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetBinaryViewLoadSettingsForData"
        )]
		internal static extern IntPtr BNGetBinaryViewLoadSettingsForData(
			
			// BNBinaryViewType* type
		    IntPtr type  , 
			
			// BNBinaryView* data
		    IntPtr data  
			
		);
	}
}