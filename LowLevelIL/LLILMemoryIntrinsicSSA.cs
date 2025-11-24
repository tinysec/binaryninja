namespace BinaryNinja
{
	public sealed class LLILMemoryIntrinsicSSA : LowLevelILInstruction
	{
		internal LLILMemoryIntrinsicSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		
		public SSAFlagOrRegister[] Output
		{
			get
			{
				LLILMemoryIntrinsicOutputSSA? instruction = this.GetOperandAsExpression(0) as  LLILMemoryIntrinsicOutputSSA;
				
				return instruction!.Output;
			}
		}
		
		public ulong DestinationMemory
		{
			get
			{
				LLILMemoryIntrinsicOutputSSA? instruction = this.GetOperandAsExpression(0) as  LLILMemoryIntrinsicOutputSSA;
				
				return instruction!.DestinationMemory;
			}
		}

		public Intrinsic Intrinsic
		{
			get
			{
				return this.GetOperandAsIntrinsic((OperandIndex)1);
			}
		}
		
		public LLILCallParameter Parameter
		{
			get
			{
				LLILCallParameter? instruction = this.GetOperandAsExpression((OperandIndex)2) as LLILCallParameter;

				return instruction!;
			}
		}
		
		public LowLevelILInstruction[] Parameters
		{
			get
			{
				LLILCallParameter? instruction = this.GetOperandAsExpression((OperandIndex)2) as LLILCallParameter;

				return instruction!.Source;
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return this.RawOperands[3];
			}
		}
		
	}
}
