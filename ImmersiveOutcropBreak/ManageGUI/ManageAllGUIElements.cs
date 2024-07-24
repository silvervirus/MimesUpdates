using System;
using ImmersiveOutcropBreak.Configuration;
using ImmersiveOutcropBreak.Helpers;
using ImmersiveOutcropBreak.Info;
using UnityEngine;

namespace ImmersiveOutcropBreak.ManageGUI
{
	// Token: 0x02000010 RID: 16
	internal static class ManageAllGUIElements
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00003878 File Offset: 0x00001A78
		internal static void ManageAllUI()
		{
			ModInfo.NumberOfPulses = 0;
			bool pulseOnNow = ModInfo.PulseOnNow;
			if (pulseOnNow)
			{
				bool flag = CheckConditions.LoTechGloveChipEquipped();
				if (flag)
				{
					ModInfo.NumberOfPulses = 1;
				}
				bool flag2 = CheckConditions.MidTechGloveChipEquipped();
				if (flag2)
				{
					ModInfo.NumberOfPulses = 2;
				}
				bool flag3 = CheckConditions.HiTechGloveChipEquipped();
				if (flag3)
				{
					ModInfo.NumberOfPulses = 3;
				}
				bool flag4 = !ModInfo.ShowPulses || Player.main.IsPiloting() || HandReticle.main.CurrentIconType == HandReticle.IconType.None || !CheckConditions.AnyOutcropGlovesOn();
				if (flag4)
				{
					ModInfo.NumberOfPulses = 0;
				}
			}
			switch (ModInfo.NumberOfPulses)
			{
			case 1:
				ManageAllGUIElements.PulseSmallUI();
				break;
			case 2:
				ManageAllGUIElements.PulseMediumUI();
				break;
			case 3:
				ManageAllGUIElements.PulseLargeUI();
				break;
			default:
				ManageAllGUIElements.TurnPulseUIOff();
				break;
			}
			bool flag5 = CheckConditions.PlayerAdvancedGlovesEquipped() && CheckConditions.HiTechGloveChipEquipped();
			if (flag5)
			{
				bool flag6 = Player.main.IsPiloting() || Player.main.GetPDA().isInUse || IngameMenu.main.focused || FPSInputModule.current.lockMovement || HandReticle.main.CurrentIconType == HandReticle.IconType.None;
				if (flag6)
				{
					ManageAllGUIElements.TurnPickupUIOff();
					ManageAllGUIElements.TurnBreakUIOff();
				}
				else
				{
					bool flag7 = ModInfo.AutoPickupOn && Config.AutoPickupGUIToggleValue;
					if (flag7)
					{
						ManageAllGUIElements.PickupOnUI();
					}
					else
					{
						bool flag8 = !ModInfo.AutoPickupOn && Config.AutoPickupGUIToggleValue;
						if (flag8)
						{
							ManageAllGUIElements.PickupOffUI();
						}
						else
						{
							ManageAllGUIElements.TurnPickupUIOff();
						}
					}
					bool autoBreakGUIToggleValue = Config.AutoBreakGUIToggleValue;
					if (autoBreakGUIToggleValue)
					{
						bool flag9 = ModInfo.AutoBreakNow && ModInfo.PulseOnNow;
						if (flag9)
						{
							ManageAllGUIElements.BreakOnUI();
						}
						else
						{
							bool flag10 = !ModInfo.AutoBreakNow || !ModInfo.PulseOnNow;
							if (flag10)
							{
								ManageAllGUIElements.BreakOffUI();
							}
							else
							{
								ManageAllGUIElements.TurnBreakUIOff();
							}
						}
					}
					else
					{
						ManageAllGUIElements.TurnBreakUIOff();
					}
				}
			}
			else
			{
				bool flag11 = (CheckConditions.PlayerGlovesEquipped() || CheckConditions.ToolIsReady()) && CheckConditions.AnyGloveChipEquipped();
				if (flag11)
				{
					ManageAllGUIElements.BreakOffUI();
				}
				else
				{
					ManageAllGUIElements.TurnPickupUIOff();
					ManageAllGUIElements.TurnBreakUIOff();
				}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003A84 File Offset: 0x00001C84
		internal static void PulseSmallUI()
		{
			bool flag = ManageAllGUIElements.PulseSmallUIGameObj != null;
			if (flag)
			{
				ManageAllGUIElements.PulseSmallUIGameObj.SetActive(true);
			}
			bool flag2 = ManageAllGUIElements.PulseMediumUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.PulseMediumUIGameObj.SetActive(false);
			}
			bool flag3 = ManageAllGUIElements.PulseLargeUIGameObj != null;
			if (flag3)
			{
				ManageAllGUIElements.PulseLargeUIGameObj.SetActive(false);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003AE4 File Offset: 0x00001CE4
		internal static void PulseMediumUI()
		{
			bool flag = ManageAllGUIElements.PulseSmallUIGameObj != null;
			if (flag)
			{
				ManageAllGUIElements.PulseSmallUIGameObj.SetActive(true);
			}
			bool flag2 = ManageAllGUIElements.PulseMediumUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.PulseMediumUIGameObj.SetActive(true);
			}
			bool flag3 = ManageAllGUIElements.PulseLargeUIGameObj != null;
			if (flag3)
			{
				ManageAllGUIElements.PulseLargeUIGameObj.SetActive(false);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003B44 File Offset: 0x00001D44
		internal static void PulseLargeUI()
		{
			bool flag = ManageAllGUIElements.PulseSmallUIGameObj != null;
			if (flag)
			{
				ManageAllGUIElements.PulseSmallUIGameObj.SetActive(true);
			}
			bool flag2 = ManageAllGUIElements.PulseMediumUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.PulseMediumUIGameObj.SetActive(true);
			}
			bool flag3 = ManageAllGUIElements.PulseLargeUIGameObj != null;
			if (flag3)
			{
				ManageAllGUIElements.PulseLargeUIGameObj.SetActive(true);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003BA4 File Offset: 0x00001DA4
		internal static void TurnPulseUIOff()
		{
			bool flag = ManageAllGUIElements.PulseSmallUIGameObj != null;
			if (flag)
			{
				ManageAllGUIElements.PulseSmallUIGameObj.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.PulseMediumUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.PulseMediumUIGameObj.SetActive(false);
			}
			bool flag3 = ManageAllGUIElements.PulseLargeUIGameObj != null;
			if (flag3)
			{
				ManageAllGUIElements.PulseLargeUIGameObj.SetActive(false);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003C04 File Offset: 0x00001E04
		internal static void PickupOnUI()
		{
			bool flag = ManageAllGUIElements.PickupOnUIGameObj != null;
			if (flag)
			{
				ManageAllGUIElements.PickupOnUIGameObj.SetActive(true);
			}
			bool flag2 = ManageAllGUIElements.PickupOffUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.PickupOffUIGameObj.SetActive(false);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003C48 File Offset: 0x00001E48
		internal static void PickupOffUI()
		{
			bool flag = ManageAllGUIElements.PickupOnUIGameObj != null;
			if (flag)
			{
				ManageAllGUIElements.PickupOnUIGameObj.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.PickupOffUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.PickupOffUIGameObj.SetActive(true);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003C8C File Offset: 0x00001E8C
		internal static void TurnPickupUIOff()
		{
			bool flag = ManageAllGUIElements.PickupOnUIGameObj != null;
			if (flag)
			{
				ManageAllGUIElements.PickupOnUIGameObj.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.PickupOffUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.PickupOffUIGameObj.SetActive(false);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003CD0 File Offset: 0x00001ED0
		internal static void BreakOnUI()
		{
			bool flag = ManageAllGUIElements.BreakOnUIGameObj != null;
			if (flag)
			{
				ManageAllGUIElements.BreakOnUIGameObj.SetActive(true);
			}
			bool flag2 = ManageAllGUIElements.BreakOffUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.BreakOffUIGameObj.SetActive(false);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003D14 File Offset: 0x00001F14
		internal static void BreakOffUI()
		{
			bool flag = ManageAllGUIElements.BreakOnUIGameObj != null;
			if (flag)
			{
				ManageAllGUIElements.BreakOnUIGameObj.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.BreakOffUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.BreakOffUIGameObj.SetActive(true);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003D58 File Offset: 0x00001F58
		internal static void TurnBreakUIOff()
		{
			bool flag = ManageAllGUIElements.BreakOnUIGameObj != null;
			if (flag)
			{
				ManageAllGUIElements.BreakOnUIGameObj.SetActive(false);
			}
			bool flag2 = ManageAllGUIElements.BreakOffUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.BreakOffUIGameObj.SetActive(false);
			}
		}

		// Token: 0x04000011 RID: 17
		public static GameObject gameObject = GameObject.Find("HUD");

		// Token: 0x04000012 RID: 18
		public static GameObject PulseSmallUIGameObj = GameObject.Find("PulseSmallUI");

		// Token: 0x04000013 RID: 19
		public static GameObject PulseMediumUIGameObj = GameObject.Find("PulseMediumUI");

		// Token: 0x04000014 RID: 20
		public static GameObject PulseLargeUIGameObj = GameObject.Find("PulseLargeUI");

		// Token: 0x04000015 RID: 21
		public static GameObject PickupOnUIGameObj = GameObject.Find("PickupOnUI");

		// Token: 0x04000016 RID: 22
		public static GameObject PickupOffUIGameObj = GameObject.Find("PickupOffUI");

		// Token: 0x04000017 RID: 23
		public static GameObject BreakOnUIGameObj = GameObject.Find("BreakOnUI");

		// Token: 0x04000018 RID: 24
		public static GameObject BreakOffUIGameObj = GameObject.Find("BreakOffUI");
	}
}
