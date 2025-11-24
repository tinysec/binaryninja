using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char** BNAddNamesForOuterStructureMembers(BNBinaryView* data, BNType* type, BNHighLevelILFunction* hlil, uint64_t varExpr, uint64_t* nameCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddNamesForOuterStructureMembers"
        )]
		internal static extern IntPtr BNAddNamesForOuterStructureMembers(
			
			// BNBinaryView* data
		    IntPtr data  , 
			
			// BNType* type
		    IntPtr type  , 
			
			// BNHighLevelILFunction* hlil
		    IntPtr hlil  , 
			
			// uint64_t varExpr
		    ulong varExpr  , 
			
			// uint64_t* nameCount
		    IntPtr nameCount  
		);
	}
}