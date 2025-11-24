namespace BinaryNinja
{
	public sealed class HLILUndefined : HighLevelILInstruction
	{
		internal HLILUndefined(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
	}
}
