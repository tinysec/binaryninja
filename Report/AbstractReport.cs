namespace BinaryNinja
{
	public abstract class AbstractReport : IReport
	{
		protected ReportCollection m_collection;

		protected ulong m_index;

		internal AbstractReport(ReportCollection collection , ulong index)
		{
			this.m_collection = collection;
			this.m_index = index;
		}

		public ReportType Type
		{
			get
			{
				return NativeMethods.BNGetReportType(
					this.m_collection.DangerousGetHandle() ,
					this.m_index
				);
			}
		}
		
		public string Title
		{
			get
			{
				return UnsafeUtils.TakeUtf8String(
					NativeMethods.BNGetReportTitle(
						this.m_collection.DangerousGetHandle() ,
						this.m_index
					)
				);
			}
		}

		public BinaryView? View
		{
			get
			{
				return BinaryView.TakeHandle(
					NativeMethods.BNGetReportView(
						this.m_collection.DangerousGetHandle(), this.m_index)
				);
				
			}
		}

		
	}
}
