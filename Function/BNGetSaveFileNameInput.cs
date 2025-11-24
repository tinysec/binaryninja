using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
	{
		public static string? GetSaveFileNameInput(
			string prompt = "Choose a file:" , 
			string ext  = "Executables (*.exe *.dll *.sys);;All Files (*)",
			string defaultName = "foo.exe"
		)
		{
			bool ok = NativeMethods.BNGetSaveFileNameInput(
				out IntPtr result ,
				prompt ,
				ext,
				defaultName
			);

			if (!ok)
			{
				return null;
			}

			return UnsafeUtils.TakeUtf8String(result);
		}
	}
	
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNGetSaveFileNameInput(const char** result, const char* prompt, const char* ext, const char* defaultName)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetSaveFileNameInput"
        )]
		internal static extern bool BNGetSaveFileNameInput(
			
			// char** result
		    out IntPtr result  , 
			
			// const char* prompt
		    string prompt  , 
			
			// const char* ext
		    string ext  , 
			
			// const char* defaultName
		    string defaultName  
		);
	}
}