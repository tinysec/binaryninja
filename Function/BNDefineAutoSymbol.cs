using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNDefineAutoSymbol(BNBinaryView* view, BNSymbol* sym)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDefineAutoSymbol"
        )]
		internal static extern void BNDefineAutoSymbol(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNSymbol* sym
		    IntPtr sym  
		);
	}
}