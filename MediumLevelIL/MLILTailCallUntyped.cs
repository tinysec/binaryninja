namespace BinaryNinja
{
	public sealed class MLILTailCallUntyped : MediumLevelILInstruction
	{
		internal MLILTailCallUntyped(
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
		
		public MediumLevelILInstruction Dest
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
		
		public MediumLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)2);
			}
		}
		
		public MediumLevelILInstruction Stack
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)3);
			}
		}
	}
}
