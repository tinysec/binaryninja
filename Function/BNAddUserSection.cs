using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddUserSection(BNBinaryView* view, const char* name, uint64_t start, uint64_t length, BNSectionSemantics semantics, const char* type, uint64_t align, uint64_t entrySize, const char* linkedSection, const char* infoSection, uint64_t infoData)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNAddUserSection"
        )]
		internal static extern void BNAddUserSection(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// const char* name
		    string name  , 
			
			// uint64_t start
		    ulong start  , 
			
			// uint64_t length
		    ulong length  , 
			
			// BNSectionSemantics semantics
		    SectionSemantics semantics  , 
			
			// const char* type
		    string kind  , 
			
			// uint64_t align
		    ulong align  , 
			
			// uint64_t entrySize
		    ulong entrySize  , 
			
			// const char* linkedSection
		    string linkedSection  , 
			
			// const char* infoSection
		    string infoSection  , 
			
			// uint64_t infoData
		    ulong infoData  
		);
	}
}