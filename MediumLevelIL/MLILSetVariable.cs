namespace BinaryNinja
{
	public sealed class MLILSetVariable : MediumLevelILInstruction
	{
		internal MLILSetVariable(
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
		
		public MediumLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
	}
}
