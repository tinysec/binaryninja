namespace BinaryNinja
{
	public sealed class HLILFloatAbs : HighLevelILInstruction
	{
		internal HLILFloatAbs(
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
