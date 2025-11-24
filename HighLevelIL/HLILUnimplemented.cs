namespace BinaryNinja
{
	public sealed class HLILUnimplemented : HighLevelILInstruction
	{
		internal HLILUnimplemented(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
	}
}
