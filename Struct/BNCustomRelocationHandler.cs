using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNCustomRelocationHandler 
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
		/// void** getRelocationInfo
		/// </summary>
		public IntPtr getRelocationInfo;
		
		/// <summary>
		/// void** applyRelocation
		/// </summary>
		public IntPtr applyRelocation;
		
		/// <summary>
		/// void** getOperandForExternalRelocation
		/// </summary>
		public IntPtr getOperandForExternalRelocation;
	}

    public class CustomRelocationHandler 
    {
		public CustomRelocationHandler() 
		{
		    
		}
    }
}