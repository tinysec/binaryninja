using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNDownloadInstanceInputOutputCallbacks 
	{
		/// <summary>
		/// void** readCallback
		/// </summary>
		public IntPtr readCallback;
		
		/// <summary>
		/// void* readContext
		/// </summary>
		public IntPtr readContext;
		
		/// <summary>
		/// void** writeCallback
		/// </summary>
		public IntPtr writeCallback;
		
		/// <summary>
		/// void* writeContext
		/// </summary>
		public IntPtr writeContext;
		
		/// <summary>
		/// void** progressCallback
		/// </summary>
		public IntPtr progressCallback;
		
		/// <summary>
		/// void* progressContext
		/// </summary>
		public IntPtr progressContext;
	}

    public class DownloadInstanceInputOutputCallbacks 
    {
		public DownloadInstanceInputOutputCallbacks() 
		{
		    
		}
    }
}