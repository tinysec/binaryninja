using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetTagReferencesOfTypeCount(BNBinaryView* view, BNTagType* tagType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetTagReferencesOfTypeCount"
        )]
		internal static extern ulong BNGetTagReferencesOfTypeCount(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNTagType* tagType
		    IntPtr tagType  
			
		);
	}
}