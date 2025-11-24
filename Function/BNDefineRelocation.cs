using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNDefineRelocation(BNBinaryView* view, BNArchitecture* arch, BNRelocationInfo* info, uint64_t target, uint64_t reloc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDefineRelocation"
        )]
		internal static extern void BNDefineRelocation(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNRelocationInfo* info
		    IntPtr info  , 
			
			// uint64_t target
		    ulong target  , 
			
			// uint64_t reloc
		    ulong reloc  
		);
	}
}