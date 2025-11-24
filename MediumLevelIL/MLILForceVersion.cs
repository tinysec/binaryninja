namespace BinaryNinja
{
	public sealed class MLILForceVersion : MediumLevelILInstruction
	{
		internal MLILForceVersion(
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
		
		public MediumLevelILVariable Source
		{
			get
			{
				return this.GetOperandAsVariable((OperandIndex)1);
			}
		}
	}
}
