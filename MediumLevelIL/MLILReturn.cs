namespace BinaryNinja
{
	public sealed class MLILReturn : MediumLevelILInstruction
	{
		internal MLILReturn(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILInstruction[] Source
		{
			get
			{
				return this.GetOperandAsExpressionList(0);
			}
		}
	}
}
