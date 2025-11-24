using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTypeFieldReference* BNGetCodeReferencesForTypeField(BNBinaryView* view, BNQualifiedName* type, uint64_t offset, uint64_t* count, bool limit, uint64_t maxItems)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetCodeReferencesForTypeField"
        )]
		internal static extern IntPtr BNGetCodeReferencesForTypeField(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* type
		    in BNQualifiedName type  , 
			
			// uint64_t offset
		    ulong offset  , 
			
			// uint64_t* count
		    out ulong count  , 
			
			// bool limit
		    bool limit  , 
			
			// uint64_t maxItems
		    ulong maxItems  
		);
	}
}