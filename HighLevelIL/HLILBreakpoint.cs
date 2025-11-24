namespace BinaryNinja
{
	public sealed class HLILBreakpoint : HighLevelILInstruction
	{
		internal HLILBreakpoint(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
	}
}
