using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNLinearViewObjectIdentifier 
	{
		/// <summary>
		/// const char* name
		/// </summary>
		internal IntPtr name;
		
		/// <summary>
		/// BNLinearViewObjectIdentifierType type
		/// </summary>
		internal LinearViewObjectIdentifierType type;
		
		/// <summary>
		/// uint64_t start
		/// </summary>
		internal ulong start;
		
		/// <summary>
		/// uint64_t end
		/// </summary>
		internal ulong end;
	}

    public sealed class LinearViewObjectIdentifier : INativeWrapperEx<BNLinearViewObjectIdentifier>
    {
		public string Name { get; set; } = string.Empty;
		
		public LinearViewObjectIdentifierType Type { get; set; } = LinearViewObjectIdentifierType.SingleLinearViewObject;
		
		public ulong Start { get; set; } = 0;
	
		public ulong End { get; set; } = 0;
		
		public LinearViewObjectIdentifier() 
		{
		    
		}

		internal static LinearViewObjectIdentifier FromNativeStructPtr(IntPtr rawPtr)
		{
			if (IntPtr.Zero == rawPtr)
			{
				throw new ArgumentNullException(nameof(rawPtr));
			}
			
			return LinearViewObjectIdentifier.FromNative(Marshal.PtrToStructure<BNLinearViewObjectIdentifier>(rawPtr));
		}

		internal static LinearViewObjectIdentifier FromNative(BNLinearViewObjectIdentifier raw)
		{
			return new LinearViewObjectIdentifier()
			{
				Name = UnsafeUtils.ReadAnsiString(raw.name),
				Type = raw.type,
				Start = raw.start,
				End = raw.end
			};
		}
		
		internal static LinearViewObjectIdentifier TakeNativeStruct(BNLinearViewObjectIdentifier raw)
		{
			LinearViewObjectIdentifier target = LinearViewObjectIdentifier.FromNative(raw);

			NativeMethods.BNFreeLinearViewObjectIdentifier(raw);

			return target;
		}

		public BNLinearViewObjectIdentifier ToNativeEx(ScopedAllocator allocator)
		{
			return new BNLinearViewObjectIdentifier()
			{
				name = allocator.AllocAnsiString(this.Name) , 
				type = this.Type , 
				start = this.Start ,
				end = this.End
			};
		}

    }
}