#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Rigidbody2D
struct Rigidbody2D_t3632243084;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PingPong
struct  PingPong_t3931302058  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.Rigidbody2D PingPong::myRigidbody
	Rigidbody2D_t3632243084 * ___myRigidbody_2;

public:
	inline static int32_t get_offset_of_myRigidbody_2() { return static_cast<int32_t>(offsetof(PingPong_t3931302058, ___myRigidbody_2)); }
	inline Rigidbody2D_t3632243084 * get_myRigidbody_2() const { return ___myRigidbody_2; }
	inline Rigidbody2D_t3632243084 ** get_address_of_myRigidbody_2() { return &___myRigidbody_2; }
	inline void set_myRigidbody_2(Rigidbody2D_t3632243084 * value)
	{
		___myRigidbody_2 = value;
		Il2CppCodeGenWriteBarrier(&___myRigidbody_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
