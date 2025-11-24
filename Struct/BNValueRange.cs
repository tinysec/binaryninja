using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNValueRange 
	{
		/// <summary>
		/// uint64_t start
		/// </summary>
		internal ulong start;
		
		/// <summary>
		/// uint64_t end
		/// </summary>
		internal ulong end;
		
		/// <summary>
		/// uint64_t step
		/// </summary>
		internal ulong step;
	}

    public sealed class ValueRange : INativeWrapper<BNValueRange>
    {
		public ulong Start { get; set; } = 0;
		
		public ulong End { get; set; } = 0;
		
		public ulong Step { get; set; } = 0;
		
		public ValueRange() 
		{
		    
		}

		internal static ValueRange FromNative(BNValueRange native)
		{
			return new ValueRange()
			{
				Start = native.start ,
				End = native.end ,
				Step = native.step
			};
		}
		
		public BNValueRange ToNative()
		{
			return new BNValueRange()
			{
				start = this.Start ,
				end = this.End , 
				step = this.Step
			};
		}
    }
}