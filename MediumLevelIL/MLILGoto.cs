namespace BinaryNinja
{
	public sealed class MLILGoto : MediumLevelILInstruction
	{
		internal MLILGoto(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILInstructionIndex Destination
		{
			get
			{
				return (MediumLevelILInstructionIndex)( this.RawOperands[0] );
			}
		}
	}
}
