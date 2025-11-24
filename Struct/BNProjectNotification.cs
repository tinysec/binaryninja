using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNProjectNotification 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** beforeOpenProject
		/// </summary>
		public IntPtr beforeOpenProject;
		
		/// <summary>
		/// void** afterOpenProject
		/// </summary>
		public IntPtr afterOpenProject;
		
		/// <summary>
		/// void** beforeCloseProject
		/// </summary>
		public IntPtr beforeCloseProject;
		
		/// <summary>
		/// void** afterCloseProject
		/// </summary>
		public IntPtr afterCloseProject;
		
		/// <summary>
		/// void** beforeProjectMetadataWritten
		/// </summary>
		public IntPtr beforeProjectMetadataWritten;
		
		/// <summary>
		/// void** afterProjectMetadataWritten
		/// </summary>
		public IntPtr afterProjectMetadataWritten;
		
		/// <summary>
		/// void** beforeProjectFileCreated
		/// </summary>
		public IntPtr beforeProjectFileCreated;
		
		/// <summary>
		/// void** afterProjectFileCreated
		/// </summary>
		public IntPtr afterProjectFileCreated;
		
		/// <summary>
		/// void** beforeProjectFileUpdated
		/// </summary>
		public IntPtr beforeProjectFileUpdated;
		
		/// <summary>
		/// void** afterProjectFileUpdated
		/// </summary>
		public IntPtr afterProjectFileUpdated;
		
		/// <summary>
		/// void** beforeProjectFileDeleted
		/// </summary>
		public IntPtr beforeProjectFileDeleted;
		
		/// <summary>
		/// void** afterProjectFileDeleted
		/// </summary>
		public IntPtr afterProjectFileDeleted;
		
		/// <summary>
		/// void** beforeProjectFolderCreated
		/// </summary>
		public IntPtr beforeProjectFolderCreated;
		
		/// <summary>
		/// void** afterProjectFolderCreated
		/// </summary>
		public IntPtr afterProjectFolderCreated;
		
		/// <summary>
		/// void** beforeProjectFolderUpdated
		/// </summary>
		public IntPtr beforeProjectFolderUpdated;
		
		/// <summary>
		/// void** afterProjectFolderUpdated
		/// </summary>
		public IntPtr afterProjectFolderUpdated;
		
		/// <summary>
		/// void** beforeProjectFolderDeleted
		/// </summary>
		public IntPtr beforeProjectFolderDeleted;
		
		/// <summary>
		/// void** afterProjectFolderDeleted
		/// </summary>
		public IntPtr afterProjectFolderDeleted;
	}

    public class ProjectNotification 
    {
		public ProjectNotification() 
		{
		    
		}
    }
}