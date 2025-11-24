using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNApplyRenderLayerToLinearViewObject(BNRenderLayer* renderLayer, BNLinearViewObject* obj, BNLinearViewObject* prev, BNLinearViewObject* next, BNLinearDisassemblyLine* inLines, uint64_t inLineCount, BNLinearDisassemblyLine** outLines, uint64_t* outLineCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNApplyRenderLayerToLinearViewObject"
        )]
		internal static extern void BNApplyRenderLayerToLinearViewObject(
			
			// BNRenderLayer* renderLayer
		    IntPtr renderLayer  , 
			
			// BNLinearViewObject* obj
		    IntPtr obj  , 
			
			// BNLinearViewObject* prev
		    IntPtr prev  , 
			
			// BNLinearViewObject* next
		    IntPtr next  , 
			
			// BNLinearDisassemblyLine* inLines
			BNLinearDisassemblyLine[] inLines  , 
			
			// uint64_t inLineCount
		    ulong inLineCount  , 
			
			// BNLinearDisassemblyLine** outLines
		    out IntPtr outLines  , 
			
			// uint64_t* outLineCount
			out ulong outLineCount  
		);
	}
}