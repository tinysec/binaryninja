namespace BinaryNinja
{
	public sealed class MLILTailCall : MediumLevelILInstruction
	{
		internal MLILTailCall(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILVariable[] Output
		{
			get
			{
				return this.GetOperandAsVariableList(0);
			}
		}
		
		public MediumLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
		
		public MediumLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)3);
			}
		}
	}
}
