namespace BinaryNinja
{
	public sealed class HLILFloatSquareRoot : HighLevelILInstruction
	{
		internal HLILFloatSquareRoot(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction Left
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
	}
}
