using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNAllTypeReferences BNGetAllReferencesForType(BNBinaryView* view, BNQualifiedName* type, bool limit, uint64_t maxItems)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetAllReferencesForType"
        )]
		internal static extern BNAllTypeReferences BNGetAllReferencesForType(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* type
		    IntPtr type  , 
			
			// bool limit
		    bool limit  , 
			
			// uint64_t maxItems
		    ulong maxItems  
			
		);
	}
}