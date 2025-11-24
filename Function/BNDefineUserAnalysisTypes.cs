using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNDefineUserAnalysisTypes(BNBinaryView* view, BNQualifiedNameAndType* types, uint64_t count, void** progress, void* progressContext)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDefineUserAnalysisTypes"
        )]
		internal static extern void BNDefineUserAnalysisTypes(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedNameAndType* types
			BNQualifiedNameAndType[] types  , 
			
			// uint64_t count
		    ulong count  , 
			
			// void* progress
		    IntPtr progress  , 
			
			// void* progressContext
		    IntPtr progressContext  
		);
	}
}