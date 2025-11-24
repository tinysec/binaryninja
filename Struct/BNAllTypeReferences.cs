using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNAllTypeReferences 
	{
		/// <summary>
		/// BNReferenceSource* codeRefs
		/// </summary>
		public IntPtr codeRefs;
		
		/// <summary>
		/// uint64_t codeRefCount
		/// </summary>
		public ulong codeRefCount;
		
		/// <summary>
		/// uint64_t* dataRefs
		/// </summary>
		public IntPtr dataRefs;
		
		/// <summary>
		/// uint64_t dataRefCount
		/// </summary>
		public ulong dataRefCount;
		
		/// <summary>
		/// BNTypeReferenceSource* typeRefs
		/// </summary>
		public IntPtr typeRefs;
		
		/// <summary>
		/// uint64_t typeRefCount
		/// </summary>
		public ulong typeRefCount;
	}

    public class AllTypeReferences 
    {
		public ReferenceSource[] CodeRefs { get; set; } = Array.Empty<ReferenceSource>();
		
		public ulong[] DataRefs { get; set; } = Array.Empty<ulong>();
		
		public TypeReferenceSource[] TypeRefs { get; set; } = Array.Empty<TypeReferenceSource>();
		
		public AllTypeReferences() 
		{
		    
		}
    }
}