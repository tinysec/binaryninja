using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStructure* BNCreateStructureFromOffsetAccess(BNBinaryView* view, BNQualifiedName* name, bool* newMember)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateStructureFromOffsetAccess"
        )]
		internal static extern IntPtr BNCreateStructureFromOffsetAccess(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName* name
		    in BNQualifiedName name  , 
			
			// bool* newMember
		    out bool newMember  
		);
	}
}