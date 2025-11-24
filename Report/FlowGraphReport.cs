namespace BinaryNinja
{
	public sealed class FlowGraphReport : AbstractReport
	{
		internal FlowGraphReport(ReportCollection collection , ulong index):
			base(collection, index)
		{
			
		}
		
		public FlowGraph FlowGraph
		{
			get
			{
				return FlowGraph.MustTakeHandle(
					NativeMethods.BNGetReportFlowGraph(
						this.m_collection.DangerousGetHandle() ,
						this.m_index
					)
				);
			}
		}
		
	}
}
