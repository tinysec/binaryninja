using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearDisassemblyLine* BNGetLinearViewObjectLines(BNLinearViewObject* obj, BNLinearViewObject* prev, BNLinearViewObject* next, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLinearViewObjectLines"
        )]
		internal static extern IntPtr BNGetLinearViewObjectLines(
			
			// BNLinearViewObject* obj
		    IntPtr obj  , 
			
			// BNLinearViewObject* prev
		    IntPtr prev  , 
			
			// BNLinearViewObject* next
		    IntPtr next  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}