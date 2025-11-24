using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSymbol* BNDefineAutoSymbolAndVariableOrFunction(BNBinaryView* view, BNPlatform* platform, BNSymbol* sym, BNTypeWithConfidence* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDefineAutoSymbolAndVariableOrFunction"
        )]
		internal static extern IntPtr BNDefineAutoSymbolAndVariableOrFunction(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNPlatform* platform
		    IntPtr platform  , 
			
			// BNSymbol* sym
		    IntPtr sym  , 
			
			// BNTypeWithConfidence* type
		    IntPtr type  
		);
	}
}