namespace BinaryNinja
{
	public sealed class MLILSetVariableField : MediumLevelILInstruction
	{
		internal MLILSetVariableField(
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
		
		public ulong Offset
		{
			get
			{
				return this.RawOperands[1];
			}
		}
		
		public MediumLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
	}
}
