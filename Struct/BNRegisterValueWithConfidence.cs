using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNRegisterValueWithConfidence 
	{
		/// <summary>
		/// BNRegisterValue value
		/// </summary>
		internal BNRegisterValue value;
		
		/// <summary>
		/// uint8_t confidence
		/// </summary>
		internal byte confidence;
	}

    public sealed class RegisterValueWithConfidence : INativeWrapper<BNRegisterValueWithConfidence>
    {
		public RegisterValue Value { get; set; } = new RegisterValue();
		
		public byte Confidence { get; set; } = 0;
		
		public RegisterValueWithConfidence() 
		{
		    
		}
		
		internal static RegisterValueWithConfidence FromNative(BNRegisterValueWithConfidence native)
		{
			return new RegisterValueWithConfidence()
			{
				Value = RegisterValue.FromNative(native.value),
				Confidence = native.confidence
			};
		}

		public BNRegisterValueWithConfidence ToNative()
		{
			return new BNRegisterValueWithConfidence()
			{
				value = this.Value.ToNative(),
				confidence = this.Confidence
			};
		}
    }
}