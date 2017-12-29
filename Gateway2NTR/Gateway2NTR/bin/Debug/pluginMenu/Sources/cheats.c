#include "cheats.h"
#include <stdbool.h>
#include "hid.h"
#include "values.h"
#include <string.h>

u32 offset = 0;
u32 data = 0;

void	Test(void)
{
	if (READU32(offset + 0x57984C) != 0xE12FFF1E)
	{
		WRITEU32(offset + 0x579840, 0xE5C70004);
		WRITEU32(offset + 0x579844, 0xEA000000);
		WRITEU32(offset + 0x579848, 0xE5C71006);
		WRITEU32(offset + 0x57984C, 0xE12FFF1E);
	}
	if (READU32(offset + 0x80DEF90) == 0xE5C70004)
	{
		WRITEU32(offset + 0x80DEF90, 0xEBF7AE2A);
	}
	if (is_pressed(0x208))
	{
		WRITEU32(offset + 0x579844, 0xE3A01001);
	}
	if (is_pressed(0x108))
	{
		WRITEU32(offset + 0x579844, 0xEA000000);
	}
}

