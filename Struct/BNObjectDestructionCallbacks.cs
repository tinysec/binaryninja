using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNObjectDestructionCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** destructBinaryView
		/// </summary>
		public IntPtr destructBinaryView;
		
		/// <summary>
		/// void** destructFileMetadata
		/// </summary>
		public IntPtr destructFileMetadata;
		
		/// <summary>
		/// void** destructFunction
		/// </summary>
		public IntPtr destructFunction;
	}

    public class ObjectDestructionCallbacks 
    {
		public ObjectDestructionCallbacks() 
		{
		    
		}
    }
}