using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum AnalysisWarningActionType : uint
	{
		/// <summary>
		/// 
		/// </summary>
		NoAnalysisWarningAction = 0,
		
		/// <summary>
		/// 
		/// </summary>
		ForceAnalysisWarningAction = 1,
		
		/// <summary>
		/// 
		/// </summary>
		ShowStackGraphWarningAction = 2,
		
		/// <summary>
		/// 
		/// </summary>
		DisableGuidedAnalysisWarningAction = 3
	}
}