namespace BinaryNinja
{
	public sealed class HTMLReport : AbstractReport
	{
		internal HTMLReport(ReportCollection collection , ulong index):
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
		
		public string PlainText
		{
			get
			{
				return UnsafeUtils.TakeUtf8String(
					NativeMethods.BNGetReportPlainText(
						this.m_collection.DangerousGetHandle() ,
						this.m_index
					)
				);
			}
		}
	}
}
