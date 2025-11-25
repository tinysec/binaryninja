namespace BinaryNinja
{
	public sealed class MediumLevelILFlowGraphEdge : AbstractFlowGraphEdge<MediumLevelILFlowGraphNode>
	{
		public MediumLevelILFlowGraphEdge(
			BNFlowGraphEdge native,
			MediumLevelILFlowGraphNode source,
			MediumLevelILFlowGraphNode target,
			bool outgoing
		): base(native , source, target, outgoing)
		{
			
		}
		
		internal static MediumLevelILFlowGraphEdge FromNativeEx(
			BNFlowGraphEdge native,
			MediumLevelILFlowGraphNode me,
			bool outgoing
		)
		{
			if (outgoing)
			{
				return new MediumLevelILFlowGraphEdge(
					native,
					me , 
					MediumLevelILFlowGraphNode.MustNewFromHandleEx(me.ILFunction, native.target),
					outgoing
				);
			}
			else
			{
				return new MediumLevelILFlowGraphEdge(
					native,
					MediumLevelILFlowGraphNode.MustNewFromHandleEx(me.ILFunction,native.target) , 
					me,
					outgoing
				);
			}
		}
	}
	
	
}
