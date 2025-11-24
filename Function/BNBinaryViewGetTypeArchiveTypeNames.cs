using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNBinaryViewGetTypeArchiveTypeNames(BNBinaryView* view, BNQualifiedName* name, const char*** archiveIds, const char*** archiveTypeIds)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBinaryViewGetTypeArchiveTypeNames"
        )]
		internal static extern ulong BNBinaryViewGetTypeArchiveTypeNames(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* name
		    IntPtr name  , 
			
			// const char*** archiveIds
		    IntPtr archiveIds  , 
			
			// const char*** archiveTypeIds
		    IntPtr archiveTypeIds  
		);
	}
}