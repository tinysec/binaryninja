using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNDebugFunctionInfo 
	{
		/// <summary>
		/// const char* shortName
		/// </summary>
		public IntPtr shortName;
		
		/// <summary>
		/// const char* fullName
		/// </summary>
		public IntPtr fullName;
		
		/// <summary>
		/// const char* rawName
		/// </summary>
		public IntPtr rawName;
		
		/// <summary>
		/// uint64_t address
		/// </summary>
		public ulong address;
		
		/// <summary>
		/// BNType* type
		/// </summary>
		public IntPtr type;
		
		/// <summary>
		/// BNPlatform* platform
		/// </summary>
		public IntPtr platform;
		
		/// <summary>
		/// const char** components
		/// </summary>
		public IntPtr components;
		
		/// <summary>
		/// uint64_t componentN
		/// </summary>
		public ulong componentN;
		
		/// <summary>
		/// BNVariableNameAndType* localVariables
		/// </summary>
		public IntPtr localVariables;
		
		/// <summary>
		/// uint64_t localVariableN
		/// </summary>
		public ulong localVariableN;
	}

    public class DebugFunctionInfo 
    {
		public string ShortName { get; set; } = string.Empty;
		
		public string FullName { get; set; } = string.Empty;

		public string RawName { get; set; } = string.Empty;
		
		public ulong Address { get; set; } = 0;
		
		public BinaryNinja.Type? Type { get; set; } = null;
		
		public Platform? Platform { get; set; } = null;
		
		public string[] Components { get; set; } = Array.Empty<string>();
		
		public VariableNameAndType[] LocalVariables { get; set; } = Array.Empty<VariableNameAndType>();
		
		public DebugFunctionInfo() 
		{
		    
		}
    }
}