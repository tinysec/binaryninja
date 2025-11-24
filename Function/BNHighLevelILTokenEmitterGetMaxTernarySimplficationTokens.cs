using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNHighLevelILTokenEmitterGetMaxTernarySimplficationTokens(BNHighLevelILTokenEmitter* emitter)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNHighLevelILTokenEmitterGetMaxTernarySimplficationTokens"
        )]
		internal static extern ulong BNHighLevelILTokenEmitterGetMaxTernarySimplficationTokens(
			
			// BNHighLevelILTokenEmitter* emitter
		    IntPtr emitter  
			
		);
	}
}