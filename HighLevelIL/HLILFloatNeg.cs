namespace BinaryNinja
{
	public sealed class HLILFloatNeg : HighLevelILInstruction
	{
		internal HLILFloatNeg(
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
