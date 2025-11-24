using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNBinaryViewRecordImportedObjectLibrary(BNBinaryView* view, BNPlatform* tgtPlatform, uint64_t tgtAddr, BNTypeLibrary* lib, BNQualifiedName* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBinaryViewRecordImportedObjectLibrary"
        )]
		internal static extern void BNBinaryViewRecordImportedObjectLibrary(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNPlatform* tgtPlatform
		    IntPtr tgtPlatform  , 
			
			// uint64_t tgtAddr
		    ulong tgtAddr  , 
			
			// BNTypeLibrary* lib
		    IntPtr lib  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName name  
		);
	}
}