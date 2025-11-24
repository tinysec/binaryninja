using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNDownloadProviderCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** createInstance
		/// </summary>
		public IntPtr createInstance;
	}

    public class DownloadProviderCallbacks 
    {
		public DownloadProviderCallbacks() 
		{
		    
		}
    }
}