using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

namespace BinaryNinja
{
	public sealed class Instruction :
		IEquatable<Instruction>, 
		IComparable<Instruction>
	{
		public Function? Function { get; }
		
		public ulong Address { get; }
		
		public byte[] Data { get; } = Array.Empty<byte>();
		
		public InstructionInfo Info { get; }
		
		public InstructionTextToken[] Tokens { get; } = Array.Empty<InstructionTextToken>();
		
		public Instruction(
			Function? function,
			ulong address,
			byte[] data,
			InstructionInfo info ,
			InstructionTextToken[] tokens 
		)
		{
			this.Function = function;
			this.Address = address;
			this.Data = data;
			this.Info = info;
			this.Tokens = tokens;
		}

		public ulong Length
		{
			get
			{
				return this.Info.Length;
			}
		}

		public string Text
		{
			get
			{
				StringBuilder builder = new StringBuilder();

				foreach (InstructionTextToken token in this.Tokens)
				{
					builder.Append(token.Text);
				}
				
				return builder.ToString();
			}
		}
		
		public override bool Equals(object? other)
		{
			return this.Equals(other as Instruction);
		}

		public bool Equals(Instruction? other)
		{
			if (other is null)
			{
				return false;
			}

			if (ReferenceEquals(this , other))
			{
				return true;
			}

			if (this.Address != other.Address)
			{
				return false;
			}
			
			return true;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2218:OverrideGetHashCodeOnOverridingEquals")]
		public override int GetHashCode()
		{
			return HashCode.Combine<ulong>( 
				this.Address
			);
		}

		public static bool operator ==(Instruction? left, Instruction? right)
		{
			if (left is null)
			{
				return right is null;
			}
			
			return left.Equals(right);
		}

		public static bool operator !=(Instruction? left, Instruction? right)
		{
			return !(left == right);
		}

		public int CompareTo(Instruction? other)
		{
			if (other is null)
			{
				return 1;
			}
			
			int result = this.Address.CompareTo(other.Address);
			
			return result;
		}

		public HighlightColor? Highlight
		{
			get
			{
				return this.Function?.GetInstructionHighlight(this.Address);
			}

			set
			{
				if (null != value)
				{
					this.Function?.SetUserInstructionHighlight(this.Address, value!);
				}
			}
		}
		
		public LowLevelILInstruction[] LowLevelILInstructions
		{
			get
			{
				if (null == this.Function)
				{
					return Array.Empty<LowLevelILInstruction>();
				}
				
				return this.Function.LowLevelIL.GetInstructionsAt(
					this.Address
				);
			}
		}
		
		public MediumLevelILInstruction[] MediumLevelILExpressions
		{
			get
			{
				if (null == this.Function)
				{
					return Array.Empty<MediumLevelILInstruction>();
				}

				List<MediumLevelILInstruction> mediumExprs = new List<MediumLevelILInstruction>();
				
				foreach (LowLevelILInstruction lowInstr in this.LowLevelILInstructions)
				{
					foreach (MediumLevelILInstruction mediumExpr in lowInstr.MediumLevelILExpressions)
					{
						if (!mediumExprs.Contains(mediumExpr))
						{
							mediumExprs.Add(mediumExpr);
						}
					}
				}

				return mediumExprs.ToArray();
			}
		}
		
		public MediumLevelILInstruction[] MediumLevelILInstructions
		{
			get
			{
				if (null == this.Function)
				{
					return Array.Empty<MediumLevelILInstruction>();
				}

				List<MediumLevelILInstruction> mediumInstrs = new List<MediumLevelILInstruction>();
				
				foreach (LowLevelILInstruction lowInstr in this.LowLevelILInstructions)
				{
					foreach (MediumLevelILInstruction mediumInstr in lowInstr.MediumLevelILInstructions)
					{
						if (!mediumInstrs.Contains(mediumInstr))
						{
							mediumInstrs.Add(mediumInstr);
						}
					}
				}

				return mediumInstrs.ToArray();
			}
		}
		
		public HighLevelILInstruction[] HighLevelILExpressions
		{
			get
			{
				if (null == this.Function)
				{
					return Array.Empty<HighLevelILInstruction>();
				}

				List<HighLevelILInstruction> highExprs = new List<HighLevelILInstruction>();
				
				foreach (LowLevelILInstruction lowInstr in this.LowLevelILInstructions)
				{
					foreach (HighLevelILInstruction highExpr in lowInstr.HighLevelILExpressions)
					{
						if (!highExprs.Contains(highExpr))
						{
							highExprs.Add(highExpr);
						}
					}
				}

				return highExprs.ToArray();
			}
		}
		
		public HighLevelILInstruction[] HighLevelILInstructions
		{
			get
			{
				if (null == this.Function)
				{
					return Array.Empty<HighLevelILInstruction>();
				}

				List<HighLevelILInstruction> highInstrs = new List<HighLevelILInstruction>();
				
				foreach (LowLevelILInstruction lowInstr in this.LowLevelILInstructions)
				{
					foreach (HighLevelILInstruction highInstr in lowInstr.HighLevelILInstructions)
					{
						if (!highInstrs.Contains(highInstr))
						{
							highInstrs.Add(highInstr);
						}
					}
				}

				return highInstrs.ToArray();
			}
		}

		public DisassemblyTextLine[] GetLanguageRepresentationExpressionLines(
			bool asFullAst = false ,
			OperatorPrecedence precedence = OperatorPrecedence.TopLevelOperatorPrecedence ,
			bool statement = false ,
			DisassemblySettings? settings = null ,
			string language = "Pseudo C"
		)
		{
			List<DisassemblyTextLine> pseudoLines = new List<DisassemblyTextLine>();

			foreach (HighLevelILInstruction highExpr in this.HighLevelILExpressions)
			{
				DisassemblyTextLine[] lines = highExpr.GetLanguageRepresentationExpressionLines(
					asFullAst ,
					precedence ,
					statement ,
					settings ,
					language
				);

				foreach (DisassemblyTextLine line in lines)
				{
					if (!pseudoLines.Contains(line))
					{
						pseudoLines.Add(line);
					}
				}
			}

			return pseudoLines.ToArray();
		}
		
		public DisassemblyTextLine[] PseudoCExpressionLines
		{
			get
			{
				return this.GetLanguageRepresentationExpressionLines();
			}
		}

		public string PseudoCExpressionText
		{
			get
			{
				StringBuilder builder = new StringBuilder();

				for (int i = 0; i < this.PseudoCExpressionLines.Length; i++)
				{
					if (i == ( this.PseudoCExpressionLines.Length - 1) )
					{
						builder.Append(this.PseudoCExpressionLines[i].ToString());
					}
					else
					{
						builder.AppendLine(this.PseudoCExpressionLines[i].ToString());
					}
				}
				
				return builder.ToString();
			}
		}
		
		public DisassemblyTextLine[] GetLanguageRepresentationLinearLines(
			bool asFullAst = false,
			DisassemblySettings? settings = null ,
			string language = "Pseudo C" 
		)
		{
			List<DisassemblyTextLine> pseudoLines = new List<DisassemblyTextLine>();

			foreach (HighLevelILInstruction highInstr in this.HighLevelILInstructions)
			{
				DisassemblyTextLine[] lines = highInstr.GetLanguageRepresentationLinearLines(
					asFullAst,
					settings ,
					language
				);

				foreach (DisassemblyTextLine line in lines)
				{
					if (!pseudoLines.Contains(line))
					{
						pseudoLines.Add(line);
					}
				}
			}

			return pseudoLines.ToArray();
		}
		
		public DisassemblyTextLine[] PseudoCLinearLines
		{
			get
			{
				return this.GetLanguageRepresentationLinearLines();
			}
		}

		public string PseudoCLinearText
		{
			get
			{
				StringBuilder builder = new StringBuilder();

				for (int i = 0; i < this.PseudoCLinearLines.Length; i++)
				{
					if (i == ( this.PseudoCLinearLines.Length - 1) )
					{
						builder.Append(this.PseudoCLinearLines[i] .ToString());
					}
					else
					{
						builder.AppendLine(this.PseudoCLinearLines[i].ToString());
					}
				}
				
				return builder.ToString();
			}
		}
	}
}
