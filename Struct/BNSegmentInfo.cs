using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNSegmentInfo 
	{
		/// <summary>
		/// uint64_t start
		/// </summary>
		internal ulong start;
		
		/// <summary>
		/// uint64_t length
		/// </summary>
		internal ulong length;
		
		/// <summary>
		/// uint64_t dataOffset
		/// </summary>
		internal ulong dataOffset;
		
		/// <summary>
		/// uint64_t dataLength
		/// </summary>
		internal ulong dataLength;
		
		/// <summary>
		/// uint32_t flags
		/// </summary>
		internal uint flags;
	}

    public sealed class SegmentInfo : INativeWrapper<BNSegmentInfo>
    {
		public ulong Start { get; set; } = 0;
		
		public ulong Length { get; set; } = 0;
	
		public ulong DataOffset { get; set; } = 0;

		public ulong DataLength { get; set; } = 0;

		public uint Flags { get; set; } = 0;
		
		public SegmentInfo() 
		{
		    
		}

		internal static SegmentInfo FromNative(BNSegmentInfo native)
		{
			return new SegmentInfo()
			{
				Start = native.start ,
				Length = native.length ,
				DataOffset = native.dataOffset ,
				DataLength = native.dataLength ,
				Flags = native.flags ,
			};
		}

		public BNSegmentInfo ToNative()
		{
			return new BNSegmentInfo()
			{
				start = this.Start ,
				length = this.Length ,
				dataOffset = this.DataOffset ,
				dataLength = this.DataLength ,
				flags = this.Flags
			};
		}
    }
}