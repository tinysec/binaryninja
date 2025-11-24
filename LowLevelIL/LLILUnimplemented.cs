namespace BinaryNinja
{
	public sealed class LLILUnimplemented : LowLevelILInstruction
	{
		internal LLILUnimplemented(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
	}
}
