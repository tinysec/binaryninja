using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNVariableReferenceSource 
	{
		/// <summary>
		/// BNVariable _var
		/// </summary>
		public BNVariable variable;
		
		/// <summary>
		/// BNILReferenceSource source
		/// </summary>
		public BNILReferenceSource source;
	}

    public class VariableReferenceSource 
    {
		/// <summary>
		/// BNVariable _var
		/// </summary>
		public Variable Variable { get; set; }
		
		/// <summary>
		/// BNILReferenceSource source
		/// </summary>
		public ILReferenceSource Source { get; set; }
		
		public VariableReferenceSource(Variable variable , ILReferenceSource source) 
		{
		    this.Variable = variable;
		    this.Source = source;
		}
    }
}