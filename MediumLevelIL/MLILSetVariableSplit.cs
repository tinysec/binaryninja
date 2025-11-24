namespace BinaryNinja
{
	public sealed class MLILSetVariableSplit : MediumLevelILInstruction
	{
		internal MLILSetVariableSplit(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILVariable High
		{
			get
			{
				return this.GetOperandAsVariable(0);
			}
		}
		
		public MediumLevelILVariable Low
		{
			get
			{
				return this.GetOperandAsVariable((OperandIndex)1);
			}
		}
	
		public MediumLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}

		public override MediumLevelILVariable[] VariablesWrite
		{
			get
			{
				return new MediumLevelILVariable[]
				{
					this.High ,
					this.Low
				};
			}
		}
	}
}
