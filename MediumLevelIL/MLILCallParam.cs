namespace BinaryNinja
{
	public sealed class MLILCallParam : MediumLevelILInstruction
	{
		internal MLILCallParam(
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
