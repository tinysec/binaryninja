using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNBinaryDataNotification 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** notificationBarrier
		/// </summary>
		public IntPtr notificationBarrier;
		
		/// <summary>
		/// void** dataWritten
		/// </summary>
		public IntPtr dataWritten;
		
		/// <summary>
		/// void** dataInserted
		/// </summary>
		public IntPtr dataInserted;
		
		/// <summary>
		/// void** dataRemoved
		/// </summary>
		public IntPtr dataRemoved;
		
		/// <summary>
		/// void** functionAdded
		/// </summary>
		public IntPtr functionAdded;
		
		/// <summary>
		/// void** functionRemoved
		/// </summary>
		public IntPtr functionRemoved;
		
		/// <summary>
		/// void** functionUpdated
		/// </summary>
		public IntPtr functionUpdated;
		
		/// <summary>
		/// void** functionUpdateRequested
		/// </summary>
		public IntPtr functionUpdateRequested;
		
		/// <summary>
		/// void** dataVariableAdded
		/// </summary>
		public IntPtr dataVariableAdded;
		
		/// <summary>
		/// void** dataVariableRemoved
		/// </summary>
		public IntPtr dataVariableRemoved;
		
		/// <summary>
		/// void** dataVariableUpdated
		/// </summary>
		public IntPtr dataVariableUpdated;
		
		/// <summary>
		/// void** dataMetadataUpdated
		/// </summary>
		public IntPtr dataMetadataUpdated;
		
		/// <summary>
		/// void** tagTypeUpdated
		/// </summary>
		public IntPtr tagTypeUpdated;
		
		/// <summary>
		/// void** tagAdded
		/// </summary>
		public IntPtr tagAdded;
		
		/// <summary>
		/// void** tagRemoved
		/// </summary>
		public IntPtr tagRemoved;
		
		/// <summary>
		/// void** tagUpdated
		/// </summary>
		public IntPtr tagUpdated;
		
		/// <summary>
		/// void** symbolAdded
		/// </summary>
		public IntPtr symbolAdded;
		
		/// <summary>
		/// void** symbolRemoved
		/// </summary>
		public IntPtr symbolRemoved;
		
		/// <summary>
		/// void** symbolUpdated
		/// </summary>
		public IntPtr symbolUpdated;
		
		/// <summary>
		/// void** stringFound
		/// </summary>
		public IntPtr stringFound;
		
		/// <summary>
		/// void** stringRemoved
		/// </summary>
		public IntPtr stringRemoved;
		
		/// <summary>
		/// void** typeDefined
		/// </summary>
		public IntPtr typeDefined;
		
		/// <summary>
		/// void** typeUndefined
		/// </summary>
		public IntPtr typeUndefined;
		
		/// <summary>
		/// void** typeReferenceChanged
		/// </summary>
		public IntPtr typeReferenceChanged;
		
		/// <summary>
		/// void** typeFieldReferenceChanged
		/// </summary>
		public IntPtr typeFieldReferenceChanged;
		
		/// <summary>
		/// void** segmentAdded
		/// </summary>
		public IntPtr segmentAdded;
		
		/// <summary>
		/// void** segmentRemoved
		/// </summary>
		public IntPtr segmentRemoved;
		
		/// <summary>
		/// void** segmentUpdated
		/// </summary>
		public IntPtr segmentUpdated;
		
		/// <summary>
		/// void** sectionAdded
		/// </summary>
		public IntPtr sectionAdded;
		
		/// <summary>
		/// void** sectionRemoved
		/// </summary>
		public IntPtr sectionRemoved;
		
		/// <summary>
		/// void** sectionUpdated
		/// </summary>
		public IntPtr sectionUpdated;
		
		/// <summary>
		/// void** componentNameUpdated
		/// </summary>
		public IntPtr componentNameUpdated;
		
		/// <summary>
		/// void** componentAdded
		/// </summary>
		public IntPtr componentAdded;
		
		/// <summary>
		/// void** componentMoved
		/// </summary>
		public IntPtr componentMoved;
		
		/// <summary>
		/// void** componentRemoved
		/// </summary>
		public IntPtr componentRemoved;
		
		/// <summary>
		/// void** componentFunctionAdded
		/// </summary>
		public IntPtr componentFunctionAdded;
		
		/// <summary>
		/// void** componentFunctionRemoved
		/// </summary>
		public IntPtr componentFunctionRemoved;
		
		/// <summary>
		/// void** componentDataVariableAdded
		/// </summary>
		public IntPtr componentDataVariableAdded;
		
		/// <summary>
		/// void** componentDataVariableRemoved
		/// </summary>
		public IntPtr componentDataVariableRemoved;
		
		/// <summary>
		/// void** externalLibraryAdded
		/// </summary>
		public IntPtr externalLibraryAdded;
		
		/// <summary>
		/// void** externalLibraryUpdated
		/// </summary>
		public IntPtr externalLibraryUpdated;
		
		/// <summary>
		/// void** externalLibraryRemoved
		/// </summary>
		public IntPtr externalLibraryRemoved;
		
		/// <summary>
		/// void** externalLocationAdded
		/// </summary>
		public IntPtr externalLocationAdded;
		
		/// <summary>
		/// void** externalLocationUpdated
		/// </summary>
		public IntPtr externalLocationUpdated;
		
		/// <summary>
		/// void** externalLocationRemoved
		/// </summary>
		public IntPtr externalLocationRemoved;
		
		/// <summary>
		/// void** typeArchiveAttached
		/// </summary>
		public IntPtr typeArchiveAttached;
		
		/// <summary>
		/// void** typeArchiveDetached
		/// </summary>
		public IntPtr typeArchiveDetached;
		
		/// <summary>
		/// void** typeArchiveConnected
		/// </summary>
		public IntPtr typeArchiveConnected;
		
		/// <summary>
		/// void** typeArchiveDisconnected
		/// </summary>
		public IntPtr typeArchiveDisconnected;
		
		/// <summary>
		/// void** undoEntryAdded
		/// </summary>
		public IntPtr undoEntryAdded;
		
		/// <summary>
		/// void** undoEntryTaken
		/// </summary>
		public IntPtr undoEntryTaken;
		
		/// <summary>
		/// void** redoEntryTaken
		/// </summary>
		public IntPtr redoEntryTaken;
		
		/// <summary>
		/// void** rebased
		/// </summary>
		public IntPtr rebased;
	}

    public class BinaryDataNotification 
    {
		public BinaryDataNotification() 
		{
		    
		}
    }
}