namespace BinaryNinja
{
	public sealed class MLILAddOverflow : MediumLevelILInstruction
	{
		internal MLILAddOverflow(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILInstruction Left
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public MediumLevelILInstruction Right
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
	}
}
