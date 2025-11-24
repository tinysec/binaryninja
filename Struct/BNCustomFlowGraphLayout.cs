using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNCustomFlowGraphLayout 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** layout
		/// </summary>
		public IntPtr layout;
	}

    public class CustomFlowGraphLayout 
    {
		public CustomFlowGraphLayout() 
		{
		    
		}
    }
}