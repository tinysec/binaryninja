using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNNavigationHandler 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** getCurrentView
		/// </summary>
		public IntPtr getCurrentView;
		
		/// <summary>
		/// void** getCurrentOffset
		/// </summary>
		public IntPtr getCurrentOffset;
		
		/// <summary>
		/// void** navigate
		/// </summary>
		public IntPtr navigate;
	}

    public class NavigationHandler 
    {
		public NavigationHandler() 
		{
		    
		}
    }
}