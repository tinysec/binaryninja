using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum DisassemblyAddressMode : uint
	{
		/// <summary>
		/// 
		/// </summary>
		AbsoluteDisassemblyAddressMode = 0,
		
		/// <summary>
		/// 
		/// </summary>
		RelativeToBinaryStartDisassemblyAddressMode = 1,
		
		/// <summary>
		/// 
		/// </summary>
		RelativeToSegmentStartDisassemblyAddressMode = 2,
		
		/// <summary>
		/// 
		/// </summary>
		RelativeToSectionStartDisassemblyAddressMode = 3,
		
		/// <summary>
		/// 
		/// </summary>
		RelativeToFunctionStartDisassemblyAddressMode = 4,
		
		/// <summary>
		/// 
		/// </summary>
		RelativeToAddressBaseOffsetDisassemblyAddressMode = 5,
		
		/// <summary>
		/// 
		/// </summary>
		RelativeToDataStartDisassemblyAddressMode = 6,
		
		/// <summary>
		/// 
		/// </summary>
		DisassemblyAddressModeMask = 65535,
		
		/// <summary>
		/// 
		/// </summary>
		IncludeNameDisassemblyAddressModeFlag = 65536,
		
		/// <summary>
		/// 
		/// </summary>
		DecimalDisassemblyAddressModeFlag = 131072,
		
		/// <summary>
		/// 
		/// </summary>
		DisassemblyAddressModeFlagsMask = 4294901760
	}
}