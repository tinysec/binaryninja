using System;

namespace BinaryNinja
{
	public sealed class SourceLocation : IEquatable<SourceLocation>,
		IComparable<SourceLocation>
	{
		public ulong Address { get;  } = 0;
		
		public OperandIndex Operand { get; } = 0;

		public SourceLocation()
		{
			
		}
		
		public SourceLocation(ulong address, OperandIndex operand)
		{
			this.Address = address;
			this.Operand = operand;
		}
		
		public override bool Equals(object? other)
		{
			return Equals(other as SourceLocation);
		}

		public bool Equals(SourceLocation? other)
		{
			if (other is null)
			{
				return false;
			}

			if (ReferenceEquals(this , other))
			{
				return true;
			}

			if (this.Address != other.Address)
			{
				return false;
			}
			
			return this.Operand == other.Operand;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine<ulong,ulong>(this.Address, (ulong)this.Operand);
		}

		public static bool operator ==(SourceLocation? left, SourceLocation? right)
		{
			if (left is null)
			{
				return right is null;
			}
			
			return left.Equals(right);
		}

		public static bool operator !=(SourceLocation? left, SourceLocation? right)
		{
			return !(left == right);
		}

		public int CompareTo(SourceLocation? other)
		{
			if (other is null)
			{
				return 1;
			}
			
			int result = this.Address.CompareTo(other.Address);

			if (result == 0)
			{
				result = this.Operand.CompareTo(other.Operand);
			}
			
			return result;
		}
	}
}
