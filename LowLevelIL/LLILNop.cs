namespace BinaryNinja
{
	public sealed class LLILNop : LowLevelILInstruction
	{
		internal LLILNop(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
	}
}
