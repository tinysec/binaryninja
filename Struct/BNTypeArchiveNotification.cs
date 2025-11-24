using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNTypeArchiveNotification 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** typeAdded
		/// </summary>
		public IntPtr typeAdded;
		
		/// <summary>
		/// void** typeUpdated
		/// </summary>
		public IntPtr typeUpdated;
		
		/// <summary>
		/// void** typeRenamed
		/// </summary>
		public IntPtr typeRenamed;
		
		/// <summary>
		/// void** typeDeleted
		/// </summary>
		public IntPtr typeDeleted;
	}

    public class TypeArchiveNotification 
    {
		
		public TypeArchiveNotification() 
		{
		    
		}
    }
}