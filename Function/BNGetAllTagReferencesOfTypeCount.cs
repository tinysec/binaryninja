using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetAllTagReferencesOfTypeCount(BNBinaryView* view, BNTagType* tagType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetAllTagReferencesOfTypeCount"
        )]
		internal static extern ulong BNGetAllTagReferencesOfTypeCount(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNTagType* tagType
		    IntPtr tagType  
			
		);
	}
}