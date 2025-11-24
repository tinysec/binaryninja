namespace BinaryNinja
{
	public sealed class MLILFreeVariableSlotSSA : MediumLevelILInstruction
	{
		internal MLILFreeVariableSlotSSA(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILSSAVariable Destination
		{
			get
			{
				return this.GetOperandAsSSAVariable((OperandIndex)0,(OperandIndex)1);
			}
		}
		
		public MediumLevelILSSAVariable Prev
		{
			get
			{
				return this.GetOperandAsSSAVariable((OperandIndex)0,(OperandIndex)2);
			}
		}
	}
}
