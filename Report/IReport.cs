namespace BinaryNinja
{
	public interface IReport
	{
		public ReportType Type
		{
			get;
		}

		public string Title
		{
			get;
		}

		public BinaryView? View
		{
			get;
		}
	}
}
