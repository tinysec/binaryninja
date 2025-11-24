using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSymbolDisplayResult BNGetDisassemblyTextRendererSymbolTokensStatic(uint64_t addr, uint64_t size, uint64_t operand, BNBinaryView* data, uint64_t maxSymbolWidth, BNFunction* func, uint8_t confidence, BNSymbolDisplayType symbolDisplay, BNOperatorPrecedence precedence, uint64_t instrAddr, uint64_t exprIndex, BNInstructionTextToken** result, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDisassemblyTextRendererSymbolTokensStatic"
        )]
		internal static extern SymbolDisplayResult BNGetDisassemblyTextRendererSymbolTokensStatic(
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint64_t size
		    ulong size  , 
			
			// uint64_t operand
		    ulong operand  , 
			
			// BNBinaryView* data
		    IntPtr data  , 
			
			// uint64_t maxSymbolWidth
		    ulong maxSymbolWidth  , 
			
			// BNFunction* func
		    IntPtr func  , 
			
			// uint8_t confidence
		    byte confidence  , 
			
			// BNSymbolDisplayType symbolDisplay
		    SymbolDisplayType symbolDisplay  , 
			
			// BNOperatorPrecedence precedence
		    OperatorPrecedence precedence  , 
			
			// uint64_t instrAddr
		    ulong instrAddr  , 
			
			// uint64_t exprIndex
		    ulong exprIndex  , 
			
			// BNInstructionTextToken** result
		    IntPtr result  , 
			
			// uint64_t* count
		    IntPtr count  
			
		);
	}
}