using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNBeginUndoActions(BNFileMetadata* file, bool anonymousAllowed)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBeginUndoActions"
        )]
		internal static extern IntPtr BNBeginUndoActions(
			
			// BNFileMetadata* file
		    IntPtr file  , 
			
			// bool anonymousAllowed
		    bool anonymousAllowed  
		);
	}
}