using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNDownloadInstanceOutputCallbacks 
	{
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

    public class DownloadInstanceOutputCallbacks 
    {
		public DownloadInstanceOutputCallbacks() 
		{
		    
		}
    }
}