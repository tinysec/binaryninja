namespace BinaryNinja
{
	public sealed class LLILFlag : LowLevelILInstruction
	{
		internal LLILFlag(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		public Flag Source
		{
			get
			{
				return this.GetOperandAsFlag(0);
			}
		}
	}
}
