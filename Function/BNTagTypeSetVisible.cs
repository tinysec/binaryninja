using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNTagTypeSetVisible(BNTagType* tagType, bool visible)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNTagTypeSetVisible"
        )]
		internal static extern void BNTagTypeSetVisible(
			
			// BNTagType* tagType
		    IntPtr tagType  , 
			
			// bool visible
		    bool visible  
		);
	}
}