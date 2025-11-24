namespace BinaryNinja
{
	public sealed class MLILSysCall : MediumLevelILInstruction
	{
		internal MLILSysCall(
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
		
		public MediumLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)2);
			}
		}
	}
}
