namespace BinaryNinja
{
	public sealed class MLILSharedParamSlot : MediumLevelILInstruction
	{
		internal MLILSharedParamSlot(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList(0);
			}
		}
	}
}
