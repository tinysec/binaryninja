using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNRenderLayerCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** applyToFlowGraph
		/// </summary>
		public IntPtr applyToFlowGraph;
		
		/// <summary>
		/// void** applyToLinearViewObject
		/// </summary>
		public IntPtr applyToLinearViewObject;
		
		/// <summary>
		/// void** freeLines
		/// </summary>
		public IntPtr freeLines;
	}

    public class RenderLayerCallbacks 
    {
		public RenderLayerCallbacks() 
		{
		    
		}
    }
}