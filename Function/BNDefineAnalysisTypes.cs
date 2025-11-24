using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNDefineAnalysisTypes(BNBinaryView* view, BNQualifiedNameTypeAndId* types, uint64_t count, void** progress, void* progressContext, const char*** resultIds, BNQualifiedName** resultNames)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDefineAnalysisTypes"
        )]
		internal static extern ulong BNDefineAnalysisTypes(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedNameTypeAndId* types
		    in BNQualifiedNameTypeAndId[] types  , 
			
			// uint64_t count
		    ulong count  , 
			
			// void* progress
		    IntPtr progress  , 
			
			// void* progressContext
		    IntPtr progressContext  , 
			
			//  char** resultIds
		    out IntPtr resultIds  , 
			
			// BNQualifiedName** resultNames
		    out IntPtr resultNames  
		);
	}
}