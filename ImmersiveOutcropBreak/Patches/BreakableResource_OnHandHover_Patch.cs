using System;
using System.Text;
using HarmonyLib;
using ImmersiveOutcropBreak.Configuration;
using ImmersiveOutcropBreak.Helpers;
using ImmersiveOutcropBreak.Info;
using ImmersiveOutcropBreak.InGame;

namespace ImmersiveOutcropBreak.Patches
{
	// Token: 0x02000004 RID: 4
	[HarmonyPatch(typeof(BreakableResource))]
	[HarmonyPatch("OnHandHover")]
	internal class BreakableResource_OnHandHover_Patch
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000237C File Offset: 0x0000057C
		[HarmonyPrefix]
		public static bool Prefix(BreakableResource __instance)
		{
			int firstPulseDelaySliderValue = Config.FirstPulseDelaySliderValue;
			int pulseIncrementDelaySliderValue = Config.PulseIncrementDelaySliderValue;
			int num = firstPulseDelaySliderValue + pulseIncrementDelaySliderValue;
			int num2 = firstPulseDelaySliderValue + pulseIncrementDelaySliderValue * 2;
			int num3 = num;
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = CheckConditions.HiTechGloveChipEquipped();
			bool flag6;
			if (flag)
			{
				bool flag2 = !ModInfo.FirstRunDone && !ModInfo.PickupFreshItem && ModInfo.PulseOnNow && CheckConditions.AnyOutcropGlovesOn();
				if (flag2)
				{
					bool flag3 = __instance.hitsToBreak > 2;
					if (flag3)
					{
						BreakOutcrop.BreakOutcropDelay(__instance, firstPulseDelaySliderValue, true);
						BreakOutcrop.BreakOutcropDelay(__instance, num, true);
						num3 = num2;
					}
					else
					{
						bool flag4 = __instance.hitsToBreak > 1;
						if (flag4)
						{
							BreakOutcrop.BreakOutcropDelay(__instance, firstPulseDelaySliderValue, true);
							num3 = num;
						}
					}
				}
				bool flag5 = CheckConditions.PlayerAdvancedGlovesEquipped() && ModInfo.AutoBreakNow && !ModInfo.FirstRunDone && !ModInfo.PickupFreshItem && ModInfo.PulseOnNow;
				if (flag5)
				{
					BreakOutcrop.BreakOutcropDelay(__instance, num3, true);
					ModInfo.FirstRunDone = true;
					flag6 = true;
				}
				else
				{
					bool flag7 = CheckConditions.PlayerGlovesEquipped();
					if (flag7)
					{
						bool flag8 = CheckConditions.GetInventoryInfo("Space") == 0;
						string text;
						if (flag8)
						{
							stringBuilder.Append(FormatText.InventoryHiTechFull());
							stringBuilder.Append(FormatText.HitsToBreak(__instance));
							text = stringBuilder.ToString();
						}
						else
						{
							stringBuilder.Append(FormatText.InventoryHiTechSpace());
							stringBuilder.Append(FormatText.HitsToBreak(__instance));
							text = stringBuilder.ToString();
						}
						
                        HandReticle.main.SetText(HandReticle.TextType.Hand,__instance.breakText + text, true, GameInput.Button.LeftHand);
                        HandReticle.main.SetText(HandReticle.TextType.HandSubscript, text, true, GameInput.Button.LeftHand);
                        HandReticle.main.SetIcon(HandReticle.IconType.Hand, 1f);
						ModInfo.FirstRunDone = true;
						flag6 = false;
					}
					else
					{
						stringBuilder.Append(FormatText.NoGlovesAdvanced());
						string text = stringBuilder.ToString();
                        HandReticle.main.SetText(HandReticle.TextType.Hand, __instance.breakText + text, true, GameInput.Button.PDA);
                        HandReticle.main.SetText(HandReticle.TextType.HandSubscript, text, true, GameInput.Button.LeftHand);
                        HandReticle.main.SetIcon(HandReticle.IconType.Default, 1f);
						ModInfo.FirstRunDone = true;
						flag6 = false;
					}
				}
			}
			else
			{
				bool flag9 = CheckConditions.MidTechGloveChipEquipped();
				if (flag9)
				{
					bool flag10 = !ModInfo.FirstRunDone && !ModInfo.PickupFreshItem && ModInfo.PulseOnNow && CheckConditions.AnyOutcropGlovesOn();
					if (flag10)
					{
						bool flag11 = __instance.hitsToBreak > 2;
						if (flag11)
						{
							BreakOutcrop.BreakOutcropDelay(__instance, firstPulseDelaySliderValue, true);
							BreakOutcrop.BreakOutcropDelay(__instance, num, true);
						}
						else
						{
							bool flag12 = __instance.hitsToBreak > 1;
							if (flag12)
							{
								BreakOutcrop.BreakOutcropDelay(__instance, firstPulseDelaySliderValue, true);
							}
						}
					}
					bool flag13 = CheckConditions.PlayerGlovesEquipped();
					if (flag13)
					{
						bool flag14 = CheckConditions.GetInventoryInfo("Space") == 0;
						string text;
						if (flag14)
						{
							stringBuilder.Append(FormatText.InventoryMidTechFull());
							stringBuilder.Append(FormatText.HitsToBreak(__instance));
							text = stringBuilder.ToString();
						}
						else
						{
							stringBuilder.Append(FormatText.InventoryMidTechSpace());
							stringBuilder.Append(FormatText.HitsToBreak(__instance));
							text = stringBuilder.ToString();
						}
                        HandReticle.main.SetText(HandReticle.TextType.Hand, __instance.breakText + text, true, GameInput.Button.LeftHand); HandReticle.main.SetIcon(HandReticle.IconType.Hand, 1f);
						ModInfo.FirstRunDone = true;
						flag6 = false;
					}
					else
					{
						stringBuilder.Append(FormatText.NoGlovesStandard());
						string text = stringBuilder.ToString();
                        HandReticle.main.SetText(HandReticle.TextType.Hand, __instance.breakText + text, true, GameInput.Button.LeftHand);
                        HandReticle.main.SetText(HandReticle.TextType.HandSubscript, text, true, GameInput.Button.LeftHand);
                        HandReticle.main.SetIcon(HandReticle.IconType.Default, 1f);
						ModInfo.FirstRunDone = true;
						flag6 = false;
					}
				}
				else
				{
					bool flag15 = CheckConditions.LoTechGloveChipEquipped();
					if (flag15)
					{
						bool flag16 = !ModInfo.FirstRunDone && !ModInfo.PickupFreshItem && ModInfo.PulseOnNow && CheckConditions.AnyOutcropGlovesOn();
						if (flag16)
						{
							bool flag17 = __instance.hitsToBreak > 1;
							if (flag17)
							{
								BreakOutcrop.BreakOutcropDelay(__instance, firstPulseDelaySliderValue, true);
							}
							ModInfo.FirstRunDone = true;
						}
						bool flag18 = CheckConditions.PlayerGlovesEquipped();
						if (flag18)
						{
							bool flag19 = CheckConditions.GetInventoryInfo("Space") == 0;
							string text;
							if (flag19)
							{
								stringBuilder.Append(FormatText.InventoryLoTechFull());
								stringBuilder.Append(FormatText.HitsToBreak(__instance));
								text = stringBuilder.ToString();
							}
							else
							{
								stringBuilder.Append(FormatText.InventoryLoTechSpace());
								stringBuilder.Append(FormatText.HitsToBreak(__instance));
								text = stringBuilder.ToString();
							}
                            HandReticle.main.SetText(HandReticle.TextType.Hand, __instance.breakText, true, GameInput.Button.LeftHand);
                            HandReticle.main.SetText(HandReticle.TextType.HandSubscript, text, true, GameInput.Button.LeftHand);
                            HandReticle.main.SetIcon(HandReticle.IconType.Hand, 1f);
							ModInfo.FirstRunDone = true;
							flag6 = false;
						}
						else
						{
							stringBuilder.Append(FormatText.NoGlovesBasic());
							string text = stringBuilder.ToString();
                            HandReticle.main.SetText(HandReticle.TextType.Hand, __instance.breakText, true, GameInput.Button.LeftHand);
                            HandReticle.main.SetText(HandReticle.TextType.HandSubscript, text, true, GameInput.Button.LeftHand);
                            HandReticle.main.SetIcon(HandReticle.IconType.Default, 1f);
							ModInfo.FirstRunDone = true;
							flag6 = false;
						}
					}
					else
					{
						bool flag20 = CheckConditions.PlayerGlovesEquipped() || CheckConditions.ToolIsReady();
						if (flag20)
						{
							ModInfo.FirstRunDone = true;
							flag6 = true;
						}
						else
						{
							HandReticle.main.SetTextRaw(HandReticle.TextType.Hand,"Breakable outcrop Gloves or tools are needed to break outcrops");
							HandReticle.main.SetIcon(HandReticle.IconType.Default, 1f);
							ModInfo.FirstRunDone = true;
							flag6 = false;
						}
					}
				}
			}
			return flag6;
		}
	}
}
