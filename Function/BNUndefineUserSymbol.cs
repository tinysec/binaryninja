using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUndefineUserSymbol(BNBinaryView* view, BNSymbol* sym)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNUndefineUserSymbol"
        )]
		internal static extern void BNUndefineUserSymbol(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNSymbol* sym
		    IntPtr sym  
		);
	}
}