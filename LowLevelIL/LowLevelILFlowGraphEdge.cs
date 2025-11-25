namespace BinaryNinja
{
	public sealed class LowLevelILFlowGraphEdge : AbstractFlowGraphEdge<LowLevelILFlowGraphNode>
	{
		public LowLevelILFlowGraphEdge(
			BNFlowGraphEdge native,
			LowLevelILFlowGraphNode source,
			LowLevelILFlowGraphNode target,
			bool outgoing
		) : base(native , source, target, outgoing)
		{
			
		}
		
		internal static LowLevelILFlowGraphEdge FromNativeEx(
			BNFlowGraphEdge native,
			LowLevelILFlowGraphNode me,
			bool outgoing
		)
		{
			if (outgoing)
			{
				return new LowLevelILFlowGraphEdge(
					native,
					me , 
					LowLevelILFlowGraphNode.MustNewFromHandleEx(me.ILFunction, native.target),
					outgoing
				);
			}
			else
			{
				return new LowLevelILFlowGraphEdge(
					native,
					LowLevelILFlowGraphNode.MustNewFromHandleEx(me.ILFunction,native.target) , 
					me,
					outgoing
				);
			}
		}
	}
}
