using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNExternalLocation* BNBinaryViewGetExternalLocation(BNBinaryView* view, BNSymbol* sourceSymbol)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBinaryViewGetExternalLocation"
        )]
		internal static extern IntPtr BNBinaryViewGetExternalLocation(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNSymbol* sourceSymbol
		    IntPtr sourceSymbol  
		);
	}
}