namespace BinaryNinja
{
	public sealed class MLILReturnHint : MediumLevelILInstruction
	{
		internal MLILReturnHint(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
	}
}
