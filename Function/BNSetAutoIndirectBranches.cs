using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetAutoIndirectBranches(BNFunction* func, BNArchitecture* sourceArch, uint64_t source, BNArchitectureAndAddress* branches, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetAutoIndirectBranches"
        )]
		internal static extern void BNSetAutoIndirectBranches(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* sourceArch
		    IntPtr sourceArch  , 
			
			// uint64_t source
		    ulong source  , 
			
			// BNArchitectureAndAddress* branches
		    IntPtr branches  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}