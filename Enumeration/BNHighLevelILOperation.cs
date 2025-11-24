using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum HighLevelILOperation : uint
	{
		/// <summary>
		/// 
		/// </summary>
		HLIL_NOP = 0,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_BLOCK = 1,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_IF = 2,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_WHILE = 3,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_DO_WHILE = 4,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FOR = 5,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_SWITCH = 6,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CASE = 7,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_BREAK = 8,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CONTINUE = 9,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_JUMP = 10,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_RET = 11,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_NORET = 12,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_GOTO = 13,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_LABEL = 14,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_VAR_DECLARE = 15,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_VAR_INIT = 16,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ASSIGN = 17,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ASSIGN_UNPACK = 18,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FORCE_VER = 19,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ASSERT = 20,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_VAR = 21,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_STRUCT_FIELD = 22,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ARRAY_INDEX = 23,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_SPLIT = 24,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_DEREF = 25,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_DEREF_FIELD = 26,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ADDRESS_OF = 27,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CONST = 28,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CONST_DATA = 29,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CONST_PTR = 30,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_EXTERN_PTR = 31,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FLOAT_CONST = 32,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_IMPORT = 33,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ADD = 34,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ADC = 35,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_SUB = 36,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_SBB = 37,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_AND = 38,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_OR = 39,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_XOR = 40,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_LSL = 41,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_LSR = 42,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ASR = 43,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ROL = 44,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_RLC = 45,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ROR = 46,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_RRC = 47,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_MUL = 48,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_MULU_DP = 49,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_MULS_DP = 50,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_DIVU = 51,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_DIVU_DP = 52,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_DIVS = 53,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_DIVS_DP = 54,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_MODU = 55,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_MODU_DP = 56,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_MODS = 57,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_MODS_DP = 58,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_NEG = 59,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_NOT = 60,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_SX = 61,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ZX = 62,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_LOW_PART = 63,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CALL = 64,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CMP_E = 65,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CMP_NE = 66,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CMP_SLT = 67,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CMP_ULT = 68,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CMP_SLE = 69,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CMP_ULE = 70,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CMP_SGE = 71,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CMP_UGE = 72,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CMP_SGT = 73,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CMP_UGT = 74,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_TEST_BIT = 75,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_BOOL_TO_INT = 76,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ADD_OVERFLOW = 77,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_SYSCALL = 78,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_TAILCALL = 79,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_INTRINSIC = 80,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_BP = 81,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_TRAP = 82,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_UNDEF = 83,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_UNIMPL = 84,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_UNIMPL_MEM = 85,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FADD = 86,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FSUB = 87,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FMUL = 88,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FDIV = 89,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FSQRT = 90,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FNEG = 91,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FABS = 92,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FLOAT_TO_INT = 93,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_INT_TO_FLOAT = 94,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FLOAT_CONV = 95,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ROUND_TO_INT = 96,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FLOOR = 97,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CEIL = 98,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FTRUNC = 99,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FCMP_E = 100,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FCMP_NE = 101,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FCMP_LT = 102,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FCMP_LE = 103,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FCMP_GE = 104,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FCMP_GT = 105,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FCMP_O = 106,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FCMP_UO = 107,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_UNREACHABLE = 108,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_WHILE_SSA = 109,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_DO_WHILE_SSA = 110,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FOR_SSA = 111,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_VAR_INIT_SSA = 112,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ASSIGN_MEM_SSA = 113,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ASSIGN_UNPACK_MEM_SSA = 114,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_FORCE_VER_SSA = 115,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ASSERT_SSA = 116,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_VAR_SSA = 117,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_ARRAY_INDEX_SSA = 118,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_DEREF_SSA = 119,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_DEREF_FIELD_SSA = 120,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_CALL_SSA = 121,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_SYSCALL_SSA = 122,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_INTRINSIC_SSA = 123,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_VAR_PHI = 124,
		
		/// <summary>
		/// 
		/// </summary>
		HLIL_MEM_PHI = 125
	}
}