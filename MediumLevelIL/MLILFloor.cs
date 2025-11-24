namespace BinaryNinja
{
	public sealed class MLILFloor : MediumLevelILInstruction
	{
		internal MLILFloor(
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
