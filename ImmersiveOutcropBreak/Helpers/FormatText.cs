using System;
using System.Text;
using ImmersiveOutcropBreak.Configuration;
using ImmersiveOutcropBreak.Info;

namespace ImmersiveOutcropBreak.Helpers
{
	// Token: 0x0200001D RID: 29
	internal class FormatText
	{
		// Token: 0x0600008F RID: 143 RVA: 0x000047E8 File Offset: 0x000029E8
		public static string NoGlovesAdvanced()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Advanced Glove Chip ");
			stringBuilder.Append(ModInfo.colorRed);
			stringBuilder.Append("no ");
			stringBuilder.Append(ModInfo.colorEnd);
			stringBuilder.Append("shale or other gloves detected");
			return stringBuilder.ToString();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004844 File Offset: 0x00002A44
		public static string NoGlovesStandard()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Standard Glove Chip ");
			stringBuilder.Append(ModInfo.colorRed);
			stringBuilder.Append("no ");
			stringBuilder.Append(ModInfo.colorEnd);
			stringBuilder.Append("gloves detected");
			return stringBuilder.ToString();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000048A0 File Offset: 0x00002AA0
		public static string NoGlovesBasic()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Basic Glove Chip ");
			stringBuilder.Append("no ");
			stringBuilder.Append("gloves detected");
			return stringBuilder.ToString();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000048E4 File Offset: 0x00002AE4
		public static string InventoryHiTechFull()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Inventory of ");
			stringBuilder.Append(ModInfo.colorBlue);
			stringBuilder.Append(CheckConditions.GetInventoryInfo("Size"));
			stringBuilder.Append(ModInfo.colorEnd);
			stringBuilder.Append(" slots ");
			stringBuilder.Append(ModInfo.colorRed);
			stringBuilder.Append("full");
			stringBuilder.Append(ModInfo.colorEnd);
			return stringBuilder.ToString();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004968 File Offset: 0x00002B68
		public static string InventoryHiTechFullHover()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Inventory of ");
			stringBuilder.Append(ModInfo.colorBlue);
			stringBuilder.Append(CheckConditions.GetInventoryInfo("Size"));
			stringBuilder.Append(ModInfo.colorEnd);
			stringBuilder.Append(" slots has ");
			bool flag = CheckConditions.GetInventoryInfo("Space") < 5;
			if (flag)
			{
				stringBuilder.Append(ModInfo.colorRed);
			}
			else
			{
				stringBuilder.Append(ModInfo.colorYellow);
			}
			stringBuilder.Append(CheckConditions.GetInventoryInfo("Space"));
			stringBuilder.Append(ModInfo.colorEnd);
			stringBuilder.Append(" slot");
			bool flag2 = CheckConditions.GetInventoryInfo("Space") != 1;
			if (flag2)
			{
				stringBuilder.Append("s");
			}
			stringBuilder.Append(" free,");
			stringBuilder.Append('\n');
			stringBuilder.Append(ModInfo.colorRed);
			bool flag3 = CheckConditions.GetInventoryInfo("Space") == 0;
			if (flag3)
			{
				stringBuilder.Append("unable ");
			}
			else
			{
				stringBuilder.Append("not enough space ");
			}
			stringBuilder.Append("to pickup this item");
			stringBuilder.Append(ModInfo.colorEnd);
			return stringBuilder.ToString();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004AA4 File Offset: 0x00002CA4
		public static string InventoryHiTechSpace()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Inventory of ");
			stringBuilder.Append(ModInfo.colorBlue);
			stringBuilder.Append(CheckConditions.GetInventoryInfo("Size"));
			stringBuilder.Append(ModInfo.colorEnd);
			stringBuilder.Append(" slots has ");
			bool flag = CheckConditions.GetInventoryInfo("Space") < 5;
			if (flag)
			{
				stringBuilder.Append(ModInfo.colorRed);
			}
			else
			{
				stringBuilder.Append(ModInfo.colorYellow);
			}
			stringBuilder.Append(CheckConditions.GetInventoryInfo("Space"));
			stringBuilder.Append(ModInfo.colorEnd);
			stringBuilder.Append(" slot");
			bool flag2 = CheckConditions.GetInventoryInfo("Space") > 1;
			if (flag2)
			{
				stringBuilder.Append("s");
			}
			stringBuilder.Append(" free");
			return stringBuilder.ToString();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004B80 File Offset: 0x00002D80
		public static string InventoryMidTechFull()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Inventory of ");
			stringBuilder.Append(CheckConditions.GetInventoryInfo("Size"));
			stringBuilder.Append(" slots full");
			return stringBuilder.ToString();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004BC8 File Offset: 0x00002DC8
		public static string InventoryMidTechFullHover()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Inventory of ");
			stringBuilder.Append(CheckConditions.GetInventoryInfo("Size"));
			stringBuilder.Append(" slots has ");
			bool flag = CheckConditions.GetInventoryInfo("Space") < 5;
			if (flag)
			{
				stringBuilder.Append(CheckConditions.GetInventoryInfo("Space"));
			}
			stringBuilder.Append(" slot");
			bool flag2 = CheckConditions.GetInventoryInfo("Space") != 1;
			if (flag2)
			{
				stringBuilder.Append("s");
			}
			stringBuilder.Append(" free,");
			stringBuilder.Append('\n');
			bool flag3 = CheckConditions.GetInventoryInfo("Space") == 0;
			if (flag3)
			{
				stringBuilder.Append("unable ");
			}
			else
			{
				stringBuilder.Append("not enough space ");
			}
			stringBuilder.Append("to pickup this item");
			return stringBuilder.ToString();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004CAC File Offset: 0x00002EAC
		public static string InventoryMidTechSpace()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Inventory of ");
			stringBuilder.Append(CheckConditions.GetInventoryInfo("Size"));
			stringBuilder.Append(" slots has ");
			stringBuilder.Append(CheckConditions.GetInventoryInfo("Space"));
			stringBuilder.Append(" slot");
			bool flag = CheckConditions.GetInventoryInfo("Space") > 1;
			if (flag)
			{
				stringBuilder.Append("s");
			}
			stringBuilder.Append(" free");
			return stringBuilder.ToString();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004D3C File Offset: 0x00002F3C
		public static string InventoryLoTechFull()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Inventory full");
			return stringBuilder.ToString();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004D68 File Offset: 0x00002F68
		public static string InventoryLoTechFullHover()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Not enough space to pickup this item");
			return stringBuilder.ToString();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004D94 File Offset: 0x00002F94
		public static string InventoryLoTechSpace()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Inventory has ");
			stringBuilder.Append(CheckConditions.GetInventoryInfo("Space"));
			stringBuilder.Append(" slot");
			bool flag = CheckConditions.GetInventoryInfo("Space") > 1;
			if (flag)
			{
				stringBuilder.Append("s");
			}
			stringBuilder.Append(" free");
			return stringBuilder.ToString();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004E04 File Offset: 0x00003004
		public static string InventoryHint()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Inventory info is ");
			bool showInventoryNow = ModInfo.ShowInventoryNow;
			if (showInventoryNow)
			{
				stringBuilder.Append(ModInfo.colorBlue);
				stringBuilder.Append("on ");
				stringBuilder.Append(ModInfo.colorEnd);
			}
			else
			{
				stringBuilder.Append("off ");
			}
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.ShowInventoryKeybindValue.ToString());
			stringBuilder.Append(" to toggle");
			stringBuilder.Append('\n');
			return stringBuilder.ToString();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004E9C File Offset: 0x0000309C
		public static string PulseOnOffHint()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Chip pulse is ");
			bool pulseOnNow = ModInfo.PulseOnNow;
			if (pulseOnNow)
			{
				stringBuilder.Append(ModInfo.colorBlue);
				stringBuilder.Append("on ");
				stringBuilder.Append(ModInfo.colorEnd);
			}
			else
			{
				stringBuilder.Append("off ");
			}
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.PulseKeybindValue.ToString());
			stringBuilder.Append(" to toggle");
			stringBuilder.Append('\n');
			return stringBuilder.ToString();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004F34 File Offset: 0x00003134
		public static string AutoBreakHint()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Auto break is ");
			bool autoBreakNow = ModInfo.AutoBreakNow;
			if (autoBreakNow)
			{
				stringBuilder.Append(ModInfo.colorBlue);
				stringBuilder.Append("on ");
				stringBuilder.Append(ModInfo.colorEnd);
			}
			else
			{
				stringBuilder.Append("off ");
			}
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.OutcropAutoBreakKeybindValue.ToString());
			stringBuilder.Append(" to toggle");
			stringBuilder.Append('\n');
			return stringBuilder.ToString();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004FCC File Offset: 0x000031CC
		public static string AutoPickupHint()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Auto pickup is ");
			bool autoPickupOn = ModInfo.AutoPickupOn;
			if (autoPickupOn)
			{
				stringBuilder.Append(ModInfo.colorBlue);
				stringBuilder.Append("on ");
				stringBuilder.Append(ModInfo.colorEnd);
			}
			else
			{
				stringBuilder.Append("off ");
			}
			stringBuilder.AppendFormat("(<color=#ADF8FFFF>{0}</color>)", Config.OutcropAutoPickupKeybindValue.ToString());
			stringBuilder.Append(" to toggle");
			stringBuilder.Append('\n');
			return stringBuilder.ToString();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00005064 File Offset: 0x00003264
		public static string HitsToBreak(BreakableResource outcrop)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('\n');
			stringBuilder.Append("Hits to break ");
			stringBuilder.Append(outcrop.hitsToBreak);
			return stringBuilder.ToString();
		}
	}
}
