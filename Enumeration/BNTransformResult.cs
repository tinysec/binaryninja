using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum TransformResult : uint
	{
		/// <summary>
		/// 
		/// </summary>
		TransformSuccess = 0,
		
		/// <summary>
		/// 
		/// </summary>
		TransformNotAttempted = 1,
		
		/// <summary>
		/// 
		/// </summary>
		TransformFailure = 2,
		
		/// <summary>
		/// 
		/// </summary>
		TransformRequiresPassword = 3
	}
}