namespace BinaryNinja
{
	public sealed class MLILIntrinsic : MediumLevelILInstruction
	{
		internal MLILIntrinsic(
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
		
		public Intrinsic Intrinsic
		{
			get
			{
				return this.GetOperandAsIntrinsic((OperandIndex)2);
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
