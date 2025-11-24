using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNScriptingOutputListener 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** output
		/// </summary>
		public IntPtr output;
		
		/// <summary>
		/// void** warning
		/// </summary>
		public IntPtr warning;
		
		/// <summary>
		/// void** error
		/// </summary>
		public IntPtr error;
		
		/// <summary>
		/// void** inputReadyStateChanged
		/// </summary>
		public IntPtr inputReadyStateChanged;
	}

    public class ScriptingOutputListener 
    {
		public ScriptingOutputListener() 
		{
		    
		}
    }
}