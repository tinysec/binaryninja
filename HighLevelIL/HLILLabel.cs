namespace BinaryNinja
{
	public sealed class HLILLabel : HighLevelILInstruction
	{
		internal HLILLabel(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILLabel Destination
		{
			get
			{
				return this.GetOperandAsLabel((OperandIndex)0);
			}
		}
	}
}
