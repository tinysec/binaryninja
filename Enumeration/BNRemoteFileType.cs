using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum RemoteFileType : uint
	{
		/// <summary>
		/// 
		/// </summary>
		RawDataFileType = 0,
		
		/// <summary>
		/// 
		/// </summary>
		BinaryViewAnalysisFileType = 1,
		
		/// <summary>
		/// 
		/// </summary>
		TypeArchiveFileType = 2,
		
		/// <summary>
		/// 
		/// </summary>
		UnknownFileType = 3
	}
}