namespace BinaryNinja
{
	public sealed class HLILVariableInitSSA : HighLevelILInstruction
	{
		internal HLILVariableInitSSA(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILSSAVariable Destination
		{
			get
			{
				return this.GetOperandAsSSAVariable((OperandIndex)0 , (OperandIndex)1);
			}
		}
		
		public HighLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
	}
}
