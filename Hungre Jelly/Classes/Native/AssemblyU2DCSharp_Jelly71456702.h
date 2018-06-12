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
// UnityEngine.Animator
struct Animator_t792326996;
// UnityEngine.UI.Text
struct Text_t3286458198;
// System.Collections.Generic.Dictionary`2<System.String,System.Int32>
struct Dictionary_2_t190145395;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"
#include "UnityEngine_UnityEngine_Vector23525329788.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Jelly
struct  Jelly_t71456702  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.Rigidbody2D Jelly::myRigidbody
	Rigidbody2D_t3632243084 * ___myRigidbody_2;
	// UnityEngine.Rigidbody2D Jelly::brickRigidbody
	Rigidbody2D_t3632243084 * ___brickRigidbody_3;
	// UnityEngine.Vector2 Jelly::velocityVector
	Vector2_t3525329788  ___velocityVector_4;
	// UnityEngine.Vector2 Jelly::vectorDown
	Vector2_t3525329788  ___vectorDown_5;
	// UnityEngine.Vector2 Jelly::vectorUp
	Vector2_t3525329788  ___vectorUp_6;
	// UnityEngine.Vector2 Jelly::initialLocale
	Vector2_t3525329788  ___initialLocale_7;
	// UnityEngine.Animator Jelly::myAnimator
	Animator_t792326996 * ___myAnimator_8;
	// UnityEngine.UI.Text Jelly::showHealth
	Text_t3286458198 * ___showHealth_9;
	// System.Int32 Jelly::maxLevel
	int32_t ___maxLevel_10;
	// System.Boolean Jelly::jump
	bool ___jump_11;

public:
	inline static int32_t get_offset_of_myRigidbody_2() { return static_cast<int32_t>(offsetof(Jelly_t71456702, ___myRigidbody_2)); }
	inline Rigidbody2D_t3632243084 * get_myRigidbody_2() const { return ___myRigidbody_2; }
	inline Rigidbody2D_t3632243084 ** get_address_of_myRigidbody_2() { return &___myRigidbody_2; }
	inline void set_myRigidbody_2(Rigidbody2D_t3632243084 * value)
	{
		___myRigidbody_2 = value;
		Il2CppCodeGenWriteBarrier(&___myRigidbody_2, value);
	}

	inline static int32_t get_offset_of_brickRigidbody_3() { return static_cast<int32_t>(offsetof(Jelly_t71456702, ___brickRigidbody_3)); }
	inline Rigidbody2D_t3632243084 * get_brickRigidbody_3() const { return ___brickRigidbody_3; }
	inline Rigidbody2D_t3632243084 ** get_address_of_brickRigidbody_3() { return &___brickRigidbody_3; }
	inline void set_brickRigidbody_3(Rigidbody2D_t3632243084 * value)
	{
		___brickRigidbody_3 = value;
		Il2CppCodeGenWriteBarrier(&___brickRigidbody_3, value);
	}

	inline static int32_t get_offset_of_velocityVector_4() { return static_cast<int32_t>(offsetof(Jelly_t71456702, ___velocityVector_4)); }
	inline Vector2_t3525329788  get_velocityVector_4() const { return ___velocityVector_4; }
	inline Vector2_t3525329788 * get_address_of_velocityVector_4() { return &___velocityVector_4; }
	inline void set_velocityVector_4(Vector2_t3525329788  value)
	{
		___velocityVector_4 = value;
	}

	inline static int32_t get_offset_of_vectorDown_5() { return static_cast<int32_t>(offsetof(Jelly_t71456702, ___vectorDown_5)); }
	inline Vector2_t3525329788  get_vectorDown_5() const { return ___vectorDown_5; }
	inline Vector2_t3525329788 * get_address_of_vectorDown_5() { return &___vectorDown_5; }
	inline void set_vectorDown_5(Vector2_t3525329788  value)
	{
		___vectorDown_5 = value;
	}

	inline static int32_t get_offset_of_vectorUp_6() { return static_cast<int32_t>(offsetof(Jelly_t71456702, ___vectorUp_6)); }
	inline Vector2_t3525329788  get_vectorUp_6() const { return ___vectorUp_6; }
	inline Vector2_t3525329788 * get_address_of_vectorUp_6() { return &___vectorUp_6; }
	inline void set_vectorUp_6(Vector2_t3525329788  value)
	{
		___vectorUp_6 = value;
	}

	inline static int32_t get_offset_of_initialLocale_7() { return static_cast<int32_t>(offsetof(Jelly_t71456702, ___initialLocale_7)); }
	inline Vector2_t3525329788  get_initialLocale_7() const { return ___initialLocale_7; }
	inline Vector2_t3525329788 * get_address_of_initialLocale_7() { return &___initialLocale_7; }
	inline void set_initialLocale_7(Vector2_t3525329788  value)
	{
		___initialLocale_7 = value;
	}

	inline static int32_t get_offset_of_myAnimator_8() { return static_cast<int32_t>(offsetof(Jelly_t71456702, ___myAnimator_8)); }
	inline Animator_t792326996 * get_myAnimator_8() const { return ___myAnimator_8; }
	inline Animator_t792326996 ** get_address_of_myAnimator_8() { return &___myAnimator_8; }
	inline void set_myAnimator_8(Animator_t792326996 * value)
	{
		___myAnimator_8 = value;
		Il2CppCodeGenWriteBarrier(&___myAnimator_8, value);
	}

	inline static int32_t get_offset_of_showHealth_9() { return static_cast<int32_t>(offsetof(Jelly_t71456702, ___showHealth_9)); }
	inline Text_t3286458198 * get_showHealth_9() const { return ___showHealth_9; }
	inline Text_t3286458198 ** get_address_of_showHealth_9() { return &___showHealth_9; }
	inline void set_showHealth_9(Text_t3286458198 * value)
	{
		___showHealth_9 = value;
		Il2CppCodeGenWriteBarrier(&___showHealth_9, value);
	}

	inline static int32_t get_offset_of_maxLevel_10() { return static_cast<int32_t>(offsetof(Jelly_t71456702, ___maxLevel_10)); }
	inline int32_t get_maxLevel_10() const { return ___maxLevel_10; }
	inline int32_t* get_address_of_maxLevel_10() { return &___maxLevel_10; }
	inline void set_maxLevel_10(int32_t value)
	{
		___maxLevel_10 = value;
	}

	inline static int32_t get_offset_of_jump_11() { return static_cast<int32_t>(offsetof(Jelly_t71456702, ___jump_11)); }
	inline bool get_jump_11() const { return ___jump_11; }
	inline bool* get_address_of_jump_11() { return &___jump_11; }
	inline void set_jump_11(bool value)
	{
		___jump_11 = value;
	}
};

struct Jelly_t71456702_StaticFields
{
public:
	// System.Collections.Generic.Dictionary`2<System.String,System.Int32> Jelly::<>f__switch$map0
	Dictionary_2_t190145395 * ___U3CU3Ef__switchU24map0_12;

public:
	inline static int32_t get_offset_of_U3CU3Ef__switchU24map0_12() { return static_cast<int32_t>(offsetof(Jelly_t71456702_StaticFields, ___U3CU3Ef__switchU24map0_12)); }
	inline Dictionary_2_t190145395 * get_U3CU3Ef__switchU24map0_12() const { return ___U3CU3Ef__switchU24map0_12; }
	inline Dictionary_2_t190145395 ** get_address_of_U3CU3Ef__switchU24map0_12() { return &___U3CU3Ef__switchU24map0_12; }
	inline void set_U3CU3Ef__switchU24map0_12(Dictionary_2_t190145395 * value)
	{
		___U3CU3Ef__switchU24map0_12 = value;
		Il2CppCodeGenWriteBarrier(&___U3CU3Ef__switchU24map0_12, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
