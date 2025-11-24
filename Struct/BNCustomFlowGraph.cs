using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNCustomFlowGraph 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** prepareForLayout
		/// </summary>
		public IntPtr prepareForLayout;
		
		/// <summary>
		/// void** populateNodes
		/// </summary>
		public IntPtr populateNodes;
		
		/// <summary>
		/// void** completeLayout
		/// </summary>
		public IntPtr completeLayout;
		
		/// <summary>
		/// void** update
		/// </summary>
		public IntPtr update;
		
		/// <summary>
		/// void** freeObject
		/// </summary>
		public IntPtr freeObject;
		
		/// <summary>
		/// void** externalRefTaken
		/// </summary>
		public IntPtr externalRefTaken;
		
		/// <summary>
		/// void** externalRefReleased
		/// </summary>
		public IntPtr externalRefReleased;
	}

    public class CustomFlowGraph 
    {
		public CustomFlowGraph() 
		{
		    
		}
    }
}