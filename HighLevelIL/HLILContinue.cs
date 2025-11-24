namespace BinaryNinja
{
	public sealed class HLILContinue : HighLevelILInstruction
	{
		internal HLILContinue(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
	}
}
