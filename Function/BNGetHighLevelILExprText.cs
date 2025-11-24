using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDisassemblyTextLine* BNGetHighLevelILExprText(BNHighLevelILFunction* func, uint64_t expr, bool asFullAst, uint64_t* count, BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetHighLevelILExprText"
        )]
		internal static extern IntPtr BNGetHighLevelILExprText(
			
			// BNHighLevelILFunction* func
		    IntPtr func  , 
			
			// uint64_t expr
			HighLevelILExpressionIndex expr  , 
			
			// bool asFullAst
		    bool asFullAst  , 
			
			// uint64_t* count
		    out ulong count  , 
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
		);
	}
}