using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNParameterVariablesWithConfidence 
	{
		/// <summary>
		/// BNVariable* vars
		/// </summary>
		internal IntPtr variables;
		
		/// <summary>
		/// uint64_t count
		/// </summary>
		internal ulong count;
		
		/// <summary>
		/// uint8_t confidence
		/// </summary>
		internal byte confidence;
	}

    public class ParameterVariablesWithConfidence 
    {
		public Variable[] Variables { get; set; } = Array.Empty<Variable>();
		
		public byte Confidence { get; set; } = 0;
	
		internal ParameterVariablesWithConfidence(
			Function function,
			BNParameterVariablesWithConfidence native)
		{
			this.Variables = UnsafeUtils.ReadStructArray<BNVariable , Variable>(
				native.variables ,
				native.count ,
				( _variable) => { return Variable.FromNativeEx(function , _variable);}
			);
			
			this.Confidence = native.confidence;
		}

		public BNParameterVariablesWithConfidence ToNativeEx(ScopedAllocator allocator)
		{
			return new BNParameterVariablesWithConfidence()
			{
				variables = allocator.AllocStructArray( 
					UnsafeUtils.ConvertToNativeArray<BNVariable , Variable>(
					this.Variables
				)) ,
				count = (ulong)this.Variables.Length ,
				confidence = this.Confidence
			};
		}
    }
}