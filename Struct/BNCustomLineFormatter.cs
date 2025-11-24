using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNCustomLineFormatter 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** formatLines
		/// </summary>
		public IntPtr formatLines;
		
		/// <summary>
		/// void** freeLines
		/// </summary>
		public IntPtr freeLines;
	}

    public class CustomLineFormatter 
    {
		public CustomLineFormatter() 
		{
		    
		}
    }
}