using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNVariableFieldResolutionInfo 
	{
		/// <summary>
		/// BNArchitectureAndAddress location
		/// </summary>
		internal BNArchitectureAndAddress location;
		
		/// <summary>
		/// BNVariable _var
		/// </summary>
		internal BNVariable variable;
		
		/// <summary>
		/// BNFieldResolutionInfo* info
		/// </summary>
		internal IntPtr info;
	}

    public class VariableFieldResolutionInfo 
    {
		public ArchitectureAndAddress Location;
		
		public CoreVariable Variable { get; set; }
		
		public FieldResolutionInfo? Info { get; set; } = null;
		
		internal VariableFieldResolutionInfo(
			BNVariableFieldResolutionInfo native
		) 
		{
		    this.Location = ArchitectureAndAddress.FromNative(native.location);
		    this.Variable = CoreVariable.FromNative(native.variable);
		}
    }
}