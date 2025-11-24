using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDisassemblyTextRenderer* BNCreateMediumLevelILDisassemblyTextRenderer(BNMediumLevelILFunction* func, BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateMediumLevelILDisassemblyTextRenderer"
        )]
		internal static extern IntPtr BNCreateMediumLevelILDisassemblyTextRenderer(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
		);
	}
}