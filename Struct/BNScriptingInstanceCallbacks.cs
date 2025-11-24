using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNScriptingInstanceCallbacks 
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
		/// void** externalRefTaken
		/// </summary>
		public IntPtr externalRefTaken;
		
		/// <summary>
		/// void** externalRefReleased
		/// </summary>
		public IntPtr externalRefReleased;
		
		/// <summary>
		/// void** executeScriptInput
		/// </summary>
		public IntPtr executeScriptInput;
		
		/// <summary>
		/// void** executeScriptInputFromFilename
		/// </summary>
		public IntPtr executeScriptInputFromFilename;
		
		/// <summary>
		/// void** cancelScriptInput
		/// </summary>
		public IntPtr cancelScriptInput;
		
		/// <summary>
		/// void** releaseBinaryView
		/// </summary>
		public IntPtr releaseBinaryView;
		
		/// <summary>
		/// void** setCurrentBinaryView
		/// </summary>
		public IntPtr setCurrentBinaryView;
		
		/// <summary>
		/// void** setCurrentFunction
		/// </summary>
		public IntPtr setCurrentFunction;
		
		/// <summary>
		/// void** setCurrentBasicBlock
		/// </summary>
		public IntPtr setCurrentBasicBlock;
		
		/// <summary>
		/// void** setCurrentAddress
		/// </summary>
		public IntPtr setCurrentAddress;
		
		/// <summary>
		/// void** setCurrentSelection
		/// </summary>
		public IntPtr setCurrentSelection;
		
		/// <summary>
		/// void** completeInput
		/// </summary>
		public IntPtr completeInput;
		
		/// <summary>
		/// void** stop
		/// </summary>
		public IntPtr stop;
	}

    public class ScriptingInstanceCallbacks 
    {
		public ScriptingInstanceCallbacks() 
		{
		    
		}
    }
}