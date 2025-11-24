namespace BinaryNinja
{
	public sealed class HLILForceVersion : HighLevelILInstruction
	{
		internal HLILForceVersion(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILVariable Destination
		{
			get
			{
				return this.GetOperandAsVariable(0);
			}
		}
		
		public HighLevelILVariable Source
		{
			get
			{
				return this.GetOperandAsVariable((OperandIndex)1);
			}
		}
	}
}
