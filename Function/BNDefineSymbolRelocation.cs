using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNDefineSymbolRelocation(BNBinaryView* view, BNArchitecture* arch, BNRelocationInfo* info, BNSymbol* target, uint64_t reloc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNDefineSymbolRelocation"
        )]
		internal static extern void BNDefineSymbolRelocation(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNRelocationInfo* info
		    IntPtr info  , 
			
			// BNSymbol* target
		    IntPtr target  , 
			
			// uint64_t reloc
		    ulong reloc  
			
		);
	}
}