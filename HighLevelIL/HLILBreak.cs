namespace BinaryNinja
{
	public sealed class HLILBreak : HighLevelILInstruction
	{
		internal HLILBreak(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
	}
}
