using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNStringReference 
	{
		/// <summary>
		/// BNStringType type
		/// </summary>
		internal StringType type;
		
		/// <summary>
		/// uint64_t start
		/// </summary>
		internal ulong start;
		
		/// <summary>
		/// uint64_t length
		/// </summary>
		internal ulong length;
	}

    public sealed class StringReference : INativeWrapper<BNStringReference>
    {
	    public StringType Type { get; set; } = StringType.AsciiString;
	    
		public ulong Start { get; set; } = 0;
		
		public ulong Length { get; set; } = 0;
		
		public StringReference() 
		{
		    
		}

		internal static StringReference FromNative(BNStringReference raw)
		{
			return new StringReference()
			{
				Type = raw.type , 
				Start = raw.start ,
				Length = raw.length
			};
		}
		
		public BNStringReference ToNative()
		{
			return new BNStringReference()
			{
				type = this.Type , 
				start = this.Start ,
				length = this.Length
			};
		}
    }
}