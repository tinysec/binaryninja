namespace BinaryNinja
{
	public sealed class MLILVariableField : MediumLevelILInstruction
	{
		internal MLILVariableField(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILVariable Source
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
				return (ulong)this.RawOperands[1];
			}
		}
	}
}
