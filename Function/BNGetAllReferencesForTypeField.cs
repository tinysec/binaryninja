using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNAllTypeFieldReferences BNGetAllReferencesForTypeField(BNBinaryView* view, BNQualifiedName* type, uint64_t offset, bool limit, uint64_t maxItems)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetAllReferencesForTypeField"
        )]
		internal static extern BNAllTypeFieldReferences BNGetAllReferencesForTypeField(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* type
		    IntPtr type  , 
			
			// uint64_t offset
		    ulong offset  , 
			
			// bool limit
		    bool limit  , 
			
			// uint64_t maxItems
		    ulong maxItems  
			
		);
	}
}