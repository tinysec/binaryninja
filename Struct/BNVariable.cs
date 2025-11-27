using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNVariable 
	{
		/// <summary>
		/// BNVariableSourceType type
		/// </summary>
		internal VariableSourceType type;
		
		/// <summary>
		/// uint32_t index
		/// </summary>
		internal uint index;
		
		/// <summary>
		/// int64_t storage
		/// </summary>
		internal long storage;
	}
	
     public abstract class AbstractVariable : INativeWrapper<BNVariable>, 
	     IEquatable<AbstractVariable>,
	     IComparable<AbstractVariable>
    {
		public VariableSourceType Source { get; internal set; } = VariableSourceType.StackVariableSourceType;
		
		public uint Index { get; internal set; } = 0;
		
		public long Storage { get; internal set; } = 0;

		internal AbstractVariable()
		{
			
		}
		
		internal AbstractVariable(
			VariableSourceType source,
			uint index,
			long storage
		) 
		{
			this.Source = source;
			this.Index = index;
			this.Storage = storage;
		}
		
		internal AbstractVariable(BNVariable native)
		{
			this.Source = native.type;
			this.Index = native.index;
			this.Storage = native.storage;
		}
		
		public BNVariable ToNative()
		{
			return new BNVariable()
			{
				type = this.Source ,
				index = this.Index ,
				storage = this.Storage
			};
		}

		public ulong Identifier
		{
			get
			{
				return NativeMethods.BNToVariableIdentifier(this.ToNative());
			}
		}
		
		public override bool Equals(object? other)
		{
			return Equals(other as AbstractVariable);
		}

		public bool Equals(AbstractVariable? other)
		{
			if (other is null)
			{
				return false;
			}

			if (ReferenceEquals(this , other))
			{
				return true;
			}
			
			return this.Identifier == other.Identifier;
		}

		public override int GetHashCode()
		{
			return this.Identifier.GetHashCode();
		}

		public static bool operator ==(AbstractVariable? left, AbstractVariable? right)
		{
			if (left is null)
			{
				return right is null;
			}
			
			return left.Equals(right);
		}

		public static bool operator !=(AbstractVariable? left, AbstractVariable? right)
		{
			return !(left == right);
		}

		public int CompareTo(AbstractVariable? other)
		{
			if (other is null)
			{
				return 1;
			}
			
			return this.Identifier.CompareTo(other.Identifier);
		}
    }
     
    public sealed class CoreVariable : AbstractVariable
    {
		internal CoreVariable()
		{
			
		}
		
		internal CoreVariable(
			VariableSourceType type,
			uint index,
			long storage
		) : base(type, index, storage)
		{
			
		}
		
		internal CoreVariable(BNVariable native)
			:base(native)
		{
			
		}
		
		internal static CoreVariable FromIdentifier(ulong identifier)
		{
			return new CoreVariable(
				NativeMethods.BNFromVariableIdentifier(identifier)
			);
		}
		
		internal static CoreVariable FromNative(BNVariable native)
		{
			return new CoreVariable(native);
		}
    }

}