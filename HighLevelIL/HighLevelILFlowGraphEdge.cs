using System;

namespace BinaryNinja
{
	public sealed class HighLevelILFlowGraphEdge 
		: AbstractFlowGraphEdge<HighLevelILFlowGraphNode>,
		IEquatable<HighLevelILFlowGraphEdge>, 
		IComparable<HighLevelILFlowGraphEdge>
	{
		internal HighLevelILFlowGraphEdge(
			BNFlowGraphEdge native,
			HighLevelILFlowGraphNode source,
			HighLevelILFlowGraphNode target,
			bool outgoing
		) : base(native , source, target, outgoing)
		{
			
		}
		
		internal static HighLevelILFlowGraphEdge FromNativeEx(
			BNFlowGraphEdge native,
			HighLevelILFlowGraphNode me,
			bool outgoing
		)
		{
			if (outgoing)
			{
				return new HighLevelILFlowGraphEdge(
					native,
					me , 
					HighLevelILFlowGraphNode.MustNewFromHandleEx(me.ILFunction, native.target),
					outgoing
				);
			}
			else
			{
				return new HighLevelILFlowGraphEdge(
					native,
					HighLevelILFlowGraphNode.MustNewFromHandleEx(me.ILFunction,native.target) , 
					me,
					outgoing
				);
			}
		}
		
		public override bool Equals(object? other)
		{
			return this.Equals(other as HighLevelILFlowGraphEdge);
		}

		public bool Equals(HighLevelILFlowGraphEdge? other)
		{
			if (other is null)
			{
				return false;
			}

			if (ReferenceEquals(this , other))
			{
				return true;
			}

			if (this.Type != other.Type)
			{
				return false;
			}
			
			if (this.Source != other.Source)
			{
				return false;
			}
			
			if (this.Target != other.Target)
			{
				return false;
			}

			return true;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2218:OverrideGetHashCodeOnOverridingEquals")]
		public override int GetHashCode()
		{
			return HashCode.Combine<uint,int,int>( 
				(uint)this.Type,
				this.Source.GetHashCode(),
				this.Target.GetHashCode()
			);
		}

		public static bool operator ==(HighLevelILFlowGraphEdge? left, HighLevelILFlowGraphEdge? right)
		{
			if (left is null)
			{
				return right is null;
			}
			
			return left.Equals(right);
		}

		public static bool operator !=(HighLevelILFlowGraphEdge? left, HighLevelILFlowGraphEdge? right)
		{
			return !(left == right);
		}

		public int CompareTo(HighLevelILFlowGraphEdge? other)
		{
			if (other is null)
			{
				return 1;
			}
			
			int result = this.Type.CompareTo(other.Type);

			if (0 == result)
			{
				result = this.Source.CompareTo(other.Source);
			}
			
			if (0 == result)
			{
				result = this.Target.CompareTo(other.Target);
			}
			
			return result;
		}
	}
}
