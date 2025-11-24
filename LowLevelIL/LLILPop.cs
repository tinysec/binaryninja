namespace BinaryNinja
{
	public sealed class LLILPop : LowLevelILInstruction
	{
		internal LLILPop(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native 
		) : base(function , expressionIndex , native)
		{
			
		}
	}
}
