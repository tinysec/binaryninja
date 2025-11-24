using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNCustomDataRenderer 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** freeObject
		/// </summary>
		public IntPtr freeObject;
		
		/// <summary>
		/// void** isValidForData
		/// </summary>
		public IntPtr isValidForData;
		
		/// <summary>
		/// void** getLinesForData
		/// </summary>
		public IntPtr getLinesForData;
		
		/// <summary>
		/// void** freeLines
		/// </summary>
		public IntPtr freeLines;
	}

    public class CustomDataRenderer 
    {
		public CustomDataRenderer() 
		{
		    
		}
    }
}