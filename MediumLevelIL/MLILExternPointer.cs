namespace BinaryNinja
{
	public sealed class MLILExternPointer : MediumLevelILInstruction
	{
		internal MLILExternPointer(
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
		
		public ulong Offset
		{
			get
			{
				return this.RawOperands[1];
			}
		}
	}
}
