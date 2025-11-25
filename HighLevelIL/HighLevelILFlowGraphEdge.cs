namespace BinaryNinja
{
	public sealed class HighLevelILFlowGraphEdge : AbstractFlowGraphEdge<HighLevelILFlowGraphNode>
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
	}
}
