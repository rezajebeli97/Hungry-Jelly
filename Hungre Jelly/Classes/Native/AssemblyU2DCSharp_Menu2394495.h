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

// Menu
struct  Menu_t2394495  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.UI.Button Menu::startText
	Button_t990034267 * ___startText_2;
	// UnityEngine.UI.Button Menu::exitText
	Button_t990034267 * ___exitText_3;

public:
	inline static int32_t get_offset_of_startText_2() { return static_cast<int32_t>(offsetof(Menu_t2394495, ___startText_2)); }
	inline Button_t990034267 * get_startText_2() const { return ___startText_2; }
	inline Button_t990034267 ** get_address_of_startText_2() { return &___startText_2; }
	inline void set_startText_2(Button_t990034267 * value)
	{
		___startText_2 = value;
		Il2CppCodeGenWriteBarrier(&___startText_2, value);
	}

	inline static int32_t get_offset_of_exitText_3() { return static_cast<int32_t>(offsetof(Menu_t2394495, ___exitText_3)); }
	inline Button_t990034267 * get_exitText_3() const { return ___exitText_3; }
	inline Button_t990034267 ** get_address_of_exitText_3() { return &___exitText_3; }
	inline void set_exitText_3(Button_t990034267 * value)
	{
		___exitText_3 = value;
		Il2CppCodeGenWriteBarrier(&___exitText_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
