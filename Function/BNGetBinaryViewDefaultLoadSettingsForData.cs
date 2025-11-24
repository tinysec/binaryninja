using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSettings* BNGetBinaryViewDefaultLoadSettingsForData(BNBinaryViewType* type, BNBinaryView* data)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetBinaryViewDefaultLoadSettingsForData"
        )]
		internal static extern IntPtr BNGetBinaryViewDefaultLoadSettingsForData(
			
			// BNBinaryViewType* type
		    IntPtr type  , 
			
			// BNBinaryView* data
		    IntPtr data  
			
		);
	}
}