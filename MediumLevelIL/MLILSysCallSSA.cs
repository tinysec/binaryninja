using System;

namespace BinaryNinja
{
	public sealed class MLILSysCallSSA : MediumLevelILInstruction
	{
		internal MLILSysCallSSA(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILSSAVariable[] Output
		{
			get
			{
				MLILCallOutputSSA? instruction = this.GetOperandAsExpression(0) as MLILCallOutputSSA;

				if (null == instruction)
				{
					throw new Exception("must MediumLevelILCallOutputSSA");
				}

				return instruction.Destination;
			}
		}
		
		public ulong OutputDestMemory
		{
			get
			{
				MLILCallOutputSSA? instruction = this.GetOperandAsExpression(0) as MLILCallOutputSSA;

				if (null == instruction)
				{
					throw new Exception("must MediumLevelILCallOutputSSA");
				}

				return instruction.DestinationMemory;
			}
		}
		
		public MediumLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)1);
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
