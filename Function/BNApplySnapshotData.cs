using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNApplySnapshotData(BNFileMetadata* file, BNBinaryView* view, BNKeyValueStore* data, BNKeyValueStore* cache, void* ctxt, void** progress, bool openForConfiguration, bool restoreRawView)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNApplySnapshotData"
        )]
		internal static extern void BNApplySnapshotData(
			
			// BNFileMetadata* file
		    IntPtr file  , 
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNKeyValueStore* data
		    IntPtr data  , 
			
			// BNKeyValueStore* cache
		    IntPtr cache  , 
			
			// void* ctxt
		    IntPtr ctxt  , 
			
			// void** progress
		    IntPtr progress  , 
			
			// bool openForConfiguration
		    bool openForConfiguration  , 
			
			// bool restoreRawView
		    bool restoreRawView  
		);
	}
}