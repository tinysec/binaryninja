using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFlowGraphNodeSetVisibilityRegion(BNFlowGraphNode* node, int32_t x, int32_t y, int32_t w, int32_t h)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFlowGraphNodeSetVisibilityRegion"
        )]
		internal static extern void BNFlowGraphNodeSetVisibilityRegion(
			
			// BNFlowGraphNode* node
		    IntPtr node  , 
			
			// int32_t x
		    int x  , 
			
			// int32_t y
		    int y  , 
			
			// int32_t w
		    int width  , 
			
			// int32_t h
		    int height  
		);
	}
}