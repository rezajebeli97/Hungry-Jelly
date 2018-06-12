#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// System.String
struct String_t;
// System.IO.FileStream
struct FileStream_t1527309539;
// System.IO.StreamReader
struct StreamReader_t717565226;
// System.Text.Encoding
struct Encoding_t180559927;

#include "codegen/il2cpp-codegen.h"
#include "mscorlib_System_String968488902.h"
#include "mscorlib_System_IO_FileMode1356058118.h"
#include "mscorlib_System_Text_Encoding180559927.h"

// System.Void System.IO.File::Delete(System.String)
extern "C"  void File_Delete_m760984832 (Il2CppObject * __this /* static, unused */, String_t* ___path, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.IO.File::Exists(System.String)
extern "C"  bool File_Exists_m1326262381 (Il2CppObject * __this /* static, unused */, String_t* ___path, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IO.FileStream System.IO.File::Open(System.String,System.IO.FileMode)
extern "C"  FileStream_t1527309539 * File_Open_m1918038371 (Il2CppObject * __this /* static, unused */, String_t* ___path, int32_t ___mode, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IO.FileStream System.IO.File::OpenRead(System.String)
extern "C"  FileStream_t1527309539 * File_OpenRead_m3104031109 (Il2CppObject * __this /* static, unused */, String_t* ___path, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.IO.StreamReader System.IO.File::OpenText(System.String)
extern "C"  StreamReader_t717565226 * File_OpenText_m396847893 (Il2CppObject * __this /* static, unused */, String_t* ___path, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.IO.File::ReadAllText(System.String)
extern "C"  String_t* File_ReadAllText_m3411439778 (Il2CppObject * __this /* static, unused */, String_t* ___path, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.IO.File::ReadAllText(System.String,System.Text.Encoding)
extern "C"  String_t* File_ReadAllText_m108099503 (Il2CppObject * __this /* static, unused */, String_t* ___path, Encoding_t180559927 * ___encoding, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.IO.File::WriteAllText(System.String,System.String)
extern "C"  void File_WriteAllText_m4080768088 (Il2CppObject * __this /* static, unused */, String_t* ___path, String_t* ___contents, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.IO.File::WriteAllText(System.String,System.String,System.Text.Encoding)
extern "C"  void File_WriteAllText_m457367993 (Il2CppObject * __this /* static, unused */, String_t* ___path, String_t* ___contents, Encoding_t180559927 * ___encoding, const MethodInfo* method) IL2CPP_METHOD_ATTR;
