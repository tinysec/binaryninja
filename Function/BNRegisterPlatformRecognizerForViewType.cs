using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	    internal delegate IntPtr BNPlatformRecognizeDelegate(
			IntPtr ctx,
			IntPtr view,
			IntPtr metadata
	    );
	    
	    /// <summary>
		/// void BNRegisterPlatformRecognizerForViewType(BNBinaryViewType* type, uint64_t id, BNEndianness endian, void** callback, void* ctx)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRegisterPlatformRecognizerForViewType"
        )]
		internal static extern void BNRegisterPlatformRecognizerForViewType(
			
			// BNBinaryViewType* type
		    IntPtr type  , 
			
			// uint64_t id
		    ulong id  , 
			
			// BNEndianness endian
		    Endianness endian  , 
			
			// void* callback
		    IntPtr callback  , 
			
			// void* ctx
		    IntPtr ctx  
		);
	}
}