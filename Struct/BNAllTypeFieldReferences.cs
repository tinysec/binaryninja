using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNAllTypeFieldReferences 
	{
		/// <summary>
		/// BNTypeFieldReference* codeRefs
		/// </summary>
		internal IntPtr codeRefs;
		
		/// <summary>
		/// uint64_t codeRefCount
		/// </summary>
		internal ulong codeRefCount;
		
		/// <summary>
		/// uint64_t* dataRefsTo
		/// </summary>
		internal IntPtr dataRefsTo;
		
		/// <summary>
		/// uint64_t dataRefToCount
		/// </summary>
		internal ulong dataRefToCount;
		
		/// <summary>
		/// uint64_t* dataRefsFrom
		/// </summary>
		internal IntPtr dataRefsFrom;
		
		/// <summary>
		/// uint64_t dataRefFromCount
		/// </summary>
		internal ulong dataRefFromCount;
		
		/// <summary>
		/// BNTypeReferenceSource* typeRefs
		/// </summary>
		internal IntPtr typeRefs;
		
		/// <summary>
		/// uint64_t typeRefCount
		/// </summary>
		internal ulong typeRefCount;
	}

    public class AllTypeFieldReferences 
    {
		public TypeFieldReference[] CodeRefs { get; set; } = Array.Empty<TypeFieldReference>();
		
		public ulong[] DataRefsTo { get; set; } = Array.Empty<ulong>();
		
		public ulong[] DataRefsFrom { get; set; } = Array.Empty<ulong>();
		
		public TypeReferenceSource[] TypeRefs { get; set; } = Array.Empty<TypeReferenceSource>();
		
		public AllTypeFieldReferences() 
		{
		    
		}
    }
}