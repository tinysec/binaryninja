namespace BinaryNinja
{
	public sealed class HLILNop : HighLevelILInstruction
	{
		internal HLILNop(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
	}
}
