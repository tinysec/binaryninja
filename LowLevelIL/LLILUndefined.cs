namespace BinaryNinja
{
	public sealed class LLILUndefined : LowLevelILInstruction
	{
		internal LLILUndefined(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
	}
}
