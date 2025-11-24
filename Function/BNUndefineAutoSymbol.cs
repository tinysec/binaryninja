using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUndefineAutoSymbol(BNBinaryView* view, BNSymbol* sym)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNUndefineAutoSymbol"
        )]
		internal static extern void BNUndefineAutoSymbol(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNSymbol* sym
		    IntPtr sym  
		);
	}
}