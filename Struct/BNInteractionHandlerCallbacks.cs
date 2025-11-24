using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNInteractionHandlerCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** showPlainTextReport
		/// </summary>
		public IntPtr showPlainTextReport;
		
		/// <summary>
		/// void** showMarkdownReport
		/// </summary>
		public IntPtr showMarkdownReport;
		
		/// <summary>
		/// void** showHTMLReport
		/// </summary>
		public IntPtr showHTMLReport;
		
		/// <summary>
		/// void** showGraphReport
		/// </summary>
		public IntPtr showGraphReport;
		
		/// <summary>
		/// void** showReportCollection
		/// </summary>
		public IntPtr showReportCollection;
		
		/// <summary>
		/// void** getTextLineInput
		/// </summary>
		public IntPtr getTextLineInput;
		
		/// <summary>
		/// void** getIntegerInput
		/// </summary>
		public IntPtr getIntegerInput;
		
		/// <summary>
		/// void** getAddressInput
		/// </summary>
		public IntPtr getAddressInput;
		
		/// <summary>
		/// void** getChoiceInput
		/// </summary>
		public IntPtr getChoiceInput;
		
		/// <summary>
		/// void** getLargeChoiceInput
		/// </summary>
		public IntPtr getLargeChoiceInput;
		
		/// <summary>
		/// void** getOpenFileNameInput
		/// </summary>
		public IntPtr getOpenFileNameInput;
		
		/// <summary>
		/// void** getSaveFileNameInput
		/// </summary>
		public IntPtr getSaveFileNameInput;
		
		/// <summary>
		/// void** getDirectoryNameInput
		/// </summary>
		public IntPtr getDirectoryNameInput;
		
		/// <summary>
		/// void** getCheckboxInput
		/// </summary>
		public IntPtr getCheckboxInput;
		
		/// <summary>
		/// void** getFormInput
		/// </summary>
		public IntPtr getFormInput;
		
		/// <summary>
		/// void** showMessageBox
		/// </summary>
		public IntPtr showMessageBox;
		
		/// <summary>
		/// void** openUrl
		/// </summary>
		public IntPtr openUrl;
		
		/// <summary>
		/// void** runProgressDialog
		/// </summary>
		public IntPtr runProgressDialog;
	}

    public class InteractionHandlerCallbacks 
    {
		public InteractionHandlerCallbacks() 
		{
		    
		}
    }
}