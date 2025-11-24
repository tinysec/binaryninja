namespace BinaryNinja
{
	public sealed class MLILFloatSquareRoot : MediumLevelILInstruction
	{
		internal MLILFloatSquareRoot(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
	}
}
