using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNGetSnapshotData(BNFileMetadata* file, BNKeyValueStore* data, BNKeyValueStore* cache, void* ctxt, void** progress)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetSnapshotData"
        )]
		internal static extern void BNGetSnapshotData(
			
			// BNFileMetadata* file
		    IntPtr file  , 
			
			// BNKeyValueStore* data
		    IntPtr data  , 
			
			// BNKeyValueStore* cache
		    IntPtr cache  , 
			
			// void* ctxt
		    IntPtr ctxt  , 
			
			// void* progress
		    IntPtr progress  
		);
	}
}