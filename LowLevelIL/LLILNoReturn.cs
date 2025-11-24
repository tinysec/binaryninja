namespace BinaryNinja
{
	public sealed class LLILNoReturn : LowLevelILInstruction
	{
		internal LLILNoReturn(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
	}
}
