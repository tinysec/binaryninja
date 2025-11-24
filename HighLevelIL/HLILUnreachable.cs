namespace BinaryNinja
{
	public sealed class HLILUnreachable : HighLevelILInstruction
	{
		internal HLILUnreachable(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
	}
}
