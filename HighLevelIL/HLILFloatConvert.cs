namespace BinaryNinja
{
	public sealed class HLILFloatConvert : HighLevelILInstruction
	{
		internal HLILFloatConvert(
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
