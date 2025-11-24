using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNBinaryViewEvent 
	{
		/// <summary>
		/// BNBinaryViewEventType type
		/// </summary>
		public BinaryViewEventType type;
		
		/// <summary>
		/// void** callback
		/// </summary>
		public IntPtr callback;
		
		/// <summary>
		/// void* ctx
		/// </summary>
		public IntPtr ctx;
	}

    public class BinaryViewEvent 
    {
		
		public BinaryViewEvent() 
		{
		    
		}
    }
}