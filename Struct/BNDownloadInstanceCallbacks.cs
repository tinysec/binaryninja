using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNDownloadInstanceCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** destroyInstance
		/// </summary>
		public IntPtr destroyInstance;
		
		/// <summary>
		/// void** performRequest
		/// </summary>
		public IntPtr performRequest;
		
		/// <summary>
		/// void** performCustomRequest
		/// </summary>
		public IntPtr performCustomRequest;
		
		/// <summary>
		/// void** freeResponse
		/// </summary>
		public IntPtr freeResponse;
	}

    public class DownloadInstanceCallbacks 
    {
		public DownloadInstanceCallbacks() 
		{
		    
		}
    }
}