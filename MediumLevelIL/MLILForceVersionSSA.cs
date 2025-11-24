namespace BinaryNinja
{
	public sealed class MLILForceVersionSSA : MediumLevelILInstruction
	{
		internal MLILForceVersionSSA(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILSSAVariable Destination
		{
			get
			{
				return this.GetOperandAsSSAVariable((OperandIndex)0,(OperandIndex)1);
			}
		}
		
		public MediumLevelILSSAVariable Source
		{
			get
			{
				return this.GetOperandAsSSAVariable((OperandIndex)2,(OperandIndex)3);
			}
		}
	}
}
