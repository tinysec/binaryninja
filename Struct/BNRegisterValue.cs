using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNRegisterValue 
	{
		/// <summary>
		/// BNRegisterValueType state
		/// </summary>
		internal RegisterValueType state;
		
		/// <summary>
		/// int64_t value
		/// </summary>
		internal long value;
		
		/// <summary>
		/// int64_t offset
		/// </summary>
		internal long offset;
		
		/// <summary>
		/// uint64_t size
		/// </summary>
		internal ulong size;
	}

    public sealed class RegisterValue : INativeWrapper<BNRegisterValue>
    {
		public RegisterValueType State { get; set; } = RegisterValueType.UndeterminedValue;
		
		public long Value { get; set; } = 0;
		
		public long Offset { get; set; } = 0;

		public ulong Size { get; set; } = 0;
		
		public RegisterValue() 
		{
		    
		}

		internal static RegisterValue FromNative(BNRegisterValue native)
		{
			return new RegisterValue()
			{
				State = native.state,
				Value = native.value,
				Offset = native.offset,
				Size = native.size
			};
		}

		public BNRegisterValue ToNative()
		{
			return new BNRegisterValue()
			{
				state = this.State,
				value = this.Value,
				offset = this.Offset,
				size = this.Size
			};
		}
    }
}