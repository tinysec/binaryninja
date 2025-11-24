namespace BinaryNinja
{
	public sealed class HLILVariable : HighLevelILInstruction
	{
		internal HLILVariable(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILVariable Variable
		{
			get
			{
				return this.GetOperandAsVariable((OperandIndex)0);
			}
		}
	}
}
