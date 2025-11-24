using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNMainThreadCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** addAction
		/// </summary>
		public IntPtr addAction;
	}

    public class MainThreadCallbacks 
    {
		public MainThreadCallbacks() 
		{
		    
		}
    }
}