#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.UI.Button
struct Button_t990034267;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UserFinished
struct  UserFinished_t3017697661  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.UI.Button UserFinished::startText
	Button_t990034267 * ___startText_2;
	// UnityEngine.UI.Button UserFinished::homeText
	Button_t990034267 * ___homeText_3;

public:
	inline static int32_t get_offset_of_startText_2() { return static_cast<int32_t>(offsetof(UserFinished_t3017697661, ___startText_2)); }
	inline Button_t990034267 * get_startText_2() const { return ___startText_2; }
	inline Button_t990034267 ** get_address_of_startText_2() { return &___startText_2; }
	inline void set_startText_2(Button_t990034267 * value)
	{
		___startText_2 = value;
		Il2CppCodeGenWriteBarrier(&___startText_2, value);
	}

	inline static int32_t get_offset_of_homeText_3() { return static_cast<int32_t>(offsetof(UserFinished_t3017697661, ___homeText_3)); }
	inline Button_t990034267 * get_homeText_3() const { return ___homeText_3; }
	inline Button_t990034267 ** get_address_of_homeText_3() { return &___homeText_3; }
	inline void set_homeText_3(Button_t990034267 * value)
	{
		___homeText_3 = value;
		Il2CppCodeGenWriteBarrier(&___homeText_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
