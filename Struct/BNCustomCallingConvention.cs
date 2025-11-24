using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNCustomCallingConvention 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** freeObject
		/// </summary>
		public IntPtr freeObject;
		
		/// <summary>
		/// void** getCallerSavedRegisters
		/// </summary>
		public IntPtr getCallerSavedRegisters;
		
		/// <summary>
		/// void** getCalleeSavedRegisters
		/// </summary>
		public IntPtr getCalleeSavedRegisters;
		
		/// <summary>
		/// void** getIntegerArgumentRegisters
		/// </summary>
		public IntPtr getIntegerArgumentRegisters;
		
		/// <summary>
		/// void** getFloatArgumentRegisters
		/// </summary>
		public IntPtr getFloatArgumentRegisters;
		
		/// <summary>
		/// void** freeRegisterList
		/// </summary>
		public IntPtr freeRegisterList;
		
		/// <summary>
		/// void** areArgumentRegistersSharedIndex
		/// </summary>
		public IntPtr areArgumentRegistersSharedIndex;
		
		/// <summary>
		/// void** isStackReservedForArgumentRegisters
		/// </summary>
		public IntPtr isStackReservedForArgumentRegisters;
		
		/// <summary>
		/// void** isStackAdjustedOnReturn
		/// </summary>
		public IntPtr isStackAdjustedOnReturn;
		
		/// <summary>
		/// void** isEligibleForHeuristics
		/// </summary>
		public IntPtr isEligibleForHeuristics;
		
		/// <summary>
		/// void** getIntegerReturnValueRegister
		/// </summary>
		public IntPtr getIntegerReturnValueRegister;
		
		/// <summary>
		/// void** getHighIntegerReturnValueRegister
		/// </summary>
		public IntPtr getHighIntegerReturnValueRegister;
		
		/// <summary>
		/// void** getFloatReturnValueRegister
		/// </summary>
		public IntPtr getFloatReturnValueRegister;
		
		/// <summary>
		/// void** getGlobalPointerRegister
		/// </summary>
		public IntPtr getGlobalPointerRegister;
		
		/// <summary>
		/// void** getImplicitlyDefinedRegisters
		/// </summary>
		public IntPtr getImplicitlyDefinedRegisters;
		
		/// <summary>
		/// void** getIncomingRegisterValue
		/// </summary>
		public IntPtr getIncomingRegisterValue;
		
		/// <summary>
		/// void** getIncomingFlagValue
		/// </summary>
		public IntPtr getIncomingFlagValue;
		
		/// <summary>
		/// void** getIncomingVariableForParameterVariable
		/// </summary>
		public IntPtr getIncomingVariableForParameterVariable;
		
		/// <summary>
		/// void** getParameterVariableForIncomingVariable
		/// </summary>
		public IntPtr getParameterVariableForIncomingVariable;
		
		/// <summary>
		/// void** areArgumentRegistersUsedForVarArgs
		/// </summary>
		public IntPtr areArgumentRegistersUsedForVarArgs;
		
	}

    public class CustomCallingConvention 
    {
	    
		public CustomCallingConvention() 
		{
		    
		}
    }
}