using System;
using System.Reflection.Emit;

namespace BinaryNinja
{
	public sealed class Instruction
	{
		public byte[] Data { get; } = Array.Empty<byte>();
		
		public InstructionInfo Info { get; }
		
		public InstructionTextToken[] Tokens { get; } = Array.Empty<InstructionTextToken>();
		
		public Instruction(
			byte[] data,
			InstructionInfo info ,
			InstructionTextToken[] tokens 
		)
		{
			this.Data = data;
			this.Info = info;
			this.Tokens = tokens;
		}
	}
}
