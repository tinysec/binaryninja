using System;

namespace BinaryNinja
{
	public sealed class Intrinsic  : IEquatable<Intrinsic>,
		IComparable<Intrinsic>
	{
		public Architecture  Architecture { get; }
		
		public IntrinsicIndex Index { get; }

		public Intrinsic(Architecture arch , IntrinsicIndex index)
		{
			this.Architecture = arch;
			this.Index = index;
		}

		public override string ToString()
		{
			return this.Name;
		}
		
		public override bool Equals(object? other)
		{
			return Equals(other as Intrinsic);
		}

		public bool Equals(Intrinsic? other)
		{
			if (other is null)
			{
				return false;
			}

			if (ReferenceEquals(this , other))
			{
				return true;
			}

			if (this.Architecture != other.Architecture)
			{
				return false;
			}
			
			return this.Index == other.Index;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine<int,uint>(this.Architecture.GetHashCode(), (uint)this.Index);
		}

		public static bool operator ==(Intrinsic? left, Intrinsic? right)
		{
			if (left is null)
			{
				return right is null;
			}
			
			return left.Equals(right);
		}

		public static bool operator !=(Intrinsic? left, Intrinsic? right)
		{
			return !(left == right);
		}

		public int CompareTo(Intrinsic? other)
		{
			if (other is null)
			{
				return 1;
			}
			
			int result = this.Architecture.CompareTo(other.Architecture);

			if (0 == result)
			{
				return this.Index.CompareTo(other.Index);
			}

			return result;
		}

		public IntrinsicClass IntrinsicClass
		{
			get
			{
				return NativeMethods.BNGetArchitectureIntrinsicClass(
					this.Architecture.DangerousGetHandle(),
					this.Index
				);
			}
		}
		
		public string Name
		{
			get
			{
				return UnsafeUtils.TakeAnsiString(
					NativeMethods.BNGetArchitectureIntrinsicName(
						this.Architecture.DangerousGetHandle() ,
						this.Index
					)
				);
			}
		}
		
		public NameAndType[] Inputs
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetArchitectureIntrinsicInputs(
					this.Architecture.DangerousGetHandle() ,
					this.Index ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArrayEx<BNNameAndType , NameAndType>(
					arrayPointer ,
					arrayLength ,
					NameAndType.FromNative ,
					NativeMethods.BNFreeNameAndTypeList
				);
			}
		}

		public TypeWithConfidence[] Outputs
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetArchitectureIntrinsicOutputs(
					this.Architecture.DangerousGetHandle() ,
					this.Index ,
					out ulong arrayLength
				);

				return UnsafeUtils.TakeStructArrayEx<BNTypeWithConfidence , TypeWithConfidence>(
					arrayPointer ,
					arrayLength ,
					TypeWithConfidence.FromNative ,
					NativeMethods.BNFreeOutputTypeList
				);
			}
		}
		
	}
}
