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
			DisassemblySettings? settings = null ,
			bool asFullAst = false ,
			OperatorPrecedence precedence = OperatorPrecedence.TopLevelOperatorPrecedence ,
			bool statement = false ,
			string language = "Pseudo C"
		)
		{
			List<DisassemblyTextLine> pseudoLines = new List<DisassemblyTextLine>();

			foreach (HighLevelILInstruction highExpr in this.HighLevelILExpressions)
			{
				DisassemblyTextLine[] lines = highExpr.GetLanguageRepresentationExpressionLines(
					settings ,
					asFullAst ,
					precedence ,
					statement ,
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
	}


	public static class InstructionTest
	{
		public static void Test()
		{
			NativeLibrary.SetDllImportResolver(
				typeof(BinaryNinja.Core).Assembly,
				new LibraryResolver().ResolveDllImport
			);
			
			BinaryNinja.Core.InitPlugins(true);

			BinaryView? view = BinaryView.LoadFile("/data/afd.sys.bndb");

			if (null == view)
			{
				throw new Exception("load file fail");
			}

			Function? function = view.GetFunctionByRawName("_tlgCreate1Sz_char");

			if (null == function)
			{
				throw new Exception("not found function");
			}

			BasicBlock basicBlock = function.BasicBlocks[0];
			
			foreach (Instruction instruction in basicBlock.Instructions)
			{
				Console.WriteLine(instruction.Text);
			}
			
			BinaryNinja.Core.Shutdown();

		}
	}
}
