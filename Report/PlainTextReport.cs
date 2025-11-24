namespace BinaryNinja
{
	public sealed class PlainTextReport : AbstractReport
	{
		internal PlainTextReport(ReportCollection collection , ulong index):
			base(collection, index)
		{
			
		}
		
		public string Contents
		{
			get
			{
				return UnsafeUtils.TakeUtf8String(
					NativeMethods.BNGetReportContents(
						this.m_collection.DangerousGetHandle() ,
						this.m_index
					)
				);
			}
		}
	}
}
