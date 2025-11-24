using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetStructureBuilderPacked(BNStructureBuilder* s, bool packed)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetStructureBuilderPacked"
        )]
		internal static extern void BNSetStructureBuilderPacked(
			
			// BNStructureBuilder* s
		    IntPtr s  , 
			
			// bool packed
		    bool packed  
		);
	}
}