namespace BinaryNinja
{
	public sealed class MLILImport : MediumLevelILInstruction
	{
		internal MLILImport(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}

		public ulong Constant
		{
			get
			{
				return this.RawOperands[0];
			}
		}
	}
}
