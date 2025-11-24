namespace BinaryNinja
{
	public sealed class LLILBreakpoint : LowLevelILInstruction
	{
		internal LLILBreakpoint(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
	}
}
