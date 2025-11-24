using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNWebsocketClientOutputCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** connectedCallback
		/// </summary>
		public IntPtr connectedCallback;
		
		/// <summary>
		/// void** disconnectedCallback
		/// </summary>
		public IntPtr disconnectedCallback;
		
		/// <summary>
		/// void** errorCallback
		/// </summary>
		public IntPtr errorCallback;
		
		/// <summary>
		/// void** readCallback
		/// </summary>
		public IntPtr readCallback;
	}

    public class WebsocketClientOutputCallbacks 
    {
		public WebsocketClientOutputCallbacks() 
		{
		    
		}
    }
}