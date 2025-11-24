using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNScriptingProviderCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** createInstance
		/// </summary>
		public IntPtr createInstance;
		
		/// <summary>
		/// void** loadModule
		/// </summary>
		public IntPtr loadModule;
		
		/// <summary>
		/// void** installModules
		/// </summary>
		public IntPtr installModules;
	}

    public class ScriptingProviderCallbacks 
    {
		public ScriptingProviderCallbacks() 
		{
		    
		}
    }
}