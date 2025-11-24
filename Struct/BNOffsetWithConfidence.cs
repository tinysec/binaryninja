using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNOffsetWithConfidence 
	{
		/// <summary>
		/// int64_t value
		/// </summary>
		internal long value;
		
		/// <summary>
		/// uint8_t confidence
		/// </summary>
		internal byte confidence;
	}

    public sealed class OffsetWithConfidence : INativeWrapper<BNOffsetWithConfidence>
    {
		public long Value { get; set; } = 0;
		
		public byte Confidence { get; set; } = 0;
		
		public OffsetWithConfidence() 
		{
			
		}
		
		public OffsetWithConfidence(long value, byte confidence) 
		{
		    this.Value = value;
		    this.Confidence = confidence;
		}

		internal static OffsetWithConfidence FromNative(BNOffsetWithConfidence raw)
		{
			return new OffsetWithConfidence(raw.value , raw.confidence);
		}

		public BNOffsetWithConfidence ToNative()
		{
			return new BNOffsetWithConfidence()
			{
				value = this.Value , 
				confidence = this.Confidence
			};
		}
    }
}