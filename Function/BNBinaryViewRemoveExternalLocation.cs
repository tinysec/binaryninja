using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNBinaryViewRemoveExternalLocation(BNBinaryView* view, BNSymbol* sourceSymbol)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBinaryViewRemoveExternalLocation"
        )]
		internal static extern void BNBinaryViewRemoveExternalLocation(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNSymbol* sourceSymbol
		    IntPtr sourceSymbol  
		);
	}
}