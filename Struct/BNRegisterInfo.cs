using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNRegisterInfo 
	{
		/// <summary>
		/// uint32_t fullWidthRegister
		/// </summary>
		internal uint fullWidthRegister;
		
		/// <summary>
		/// uint64_t offset
		/// </summary>
		internal ulong offset;
		
		/// <summary>
		/// uint64_t size
		/// </summary>
		internal ulong size;
		
		/// <summary>
		/// BNImplicitRegisterExtend extend
		/// </summary>
		internal ImplicitRegisterExtend extend;
	}

    public sealed class RegisterInfo 
    {
		public uint FullWidthRegister { get;} = 0;
		
		public ulong Offset { get; } = 0;
		
		public ulong Size { get; } = 0;
		
		public ImplicitRegisterExtend Extend { get; } = ImplicitRegisterExtend.NoExtend;

		public RegisterInfo()
		{
			
		}
			
		public RegisterInfo(
			uint fullWidthRegister,
			ulong offset,
			ulong size,
			ImplicitRegisterExtend extend
		)
		{
			this.FullWidthRegister = fullWidthRegister;
			this.Offset = offset;
			this.Size = size;
			this.Extend = extend;
		}
	
		internal RegisterInfo(BNRegisterInfo native)
		{
			this.FullWidthRegister = native.fullWidthRegister;
			this.Offset = native.offset;
			this.Size = native.size;
			this.Extend = native.extend;
		}

		internal static RegisterInfo FromNative(BNRegisterInfo native)
		{
			return new RegisterInfo(native);
		}
    }
}