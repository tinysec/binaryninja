using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum MediumLevelILOperation : uint
	{
		/// <summary>
		/// 
		/// </summary>
		MLIL_NOP = 0,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SET_VAR = 1,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SET_VAR_FIELD = 2,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SET_VAR_SPLIT = 3,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_ASSERT = 4,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FORCE_VER = 5,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_LOAD = 6,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_LOAD_STRUCT = 7,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_STORE = 8,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_STORE_STRUCT = 9,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_VAR = 10,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_VAR_FIELD = 11,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_VAR_SPLIT = 12,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_ADDRESS_OF = 13,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_ADDRESS_OF_FIELD = 14,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CONST = 15,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CONST_DATA = 16,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CONST_PTR = 17,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_EXTERN_PTR = 18,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FLOAT_CONST = 19,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_IMPORT = 20,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_ADD = 21,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_ADC = 22,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SUB = 23,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SBB = 24,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_AND = 25,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_OR = 26,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_XOR = 27,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_LSL = 28,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_LSR = 29,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_ASR = 30,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_ROL = 31,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_RLC = 32,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_ROR = 33,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_RRC = 34,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_MUL = 35,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_MULU_DP = 36,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_MULS_DP = 37,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_DIVU = 38,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_DIVU_DP = 39,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_DIVS = 40,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_DIVS_DP = 41,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_MODU = 42,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_MODU_DP = 43,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_MODS = 44,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_MODS_DP = 45,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_NEG = 46,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_NOT = 47,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SX = 48,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_ZX = 49,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_LOW_PART = 50,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_JUMP = 51,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_JUMP_TO = 52,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_RET_HINT = 53,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CALL = 54,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CALL_UNTYPED = 55,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CALL_OUTPUT = 56,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CALL_PARAM = 57,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SEPARATE_PARAM_LIST = 58,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SHARED_PARAM_SLOT = 59,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_RET = 60,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_NORET = 61,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_IF = 62,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_GOTO = 63,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CMP_E = 64,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CMP_NE = 65,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CMP_SLT = 66,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CMP_ULT = 67,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CMP_SLE = 68,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CMP_ULE = 69,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CMP_SGE = 70,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CMP_UGE = 71,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CMP_SGT = 72,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CMP_UGT = 73,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_TEST_BIT = 74,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_BOOL_TO_INT = 75,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_ADD_OVERFLOW = 76,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SYSCALL = 77,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SYSCALL_UNTYPED = 78,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_TAILCALL = 79,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_TAILCALL_UNTYPED = 80,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_INTRINSIC = 81,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FREE_VAR_SLOT = 82,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_BP = 83,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_TRAP = 84,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_UNDEF = 85,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_UNIMPL = 86,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_UNIMPL_MEM = 87,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FADD = 88,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FSUB = 89,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FMUL = 90,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FDIV = 91,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FSQRT = 92,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FNEG = 93,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FABS = 94,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FLOAT_TO_INT = 95,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_INT_TO_FLOAT = 96,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FLOAT_CONV = 97,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_ROUND_TO_INT = 98,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FLOOR = 99,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CEIL = 100,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FTRUNC = 101,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FCMP_E = 102,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FCMP_NE = 103,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FCMP_LT = 104,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FCMP_LE = 105,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FCMP_GE = 106,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FCMP_GT = 107,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FCMP_O = 108,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FCMP_UO = 109,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SET_VAR_SSA = 110,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SET_VAR_SSA_FIELD = 111,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SET_VAR_SPLIT_SSA = 112,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SET_VAR_ALIASED = 113,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SET_VAR_ALIASED_FIELD = 114,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_VAR_SSA = 115,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_VAR_SSA_FIELD = 116,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_VAR_ALIASED = 117,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_VAR_ALIASED_FIELD = 118,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_VAR_SPLIT_SSA = 119,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_ASSERT_SSA = 120,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FORCE_VER_SSA = 121,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CALL_SSA = 122,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CALL_UNTYPED_SSA = 123,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SYSCALL_SSA = 124,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_SYSCALL_UNTYPED_SSA = 125,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_TAILCALL_SSA = 126,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_TAILCALL_UNTYPED_SSA = 127,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CALL_PARAM_SSA = 128,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_CALL_OUTPUT_SSA = 129,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_MEMORY_INTRINSIC_OUTPUT_SSA = 130,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_LOAD_SSA = 131,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_LOAD_STRUCT_SSA = 132,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_STORE_SSA = 133,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_STORE_STRUCT_SSA = 134,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_INTRINSIC_SSA = 135,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_MEMORY_INTRINSIC_SSA = 136,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_FREE_VAR_SLOT_SSA = 137,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_VAR_PHI = 138,
		
		/// <summary>
		/// 
		/// </summary>
		MLIL_MEM_PHI = 139
	}
}