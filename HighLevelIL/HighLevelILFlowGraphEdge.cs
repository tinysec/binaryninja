namespace BinaryNinja
{
	public sealed class HighLevelILFlowGraphEdge : AbstractFlowGraphEdge<HighLevelILFlowGraphNode>
	{
		public HighLevelILFunction ILFunction { get; }
		
		internal HighLevelILFlowGraphEdge(
			HighLevelILFunction ilFunction,
			BNFlowGraphEdge native)
			: base(native , HighLevelILFlowGraphNode.NewFromHandleEx(ilFunction, native.target))
		{
			this.ILFunction = ilFunction;
		}
		
		internal static HighLevelILFlowGraphEdge FromNativeEx(
			HighLevelILFunction ilFunction,
			BNFlowGraphEdge native
		)
		{
			return new HighLevelILFlowGraphEdge(
				ilFunction ,
				native
			);
		}
	}
}
