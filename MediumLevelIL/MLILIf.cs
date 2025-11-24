using System;

namespace BinaryNinja
{
	public sealed class MLILIf : MediumLevelILInstruction
	{
		internal MLILIf(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILInstruction Condition
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public MediumLevelILInstructionIndex TrueBranch
		{
			get
			{
				return (MediumLevelILInstructionIndex)this.RawOperands[1];
			}
		}
		
		public MediumLevelILInstructionIndex FalseBranch
		{
			get
			{
				return (MediumLevelILInstructionIndex)this.RawOperands[2];
			}
		}
	}
}
