using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNCustomArchitecture 
	{
		/// <summary>
		/// void (*init)(void* context, BNArchitecture* obj);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate void InitDelegate(
			IntPtr ctxt,
			IntPtr arch
		);
		
		/// <summary>
		/// BNEndianness (*getEndianness)(void* ctxt);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate Endianness GetEndiannessDelegate(
			IntPtr ctxt
		);
		
		/// <summary>
		/// size_t (*getAddressSize)(void* ctxt);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate ulong GetAddressSizeDelegate(
			IntPtr ctxt
		);
		
		/// <summary>
		/// size_t (*getDefaultIntegerSize)(void* ctxt);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate ulong GetDefaultIntegerSizeDelegate(
			IntPtr ctxt
		);
		
		/// <summary>
		/// size_t (*getInstructionAlignment)(void* ctxt);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate ulong GetInstructionAlignmentDelegate(
			IntPtr ctxt
		);
		
		/// <summary>
		/// size_t (*getMaxInstructionLength)(void* ctxt);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate ulong GetMaxInstructionLengthDelegate(
			IntPtr ctxt
		);
		
		/// <summary>
		/// size_t (*getOpcodeDisplayLength)(void* ctxt);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate ulong GetOpcodeDisplayLengthDelegate(
			IntPtr ctxt
		);
		
		/// <summary>
		/// BNArchitecture* (*getAssociatedArchitectureByAddress)(void* ctxt, uint64_t* addr);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetAssociatedArchitectureByAddressDelegate(
			IntPtr ctxtm,
			IntPtr address
		);
		
		/// <summary>
		/// bool (*getInstructionInfo)(void* ctxt, const uint8_t* data, uint64_t addr, size_t maxLen, BNInstructionInfo* result);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool GetInstructionInfoDelegate(
			IntPtr ctxt,
			IntPtr data,
			ulong address,
			ulong maxLen,
			IntPtr result
		);
		
		/// <summary>
		/// bool (*getInstructionText)(void* ctxt, const uint8_t* data, uint64_t addr, size_t* len,BNInstructionTextToken** result, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool GetInstructionTextDelegate(
			IntPtr ctxt,
			IntPtr data,
			ulong address,
			IntPtr length,
			IntPtr result,
			IntPtr count
		);
		
		/// <summary>
		/// void (*freeInstructionText)(BNInstructionTextToken* tokens, size_t count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate void FreeInstructionTextDelegate(
			IntPtr tokens,
			ulong count
		);
		
		/// <summary>
		/// bool (*getInstructionLowLevelIL)(void* ctxt, const uint8_t* data, uint64_t addr, size_t* len, BNLowLevelILFunction* il);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool GetInstructionLowLevelILDelegate(
			IntPtr ctxt,
			IntPtr data,
			ulong address,
			IntPtr length,
			IntPtr il
		);
		
		/// <summary>
		/// char* (*getRegisterName)(void* ctxt, uint32_t reg);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetRegisterNameDelegate(
			IntPtr ctxt,
			uint reg
		);
		
		/// <summary>
		/// char* (*getFlagName)(void* ctxt, uint32_t flag);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr getFlagNameDelegate(
			IntPtr ctxt,
			uint flag
		);
		
		/// <summary>
		/// char* (*getFlagWriteTypeName)(void* ctxt, uint32_t flags);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetFlagWriteTypeNameDelegate(
			IntPtr ctxt,
			uint flags
		);
		
		/// <summary>
		/// char* (*getSemanticFlagClassName)(void* ctxt, uint32_t semClass);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetSemanticFlagClassNameDelegate(
			IntPtr ctxt,
			uint semClass
		);
		
		/// <summary>
		/// char* (*getSemanticFlagGroupName)(void* ctxt, uint32_t semGroup);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetSemanticFlagGroupNameDelegate(
			IntPtr ctxt,
			uint  semGroup
		);
		
		/// <summary>
		/// uint32_t* (*getFullWidthRegisters)(void* ctxt, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetFullWidthRegistersDelegate(
			IntPtr ctxt,
			IntPtr count
		);
		
		/// <summary>
		/// uint32_t* (*getAllRegisters)(void* ctxt, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetAllRegistersDelegate(
			IntPtr ctxt,
			IntPtr count
		);
		
		/// <summary>
		/// uint32_t* (*getAllFlags)(void* ctxt, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetAllFlagsDelegate(
			IntPtr ctxt,
			IntPtr count
		);
		
		/// <summary>
		/// uint32_t* (*getAllFlagWriteTypes)(void* ctxt, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetAllFlagWriteTypesDelegate(
			IntPtr ctxt,
			IntPtr count
		);
		
		/// <summary>
		/// uint32_t* (*getAllSemanticFlagClasses)(void* ctxt, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetAllSemanticFlagClassesDelegate(
			IntPtr ctxt,
			IntPtr count
		);
		
		/// <summary>
		/// uint32_t* (*getAllSemanticFlagGroups)(void* ctxt, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetAllSemanticFlagGroupsDelegate(
			IntPtr ctxt,
			IntPtr count
		);
		
		/// <summary>
		/// BNFlagRole (*getFlagRole)(void* ctxt, uint32_t flag, uint32_t semClass);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate FlagRole GetFlagRoleDelegate(
			IntPtr ctxt,
			uint flag,
			uint semClass
		);
		
		/// <summary>
		/// uint32_t* (*getFlagsRequiredForFlagCondition)(void* ctxt, BNLowLevelILFlagCondition cond, uint32_t semClass, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetFlagsRequiredForFlagConditionDelegate(
			IntPtr ctxt,
			LowLevelILFlagCondition cond,
			uint semClass,
			IntPtr count
		);
		
		/// <summary>
		/// uint32_t* (*getFlagsRequiredForSemanticFlagGroup)(void* ctxt, uint32_t semGroup, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetFlagsRequiredForSemanticFlagGroupDelegate(
			IntPtr ctxt,
			uint semGroup,
			IntPtr count
		);
		
		/// <summary>
		/// BNFlagConditionForSemanticClass* (*getFlagConditionsForSemanticFlagGroup)(void* ctxt, uint32_t semGroup, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetFlagConditionsForSemanticFlagGroupDelegate(
			IntPtr ctxt,
			uint semGroup,
			IntPtr count
		);
		
		/// <summary>
		/// void (*freeFlagConditionsForSemanticFlagGroup)(void* ctxt, BNFlagConditionForSemanticClass* conditions);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate void FreeFlagConditionsForSemanticFlagGroupDelegate(
			IntPtr ctxt,
			IntPtr conditions
		);
		
		/// <summary>
		/// uint32_t* (*getFlagsWrittenByFlagWriteType)(void* ctxt, uint32_t writeType, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetFlagsWrittenByFlagWriteTypeDelegate(
			IntPtr ctxt,
			uint writeType,
			IntPtr count
		);
		
		/// <summary>
		/// uint32_t (*getSemanticClassForFlagWriteType)(void* ctxt, uint32_t writeType);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate uint GetSemanticClassForFlagWriteTypeDelegate(
			IntPtr ctxt,
			uint writeType
		);
		
		/// <summary>
		/// size_t (*getFlagWriteLowLevelIL)(void* ctxt, BNLowLevelILOperation op, size_t size, uint32_t flagWriteType,uint32_t flag, BNRegisterOrConstant* operands, size_t operandCount, BNLowLevelILFunction* il);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate ulong GetFlagWriteLowLevelILDelegate(
			IntPtr ctxt,
			LowLevelILOperation op,
			ulong size,
			uint flagWriteType,
			uint flag,
			IntPtr operands,
			ulong operandCount,
			IntPtr il
		);
		
		/// <summary>
		/// size_t (*getFlagConditionLowLevelIL)(void* ctxt, BNLowLevelILFlagCondition cond, uint32_t semClass, BNLowLevelILFunction* il);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate ulong GetFlagConditionLowLevelILDelegate(
			IntPtr ctxt,
			LowLevelILFlagCondition cond,
			uint semClass,
			IntPtr il
		);
		
		/// <summary>
		/// size_t (*getSemanticFlagGroupLowLevelIL)(void* ctxt, uint32_t semGroup, BNLowLevelILFunction* il);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate ulong GetSemanticFlagGroupLowLevelILDelegate(
			IntPtr ctxt,
			uint semGroup,
			IntPtr il
		);
		
		/// <summary>
		/// void (*freeRegisterList)(void* ctxt, uint32_t* regs);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate void FreeRegisterListDelegate(
			IntPtr ctxt,
			IntPtr regs
		);
		
		/// <summary>
		/// void (*getRegisterInfo)(void* ctxt, uint32_t reg, BNRegisterInfo* result);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate void GetRegisterInfoDelegate(
			IntPtr ctxt ,
			uint reg,
			IntPtr result
		);
		
		/// <summary>
		/// uint32_t (*getStackPointerRegister)(void* ctxt);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate uint GetStackPointerRegisterDelegate(
			IntPtr ctxt
		);
		
		/// <summary>
		/// uint32_t (*getLinkRegister)(void* ctxt);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate uint GetLinkRegisterDelegate(
			IntPtr ctxt
		);
		
		/// <summary>
		/// uint32_t* (*getGlobalRegisters)(void* ctxt, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetGlobalRegistersDelegate(
			IntPtr ctxt ,
			IntPtr count
		);
		
		/// <summary>
		/// uint32_t* (*getSystemRegisters)(void* ctxt, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetSystemRegistersDelegate(
			IntPtr ctxt ,
			IntPtr count
		);
		
		/// <summary>
		/// char* (*getRegisterStackName)(void* ctxt, uint32_t regStack);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetRegisterStackNameDelegate(
			IntPtr ctxt ,
			uint regStack
		);
		
		/// <summary>
		/// uint32_t* (*getAllRegisterStacks)(void* ctxt, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate uint GetAllRegisterStacksDelegate(
			IntPtr ctxt ,
			IntPtr count
		);
		
		/// <summary>
		/// void (*getRegisterStackInfo)(void* ctxt, uint32_t regStack, BNRegisterStackInfo* result);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate void GetRegisterStackInfoDelegate(
			IntPtr ctxt ,
			uint regStack,
			IntPtr result
		);
		
		/// <summary>
		/// BNIntrinsicClass (*getIntrinsicClass)(void* ctxt, uint32_t intrinsic);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntrinsicClass GetIntrinsicClassDelegate(
			IntPtr ctxt ,
			uint intrinsic
		);
		
		/// <summary>
		/// char* (*getIntrinsicName)(void* ctxt, uint32_t intrinsic);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetIntrinsicNameDelegate(
			IntPtr ctxt ,
			uint intrinsic
		);
		
		/// <summary>
		/// uint32_t* (*getAllIntrinsics)(void* ctxt, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetAllIntrinsicsDelegate(
			IntPtr ctxt ,
			IntPtr count
		);
		
		/// <summary>
		/// BNNameAndType* (*getIntrinsicInputs)(void* ctxt, uint32_t intrinsic, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetIntrinsicInputsDelegate(
			IntPtr ctxt ,
			uint intrinsic,
			IntPtr count
		);
		
		/// <summary>
		/// void (*freeNameAndTypeList)(void* ctxt, BNNameAndType* nt, size_t count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate void FreeNameAndTypeListDelegate(
			IntPtr ctxt ,
			IntPtr nt,
			ulong count
		);
		
		/// <summary>
		/// BNTypeWithConfidence* (*getIntrinsicOutputs)(void* ctxt, uint32_t intrinsic, size_t* count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetIntrinsicOutputsDelegate(
			IntPtr ctxt ,
			uint intrinsic,
			IntPtr count
		);
		
		/// <summary>
		/// void (*freeTypeList)(void* ctxt, BNTypeWithConfidence* types, size_t count);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate void FreeTypeListDelegate(
			IntPtr ctxt ,
			IntPtr types,
			ulong count
		);
		
		/// <summary>
		/// bool (*canAssemble)(void* ctxt);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool CanAssembleDelegate(
			IntPtr ctxt
		);
		
		/// <summary>
		/// bool (*assemble)(void* ctxt, const char* code, uint64_t addr, BNDataBuffer* result, char** errors);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool AssembleDelegate(
			IntPtr ctxt ,
			IntPtr code,
			ulong address,
			IntPtr result,
			IntPtr errors
		);
		
		/// <summary>
		/// bool (*isNeverBranchPatchAvailable)(void* ctxt, const uint8_t* data, uint64_t addr, size_t len);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool IsNeverBranchPatchAvailableDelegate(
			IntPtr ctxt ,
			IntPtr data,
			ulong address,
			ulong length
		);
		
		/// <summary>
		/// bool (*isAlwaysBranchPatchAvailable)(void* ctxt, const uint8_t* data, uint64_t addr, size_t len);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool IsAlwaysBranchPatchAvailableDelegate(
			IntPtr ctxt ,
			IntPtr data,
			ulong address,
			ulong length
		);
		
		/// <summary>
		/// bool (*isInvertBranchPatchAvailable)(void* ctxt, const uint8_t* data, uint64_t addr, size_t len);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool IsInvertBranchPatchAvailableDelegate(
			IntPtr ctxt ,
			IntPtr data,
			ulong address,
			ulong length
		);
		
		/// <summary>
		/// bool (*isSkipAndReturnZeroPatchAvailable)(void* ctxt, const uint8_t* data, uint64_t addr, size_t len);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool IsSkipAndReturnZeroPatchAvailableDelegate(
			IntPtr ctxt ,
			IntPtr data,
			ulong address,
			ulong length
		);
		
		/// <summary>
		/// bool (*isSkipAndReturnValuePatchAvailable)(void* ctxt, const uint8_t* data, uint64_t addr, size_t len);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool IsSkipAndReturnValuePatchAvailableDelegate(
			IntPtr ctxt ,
			IntPtr data,
			ulong address,
			ulong length
		);
		
		/// <summary>
		/// bool (*convertToNop)(void* ctxt, uint8_t* data, uint64_t addr, size_t len);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool ConvertToNopDelegate(
			IntPtr ctxt,
			IntPtr data,
			ulong address,
			ulong length
		);
		
		/// <summary>
		/// bool (*alwaysBranch)(void* ctxt, uint8_t* data, uint64_t addr, size_t len);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool AlwaysBranchDelegate(
			IntPtr ctxt,
			IntPtr data,
			ulong address,
			ulong length
		);
		
		/// <summary>
		/// bool (*invertBranch)(void* ctxt, uint8_t* data, uint64_t addr, size_t len);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool InvertBranchDelegate(
			IntPtr ctxt,
			IntPtr data,
			ulong address,
			ulong length
		);
		
		/// <summary>
		/// bool (*skipAndReturnValue)(void* ctxt, uint8_t* data, uint64_t addr, size_t len, uint64_t value);
		/// </summary>
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool SkipAndReturnValueDelegate(
			IntPtr ctxt,
			IntPtr data,
			ulong address,
			ulong length,
			ulong value
		);
		
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void* init
		/// </summary>
		public IntPtr init;
		
		/// <summary>
		/// void* getEndianness
		/// </summary>
		public IntPtr getEndianness;
		
		/// <summary>
		/// void* getAddressSize
		/// </summary>
		public IntPtr getAddressSize;
		
		/// <summary>
		/// void* getDefaultIntegerSize
		/// </summary>
		public IntPtr getDefaultIntegerSize;
		
		/// <summary>
		/// void* getInstructionAlignment
		/// </summary>
		public IntPtr getInstructionAlignment;
		
		/// <summary>
		/// void* getMaxInstructionLength
		/// </summary>
		public IntPtr getMaxInstructionLength;
		
		/// <summary>
		/// void* getOpcodeDisplayLength
		/// </summary>
		public IntPtr getOpcodeDisplayLength;
		
		/// <summary>
		/// void* getAssociatedArchitectureByAddress
		/// </summary>
		public IntPtr getAssociatedArchitectureByAddress;
		
		/// <summary>
		/// void* getInstructionInfo
		/// </summary>
		public IntPtr getInstructionInfo;
		
		/// <summary>
		/// void* getInstructionText
		/// </summary>
		public IntPtr getInstructionText;
		
		/// <summary>
		/// void* freeInstructionText
		/// </summary>
		public IntPtr freeInstructionText;
		
		/// <summary>
		/// void* getInstructionLowLevelIL
		/// </summary>
		public IntPtr getInstructionLowLevelIL;
		
		/// <summary>
		/// void* analyzeBasicBlocks
		/// </summary>
		public IntPtr analyzeBasicBlocks;
		
		/// <summary>
		/// void* getRegisterName
		/// </summary>
		public IntPtr getRegisterName;
		
		/// <summary>
		/// void* getFlagName
		/// </summary>
		public IntPtr getFlagName;
		
		/// <summary>
		/// void* getFlagWriteTypeName
		/// </summary>
		public IntPtr getFlagWriteTypeName;
		
		/// <summary>
		/// void* getSemanticFlagClassName
		/// </summary>
		public IntPtr getSemanticFlagClassName;
		
		/// <summary>
		/// void* getSemanticFlagGroupName
		/// </summary>
		public IntPtr getSemanticFlagGroupName;
		
		/// <summary>
		/// void* getFullWidthRegisters
		/// </summary>
		public IntPtr getFullWidthRegisters;
		
		/// <summary>
		/// void* getAllRegisters
		/// </summary>
		public IntPtr getAllRegisters;
		
		/// <summary>
		/// void* getAllFlags
		/// </summary>
		public IntPtr getAllFlags;
		
		/// <summary>
		/// void* getAllFlagWriteTypes
		/// </summary>
		public IntPtr getAllFlagWriteTypes;
		
		/// <summary>
		/// void* getAllSemanticFlagClasses
		/// </summary>
		public IntPtr getAllSemanticFlagClasses;
		
		/// <summary>
		/// void* getAllSemanticFlagGroups
		/// </summary>
		public IntPtr getAllSemanticFlagGroups;
		
		/// <summary>
		/// void* getFlagRole
		/// </summary>
		public IntPtr getFlagRole;
		
		/// <summary>
		/// void* getFlagsRequiredForFlagCondition
		/// </summary>
		public IntPtr getFlagsRequiredForFlagCondition;
		
		/// <summary>
		/// void* getFlagsRequiredForSemanticFlagGroup
		/// </summary>
		public IntPtr getFlagsRequiredForSemanticFlagGroup;
		
		/// <summary>
		/// void* getFlagConditionsForSemanticFlagGroup
		/// </summary>
		public IntPtr getFlagConditionsForSemanticFlagGroup;
		
		/// <summary>
		/// void* freeFlagConditionsForSemanticFlagGroup
		/// </summary>
		public IntPtr freeFlagConditionsForSemanticFlagGroup;
		
		/// <summary>
		/// void* getFlagsWrittenByFlagWriteType
		/// </summary>
		public IntPtr getFlagsWrittenByFlagWriteType;
		
		/// <summary>
		/// void* getSemanticClassForFlagWriteType
		/// </summary>
		public IntPtr getSemanticClassForFlagWriteType;
		
		/// <summary>
		/// void* getFlagWriteLowLevelIL
		/// </summary>
		public IntPtr getFlagWriteLowLevelIL;
		
		/// <summary>
		/// void* getFlagConditionLowLevelIL
		/// </summary>
		public IntPtr getFlagConditionLowLevelIL;
		
		/// <summary>
		/// void* getSemanticFlagGroupLowLevelIL
		/// </summary>
		public IntPtr getSemanticFlagGroupLowLevelIL;
		
		/// <summary>
		/// void* freeRegisterList
		/// </summary>
		public IntPtr freeRegisterList;
		
		/// <summary>
		/// void* getRegisterInfo
		/// </summary>
		public IntPtr getRegisterInfo;
		
		/// <summary>
		/// void* getStackPointerRegister
		/// </summary>
		public IntPtr getStackPointerRegister;
		
		/// <summary>
		/// void* getLinkRegister
		/// </summary>
		public IntPtr getLinkRegister;
		
		/// <summary>
		/// void* getGlobalRegisters
		/// </summary>
		public IntPtr getGlobalRegisters;
		
		/// <summary>
		/// void* getSystemRegisters
		/// </summary>
		public IntPtr getSystemRegisters;
		
		/// <summary>
		/// void* getRegisterStackName
		/// </summary>
		public IntPtr getRegisterStackName;
		
		/// <summary>
		/// void* getAllRegisterStacks
		/// </summary>
		public IntPtr getAllRegisterStacks;
		
		/// <summary>
		/// void* getRegisterStackInfo
		/// </summary>
		public IntPtr getRegisterStackInfo;
		
		/// <summary>
		/// void* getIntrinsicClass
		/// </summary>
		public IntPtr getIntrinsicClass;
		
		/// <summary>
		/// void* getIntrinsicName
		/// </summary>
		public IntPtr getIntrinsicName;
		
		/// <summary>
		/// void* getAllIntrinsics
		/// </summary>
		public IntPtr getAllIntrinsics;
		
		/// <summary>
		/// void* getIntrinsicInputs
		/// </summary>
		public IntPtr getIntrinsicInputs;
		
		/// <summary>
		/// void* freeNameAndTypeList
		/// </summary>
		public IntPtr freeNameAndTypeList;
		
		/// <summary>
		/// void* getIntrinsicOutputs
		/// </summary>
		public IntPtr getIntrinsicOutputs;
		
		/// <summary>
		/// void* freeTypeList
		/// </summary>
		public IntPtr freeTypeList;
		
		/// <summary>
		/// void* canAssemble
		/// </summary>
		public IntPtr canAssemble;
		
		/// <summary>
		/// void* assemble
		/// </summary>
		public IntPtr assemble;
		
		/// <summary>
		/// void* isNeverBranchPatchAvailable
		/// </summary>
		public IntPtr isNeverBranchPatchAvailable;
		
		/// <summary>
		/// void* isAlwaysBranchPatchAvailable
		/// </summary>
		public IntPtr isAlwaysBranchPatchAvailable;
		
		/// <summary>
		/// void* isInvertBranchPatchAvailable
		/// </summary>
		public IntPtr isInvertBranchPatchAvailable;
		
		/// <summary>
		/// void** isSkipAndReturnZeroPatchAvailable
		/// </summary>
		public IntPtr isSkipAndReturnZeroPatchAvailable;
		
		/// <summary>
		/// void* isSkipAndReturnValuePatchAvailable
		/// </summary>
		public IntPtr isSkipAndReturnValuePatchAvailable;
		
		/// <summary>
		/// void* convertToNop
		/// </summary>
		public IntPtr convertToNop;
		
		/// <summary>
		/// void* alwaysBranch
		/// </summary>
		public IntPtr alwaysBranch;
		
		/// <summary>
		/// void* invertBranch
		/// </summary>
		public IntPtr invertBranch;
		
		/// <summary>
		/// void* skipAndReturnValue
		/// </summary>
		public IntPtr skipAndReturnValue;
	}

    public abstract class CustomArchitecture 
    {
		internal delegate void InitDelegate(
			Architecture arch
		);
		
		internal delegate Endianness GetEndiannessDelegate();
		
		internal delegate ulong GetAddressSizeDelegate();
		
		internal delegate ulong GetDefaultIntegerSizeDelegate();
		
		internal delegate ulong GetInstructionAlignmentDelegate();
		
		internal delegate ulong GetMaxInstructionLengthDelegate();
		
		internal delegate ulong GetOpcodeDisplayLengthDelegate();

		internal delegate Architecture? GetAssociatedArchitectureByAddressDelegate(
			ref ulong address
		);
		
		internal delegate InstructionInfo? GetInstructionInfoDelegate(
			byte[] data,
			ulong address
		);
		
		internal delegate InstructionTextToken[] GetInstructionTextDelegate(
			byte[] data,
			ulong address,
			out ulong length
		);

		internal delegate void FreeInstructionTextDelegate(
			IntPtr tokens,
			ulong count
		);
		
		internal delegate bool GetInstructionLowLevelILDelegate(
			byte[] data,
			ulong address,
			out ulong length,
			LowLevelILFunction il
		);
		
		internal delegate string GetRegisterNameDelegate(
			RegisterIndex reg
		);
		
		internal delegate string getFlagNameDelegate(
			FlagIndex flag
		);
		
		internal delegate string GetFlagWriteTypeNameDelegate(
			uint flags
		);
		
		internal delegate string GetSemanticFlagClassNameDelegate(
			uint semClass
		);
		
		internal delegate string GetSemanticFlagGroupNameDelegate(
			uint  semGroup
		);
		
		internal delegate uint[] GetFullWidthRegistersDelegate();
		
		internal delegate uint[] GetAllRegistersDelegate();
		
		internal delegate uint[] GetAllFlagsDelegate();
		
		internal delegate uint[] GetAllFlagWriteTypesDelegate();
		
		internal delegate uint[] GetAllSemanticFlagClassesDelegate();
		
		internal delegate uint[] GetAllSemanticFlagGroupsDelegate();
		
		internal delegate FlagRole GetFlagRoleDelegate(
			uint flag,
			uint semClass
		);
		
		internal delegate uint[] GetFlagsRequiredForFlagConditionDelegate(
			LowLevelILFlagCondition cond,
			uint semClass
		);
		
		internal delegate uint[] GetFlagsRequiredForSemanticFlagGroupDelegate(
			uint semGroup
		);
		
		internal delegate FlagConditionForSemanticClass[] GetFlagConditionsForSemanticFlagGroupDelegate(
			uint semGroup
		);
		
		internal delegate void FreeFlagConditionsForSemanticFlagGroupDelegate(
			IntPtr conditions
		);
		
		internal delegate uint[] GetFlagsWrittenByFlagWriteTypeDelegate(
			uint writeType
		);
		
		internal delegate uint GetSemanticClassForFlagWriteTypeDelegate(
			uint writeType
		);
		
		internal delegate ulong GetFlagWriteLowLevelILDelegate(
			LowLevelILOperation op,
			ulong size,
			uint flagWriteType,
			uint flag,
			RegisterOrConstant[] operands,
			LowLevelILFunction il
		);
		
		internal delegate ulong GetFlagConditionLowLevelILDelegate(
			LowLevelILFlagCondition cond,
			uint semClass,
			LowLevelILFunction il
		);
		
		internal delegate ulong GetSemanticFlagGroupLowLevelILDelegate(
			uint semGroup,
			LowLevelILFunction il
		);
		
		internal delegate void FreeRegisterListDelegate(
			IntPtr regs
		);
		
		internal delegate RegisterInfo GetRegisterInfoDelegate(
			uint reg
		);
		
		internal delegate uint GetStackPointerRegisterDelegate();
		
		internal delegate uint GetLinkRegisterDelegate();
		
		internal delegate uint[] GetGlobalRegistersDelegate();
		
		internal delegate uint[] GetSystemRegistersDelegate();
		
		internal delegate string GetRegisterStackNameDelegate(
			uint regStack
		);
		
		internal unsafe delegate uint[] GetAllRegisterStacksDelegate();
		
		internal unsafe delegate RegisterStackInfo GetRegisterStackInfoDelegate(
			uint regStack
		);
		
		internal delegate IntrinsicClass GetIntrinsicClassDelegate(
			uint intrinsic
		);
		
		internal delegate string GetIntrinsicNameDelegate(
			uint intrinsic
		);
		
		internal delegate uint[] GetAllIntrinsicsDelegate();
		
		internal delegate NameAndType[] GetIntrinsicInputsDelegate(
			uint intrinsic
		);
		
		internal unsafe delegate void FreeNameAndTypeListDelegate(
			IntPtr nt,
			ulong count
		);
		
		internal delegate TypeWithConfidence[] GetIntrinsicOutputsDelegate(
			uint intrinsic
		);
		
		internal delegate void FreeTypeListDelegate(
			IntPtr types,
			ulong count
		);
		
		internal delegate bool CanAssembleDelegate();
		
		internal delegate byte[] AssembleDelegate(
			string code,
			ulong address
		);
		
		internal delegate bool IsNeverBranchPatchAvailableDelegate(
			byte[] data,
			ulong address
		);
		
		internal delegate bool IsAlwaysBranchPatchAvailableDelegate(
			byte[] data,
			ulong address
		);
		
		internal delegate bool IsInvertBranchPatchAvailableDelegate(
			byte[] data,
			ulong address
		);
		
		internal delegate bool IsSkipAndReturnZeroPatchAvailableDelegate(
			byte[] data,
			ulong address
		);
		
		internal delegate void IsSkipAndReturnValuePatchAvailableDelegate(
			byte[] data,
			ulong address
		);
		
		internal delegate bool ConvertToNopDelegate(
			byte[] data,
			ulong address
		);
		
		internal delegate bool AlwaysBranchDelegate(
			byte[] data,
			ulong address
		);
		
		internal delegate bool InvertBranchDelegate(
			byte[] data,
			ulong address
		);
		
		internal delegate bool SkipAndReturnValueDelegate(
			byte[] data,
			ulong address,
			ulong value
		);
		
		public CustomArchitecture() 
		{
		    
		}

	

		#region method

		public virtual void Init(
			Architecture arch
		)
		{
			
		}

		public virtual Endianness GetEndianness()
		{
			return Endianness.LittleEndian;
		}

		public virtual ulong GetAddressSize()
		{
			return 0;
		}

		public virtual ulong GetDefaultIntegerSize()
		{
			return 0;
		}

		public virtual ulong GetInstructionAlignment()
		{
			return 0;
		}

		public virtual ulong GetMaxInstructionLength()
		{
			return 0;
		}

		public virtual ulong GetOpcodeDisplayLength()
		{
			return 0;
		}

		public virtual Architecture? GetAssociatedArchitectureByAddress(
			ref ulong address
		)
		{
			return null;
		}

		public virtual InstructionInfo? GetInstructionInfo(
			byte[] data ,
			ulong address
		)
		{
			return null;
		}

		public virtual InstructionTextToken[] GetInstructionText(
			byte[] data ,
			ulong address ,
			out ulong length
		)
		{
			length = 0;
			
			return Array.Empty<InstructionTextToken>();
		}

		public virtual void FreeInstructionText(
			IntPtr tokens ,
			ulong count
		)
		{
			
		}

		public virtual ulong? GetInstructionLowLevelIL(
			byte[] data ,
			ulong address ,
			LowLevelILFunction il
		)
		{
			return null;
		}
		
		public virtual string GetRegisterName(
			RegisterIndex reg
		)
		{
			return string.Empty;
		}

		public virtual string getFlagName(
			FlagIndex flag
		)
		{
			return string.Empty;
		}

		public virtual string GetFlagWriteTypeName(
			uint flags
		)
		{
			return string.Empty;
		}

		public virtual string GetSemanticFlagClassName(
			uint semClass
		)
		{
			return string.Empty;
		}

		public virtual string GetSemanticFlagGroupName(
			uint semGroup
		)
		{
			return string.Empty;
		}
		
		public virtual uint[] GetFullWidthRegisters()
		{
			return Array.Empty<uint>();
		}

		
		public virtual uint[] GetAllRegisters()
		{
			return Array.Empty<uint>();
		}

		
		public virtual uint[] GetAllFlags()
		{
			return Array.Empty<uint>();
		}

		
		public virtual uint[] GetAllFlagWriteTypes()
		{
			return Array.Empty<uint>();
		}

		
		public virtual uint[] GetAllSemanticFlagClasses()
		{
			return Array.Empty<uint>();
		}


		public virtual uint[] GetAllSemanticFlagGroups()
		{
			return Array.Empty<uint>();
		}

		public virtual FlagRole GetFlagRole(
			uint flag ,
			uint semClass
		)
		{
			return 0;
		}

		public virtual uint[] GetFlagsRequiredForFlagCondition(
			LowLevelILFlagCondition cond ,
			uint semClass
		)
		{
			return Array.Empty<uint>();
		}

		public virtual uint[] GetFlagsRequiredForSemanticFlagGroup(
			uint semGroup
		)
		{
			return Array.Empty<uint>();
		}

		public virtual FlagConditionForSemanticClass[] GetFlagConditionsForSemanticFlagGroup(
			uint semGroup
		)
		{
			return Array.Empty<FlagConditionForSemanticClass>();
		}

		public virtual void FreeFlagConditionsForSemanticFlagGroup(
			IntPtr conditions
		)
		{
			
		}

		public virtual uint[] GetFlagsWrittenByFlagWriteType(
			uint writeType
		)
		{
			return Array.Empty<uint>();
		}

		public virtual uint GetSemanticClassForFlagWriteType(
			uint writeType
		)
		{
			return 0;
		}

		public virtual ulong GetFlagWriteLowLevelIL(
			LowLevelILOperation op ,
			ulong size ,
			uint flagWriteType ,
			uint flag ,
			RegisterOrConstant[] operands ,
			LowLevelILFunction il
		)
		{
			return 0;
		}

		public virtual ulong GetFlagConditionLowLevelIL(
			LowLevelILFlagCondition cond ,
			uint semClass ,
			LowLevelILFunction il
		)
		{
			return 0;
		}

		public virtual ulong GetSemanticFlagGroupLowLevelIL(
			uint semGroup ,
			LowLevelILFunction il
		)
		{
			return 0;
		}

		public virtual void FreeRegisterList(
			IntPtr regs
		)
		{
			
		}

		public virtual RegisterInfo GetRegisterInfo(
			uint reg
		)
		{
			return new RegisterInfo();
		}

		public virtual uint GetStackPointerRegister()
		{
			return 0;
		}

		public virtual uint GetLinkRegister()
		{
			return 0;
		}

		public virtual uint[] GetGlobalRegisters()
		{
			return Array.Empty<uint>();
		}

		public virtual uint[] GetSystemRegisters()
		{
			return Array.Empty<uint>();
		}

		public virtual string GetRegisterStackName(
			uint regStack
		)
		{
			return string.Empty;
		}
		
		public virtual uint[] GetAllRegisterStacks()
		{
			return Array.Empty<uint>();
		}

		public virtual RegisterStackInfo GetRegisterStackInfo(
			uint regStack
		)
		{
			return new RegisterStackInfo();
		}

		public virtual IntrinsicClass GetIntrinsicClass(
			uint intrinsic
		)
		{
			return 0;
		}

		public virtual string GetIntrinsicName(
			uint intrinsic
		)
		{
			return string.Empty;
		}

		public virtual uint[] GetAllIntrinsics()
		{
			return Array.Empty<uint>();
		}
		
		public virtual NameAndType[] GetIntrinsicInputs(
			uint intrinsic
		)
		{
			return Array.Empty<NameAndType>();
		}

		public virtual void FreeNameAndTypeList(
			IntPtr nt ,
			ulong count
		)
		{
			
		}
		
		public virtual TypeWithConfidence[] GetIntrinsicOutputs(
			uint intrinsic
		)
		{
			return Array.Empty<TypeWithConfidence>();
		}
		
		public virtual void FreeTypeList(
			IntPtr types ,
			ulong count
		)
		{
			
		}

		public virtual bool CanAssemble()
		{
			return false;
		}

		public virtual byte[] Assemble(
			string code ,
			ulong address
		)
		{
			return Array.Empty<byte>();
		}

		public virtual bool IsNeverBranchPatchAvailable(
			byte[] data ,
			ulong address
		)
		{
			return false;
		}

		public virtual bool IsAlwaysBranchPatchAvailable(
			byte[] data ,
			ulong address
		)
		{
			return false;
		}

		public virtual bool IsInvertBranchPatchAvailable(
			byte[] data ,
			ulong address
		)
		{
			return false;
		}

		public virtual bool IsSkipAndReturnZeroPatchAvailable(
			byte[] data ,
			ulong address
		)
		{
			return false;
		}

		public virtual bool IsSkipAndReturnValuePatchAvailable(
			byte[] data ,
			ulong address
		)
		{
			return false;
		}

		public virtual bool ConvertToNop(
			byte[] data ,
			ulong address
		)
		{
			return false;
		}

		public virtual bool AlwaysBranch(
			byte[] data ,
			ulong address
		)
		{
			return false;
		}

		public virtual bool InvertBranch(
			byte[] data ,
			ulong address
		)
		{
			return false;
		}

		public virtual bool SkipAndReturnValue(
			byte[] data ,
			ulong address ,
			ulong value
		)
		{
			return false;
		}
		

		#endregion
    }
}