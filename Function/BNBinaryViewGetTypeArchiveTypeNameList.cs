using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNBinaryViewGetTypeArchiveTypeNameList(BNBinaryView* view, BNQualifiedName** names)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBinaryViewGetTypeArchiveTypeNameList"
        )]
		internal static extern ulong BNBinaryViewGetTypeArchiveTypeNameList(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNQualifiedName** names
		    IntPtr names  
		);
	}
}