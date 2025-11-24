namespace BinaryNinja
{
	public sealed class LLILSysCall : LowLevelILInstruction
	{
		internal LLILSysCall(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
	}
}
