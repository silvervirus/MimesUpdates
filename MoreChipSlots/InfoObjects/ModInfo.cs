using System;
using UnityEngine;

namespace MoreChipSlots.InfoObjects
{
	// Token: 0x02000006 RID: 6
	internal class ModInfo
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002393 File Offset: 0x00000593
		public static void FourChipsLayout()
		{
			ModInfo.Chip4_3_Position = new Vector3(-130f, 200f, 0f);
			ModInfo.Chip4_4_Position = new Vector3(130f, 200f, 0f);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000023C8 File Offset: 0x000005C8
		public static void SixChipsLayout()
		{
			ModInfo.Chip6_3_Position = new Vector3(-190f, 180f, 0f);
			ModInfo.Chip6_4_Position = new Vector3(190f, 180f, 0f);
			ModInfo.Chip6_5_Position = new Vector3(-100f, 250f, 0f);
			ModInfo.Chip6_6_Position = new Vector3(100f, 250f, 0f);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000243C File Offset: 0x0000063C
		public static void EightChipsLayout()
		{
			ModInfo.Chip8_1_Position = new Vector3(-233f, 236f, 0f);
			ModInfo.Chip8_2_Position = new Vector3(-115f, 236f, 0f);
			ModInfo.Chip8_3_Position = new Vector3(-230f, 200f, 0f);
			ModInfo.Chip8_4_Position = new Vector3(230f, 200f, 0f);
			ModInfo.Chip8_5_Position = new Vector3(-100f, 250f, 0f);
			ModInfo.Chip8_6_Position = new Vector3(100f, 250f, 0f);
			ModInfo.Chip8_7_Position = new Vector3(-250f, 090f, 0f);
			ModInfo.Chip8_8_Position = new Vector3(250f, 090f, 0f);
		}

		// Token: 0x04000001 RID: 1
		public static GameObject TestObject = GameObject.Find(ModInfo.SlotName3);

		// Token: 0x04000002 RID: 2
		internal static bool adjustIcon;

		// Token: 0x04000003 RID: 3
		internal static float iconX = -130f;

		// Token: 0x04000004 RID: 4
		internal static float iconY = 200f;

		// Token: 0x04000005 RID: 5
		internal static string SlotToCreate = "Chip1";

		// Token: 0x04000006 RID: 6
		internal static string SlotName2 = "Chip2";

		// Token: 0x04000007 RID: 7
		internal static string SlotName3 = "Chip3";

		// Token: 0x04000008 RID: 8
		internal static string SlotName4 = "Chip4";

		// Token: 0x04000009 RID: 9
		internal static string SlotName5 = "Chip5";

		// Token: 0x0400000A RID: 10
		internal static string SlotName6 = "Chip6";

		// Token: 0x0400000B RID: 11
		internal static string SlotName7 = "Chip7";

		// Token: 0x0400000C RID: 12
		internal static string SlotName8 = "Chip8";

		// Token: 0x0400000D RID: 13
		internal static Vector3 Chip1_Position;

		// Token: 0x0400000E RID: 14
		internal static Vector3 Chip2_Position;

		// Token: 0x0400000F RID: 15
		internal static Vector3 Chip3_Position;

		// Token: 0x04000010 RID: 16
		internal static Vector3 Chip4_Position;

		// Token: 0x04000011 RID: 17
		internal static Vector3 Chip5_Position;

		// Token: 0x04000012 RID: 18
		internal static Vector3 Chip6_Position;

		// Token: 0x04000013 RID: 19
		internal static Vector3 Chip7_Position;

		// Token: 0x04000014 RID: 20
		internal static Vector3 Chip8_Position;
        internal static Vector3 Chip4_3_Position;

        // Token: 0x04000010 RID: 16
        internal static Vector3 Chip4_4_Position;

        internal static Vector3 Chip8_1_Position;

        // Token: 0x0400000E RID: 14
        internal static Vector3 Chip8_2_Position;

        // Token: 0x0400000F RID: 15
        internal static Vector3 Chip8_3_Position;

        // Token: 0x04000010 RID: 16
        internal static Vector3 Chip8_4_Position;

        // Token: 0x04000011 RID: 17
        internal static Vector3 Chip8_5_Position;

        // Token: 0x04000012 RID: 18
        internal static Vector3 Chip8_6_Position;

        // Token: 0x04000013 RID: 19
        internal static Vector3 Chip8_7_Position;

        // Token: 0x04000014 RID: 20
        internal static Vector3 Chip8_8_Position;
        
		internal static Vector3 Chip6_1_Position;

        // Token: 0x0400000E RID: 14
        internal static Vector3 Chip6_2_Position;

        // Token: 0x0400000F RID: 15
        internal static Vector3 Chip6_3_Position;

        // Token: 0x04000010 RID: 16
        internal static Vector3 Chip6_4_Position;

        // Token: 0x04000011 RID: 17
        internal static Vector3 Chip6_5_Position;

        // Token: 0x04000012 RID: 18
        internal static Vector3 Chip6_6_Position;

        // Token: 0x04000013 RID: 19
        
    }
}
