using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNBinaryViewGetAssociatedTypeArchiveTypes(BNBinaryView* view, const char*** typeIds, const char*** archiveIds, const char*** archiveTypeIds)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNBinaryViewGetAssociatedTypeArchiveTypes"
        )]
		internal static extern ulong BNBinaryViewGetAssociatedTypeArchiveTypes(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// const char*** typeIds
		    IntPtr typeIds  , 
			
			// const char*** archiveIds
		    IntPtr archiveIds  , 
			
			// const char*** archiveTypeIds
		    IntPtr archiveTypeIds  
		);
	}
}