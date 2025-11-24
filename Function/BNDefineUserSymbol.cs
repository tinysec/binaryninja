using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNDefineUserSymbol(BNBinaryView* view, BNSymbol* sym)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDefineUserSymbol"
        )]
		internal static extern void BNDefineUserSymbol(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNSymbol* sym
		    IntPtr sym  
		);
	}
}