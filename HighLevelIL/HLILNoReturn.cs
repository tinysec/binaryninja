namespace BinaryNinja
{
	public sealed class HLILNoReturn : HighLevelILInstruction
	{
		internal HLILNoReturn(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
	}
}
