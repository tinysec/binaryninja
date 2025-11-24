using System;

namespace BinaryNinja
{
	public sealed class SemanticFlagGroup :  IEquatable<SemanticFlagGroup>,
		IComparable<SemanticFlagGroup>
	{
		internal Architecture Architecture { get; }

		public SemanticFlagGroupIndex Index { get; }

		internal SemanticFlagGroup(Architecture arch , SemanticFlagGroupIndex index)
		{
			this.Architecture = arch;
			this.Index = index;
		}
		
		internal SemanticFlagGroup(SemanticFlagGroup other)
		{
			this.Architecture = other.Architecture;
			this.Index = other.Index;
		}
		
		public override bool Equals(object? other)
		{
			return Equals(other as SemanticFlagGroup);
		}

		public bool Equals(SemanticFlagGroup? other)
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

		public static bool operator ==(SemanticFlagGroup? left, SemanticFlagGroup? right)
		{
			if (left is null)
			{
				return right is null;
			}
			
			return left.Equals(right);
		}

		public static bool operator !=(SemanticFlagGroup? left, SemanticFlagGroup? right)
		{
			return !(left == right);
		}

		public int CompareTo(SemanticFlagGroup? other)
		{
			if (other is null)
			{
				return 1;
			}
			
			int result = this.Architecture.CompareTo(other.Architecture);

			if (0 == result)
			{
				result = this.Index.CompareTo(other.Index);
			}
			
			return result;
		}
		
		public override string ToString()
		{
			return this.Name;
		}
		
		public string Name
		{
			get
			{
				return this.Architecture.GetSemanticFlagGroupName(this.Index);
			}
		}
	}
}
