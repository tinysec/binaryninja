using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNPossibleValueSet 
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
		
		/// <summary>
		/// BNValueRange* ranges
		/// </summary>
		internal IntPtr ranges;
		
		/// <summary>
		/// int64_t* valueSet
		/// </summary>
		internal IntPtr valueSet;
		
		/// <summary>
		/// BNLookupTableEntry* table
		/// </summary>
		internal IntPtr table;
		
		/// <summary>
		/// uint64_t count
		/// </summary>
		internal ulong count;
	}

    public sealed class PossibleValueSet : INativeWrapperEx<BNPossibleValueSet>
    {
		public RegisterValueType State { get; set; } = RegisterValueType.UndeterminedValue;
		
		public long Value { get; set; } = 0;
		
		public long Offset { get; set; } = 0;
		
		public ulong Size { get; set; } = 0;
		
		public ValueRange[] Ranges { get; set; } = Array.Empty<ValueRange>();
		
		public ulong[] ValueSet { get; set; } = Array.Empty<ulong>();
		
		public LookupTableEntry[] Table { get; set; } = Array.Empty<LookupTableEntry>();
		
		public PossibleValueSet() 
		{
		    
		}

		internal static PossibleValueSet FromNative(BNPossibleValueSet native)
		{
			return new PossibleValueSet()
			{
				State = native.state ,
				Value = native.value ,
				Offset = native.offset ,
				Size = native.size ,
				Ranges = UnsafeUtils.ReadStructArray<BNValueRange , ValueRange>(
					native.ranges ,
					native.count ,
					ValueRange.FromNative
				),
				ValueSet = UnsafeUtils.ReadNumberArray<ulong>(
					native.valueSet ,
					native.count 
				),
				Table = UnsafeUtils.ReadStructArray<BNLookupTableEntry , LookupTableEntry>(
					native.table ,
					native.count ,
					LookupTableEntry.FromNative
				),
			};
		}

		internal static PossibleValueSet TakeNative(BNPossibleValueSet native)
		{
			PossibleValueSet valueSet = PossibleValueSet.FromNative(native);
			
			NativeMethods.BNFreePossibleValueSet(native);

			return valueSet;
		}

		public BNPossibleValueSet ToNativeEx(ScopedAllocator allocator)
		{
			return new BNPossibleValueSet()
			{
				state = this.State ,
				value = this.Value ,
				offset = this.Offset ,
				size = this.Size ,
				ranges = (
					0 == this.Ranges.Length
						? IntPtr.Zero
						: allocator.AllocStructArray<BNValueRange>(
							UnsafeUtils.ConvertToNativeArray<BNValueRange , ValueRange>(this.Ranges)
						)
				) ,
				valueSet = (
					0 == this.ValueSet.Length ? IntPtr.Zero : allocator.AllocIntegerArray(this.ValueSet)
				) ,
				table = (
					0 == this.Table.Length
						? IntPtr.Zero
						: allocator.AllocStructArray<BNLookupTableEntry>(
							allocator.ConvertToNativeArrayEx<BNLookupTableEntry , LookupTableEntry>(this.Table)
						)
				) ,
				count = ( 0 != this.Ranges.Length 
						? (ulong)this.Ranges.Length
						: (  0 != this.ValueSet.Length ? 
							(ulong)this.ValueSet.Length : (ulong)this.Table.Length)
					),
			};
		}
    }
}