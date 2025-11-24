using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNArchitectureAndAddress 
	{
		/// <summary>
		/// BNArchitecture* arch
		/// </summary>
		internal IntPtr arch;
		
		/// <summary>
		/// uint64_t address
		/// </summary>
		internal ulong address;
	}

    public sealed class ArchitectureAndAddress : INativeWrapper<BNArchitectureAndAddress>
    {
		public Architecture Architecture { get; set; }
		
		public ulong Address { get; set; } = 0;
		
		public ArchitectureAndAddress(Architecture arch , ulong address) 
		{
		    this.Architecture = arch;
		    this.Address = address;
		}

		internal static ArchitectureAndAddress FromNative(BNArchitectureAndAddress raw)
		{
			return new ArchitectureAndAddress(
				Architecture.MustFromHandle(raw.arch),
				raw.address
			);
		}

		public BNArchitectureAndAddress ToNative()
		{
			return new BNArchitectureAndAddress()
			{
				arch = this.Architecture.DangerousGetHandle() , address = this.Address
			};
		}
    }
}