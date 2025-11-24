namespace BinaryNinja
{
	public sealed class MLILFreeVariableSlot : MediumLevelILInstruction
	{
		internal MLILFreeVariableSlot(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILVariable Destination
		{
			get
			{
				return this.GetOperandAsVariable(0);
			}
		}
	}
}
