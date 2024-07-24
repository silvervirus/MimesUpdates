using System;
using System.Text;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using BetterHUDInfo.ManageGUI;
using UnityEngine;

namespace BetterHUDInfo.Helpers
{
	// Token: 0x0200002B RID: 43
	internal class HullState
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00006EA4 File Offset: 0x000050A4
		public static string ProcessBaseHull(float thisStrength)
		{
			string text = ModInfo.colorWhite;
			bool flag = thisStrength <= Mathf.Floor(Config.HullLowerLimitSliderValue);
			if (flag)
			{
				text = ModInfo.colorRed;
			}
			else
			{
				bool flag2 = thisStrength > Mathf.Floor(Config.HullLowerLimitSliderValue) && thisStrength <= Mathf.Floor(Config.HullUpperLimitSliderValue);
				if (flag2)
				{
					text = ModInfo.colorYellow;
				}
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<size=" + (ModInfo.FontPlus + Config.FontSizeSliderValue).ToString() + ">");
			stringBuilder.Append(text);
			stringBuilder.Append(thisStrength.ToString());
			stringBuilder.Append(ModInfo.colorEnd);
			stringBuilder.Append("</size>");
			return stringBuilder.ToString();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00006F68 File Offset: 0x00005168
		public static string ProcessVCHull(float thisStrength)
		{
			string text = ModInfo.colorWhite;
			bool flag = thisStrength * 100f <= 33f;
			if (flag)
			{
				text = ModInfo.colorRed;
			}
			else
			{
				bool flag2 = thisStrength * 100f > 33f && thisStrength * 100f <= 66f;
				if (flag2)
				{
					text = ModInfo.colorYellow;
				}
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<size=" + (ModInfo.FontPlus + Config.FontSizeSliderValue).ToString() + ">");
			stringBuilder.Append(text);
			stringBuilder.Append(Mathf.RoundToInt(thisStrength * 100f).ToString());
			stringBuilder.Append(ModInfo.colorEnd);
			stringBuilder.Append("</size>");
			stringBuilder.Append("<size=" + Config.FontSizeSliderValue.ToString() + ">");
			stringBuilder.Append(ModInfo.colorYellow + "%" + ModInfo.colorEnd);
			stringBuilder.Append("</size>");
			return stringBuilder.ToString();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007084 File Offset: 0x00005284
		public static string ItemHullState()
		{
			string text = "-";
			string colorWhite = ModInfo.colorWhite;
			Targeting.AddToIgnoreList(Player.main.gameObject);
			GameObject gameObject;
			float num;
			Targeting.GetTarget(10f, out gameObject, out num);
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = gameObject != null && ModInfo.ScannerIsOn;
			string text2;
			if (flag)
			{
				Base componentInParent = gameObject.GetComponentInParent<Base>();
				SubRoot componentInParent2 = gameObject.GetComponentInParent<SubRoot>();
				Vehicle componentInParent3 = gameObject.GetComponentInParent<Vehicle>();
				bool flag2 = componentInParent != null && ModInfo.ObjectLock;
				if (flag2)
				{
					BaseHullStrength component = componentInParent.GetComponent<BaseHullStrength>();
					float num2 = (float)Mathf.RoundToInt(component.GetTotalStrength());
					text = HullState.ProcessBaseHull(num2);
					ModInfo.TargetName = "TARGET: BASE";
				}
				else
				{
					bool flag3 = componentInParent2 != null && ModInfo.ObjectLock;
					if (flag3)
					{
						LiveMixin component2 = componentInParent2.GetComponent<LiveMixin>();
						float num2 = component2.GetHealthFraction();
						text = HullState.ProcessVCHull(num2);
						bool flag4 = componentInParent2.GetSubName() == "";
						if (flag4)
						{
							ModInfo.TargetName = "TARGET: CYCLOPS";
						}
						else
						{
							ModInfo.TargetName = "TARGET: " + componentInParent2.GetSubName().ToUpper();
						}
					}
					else
					{
						bool flag5 = componentInParent3 != null && ModInfo.ObjectLock;
						if (flag5)
						{
							LiveMixin component3 = componentInParent3.GetComponent<LiveMixin>();
							float num2 = component3.GetHealthFraction();
							text = HullState.ProcessVCHull(num2);
							bool flag6 = componentInParent3.GetName() == "";
							if (flag6)
							{
								bool flag7 = componentInParent3 is SeaMoth;
								if (flag7)
								{
									ModInfo.TargetName = "TARGET: SEAMOTH";
								}
								else
								{
									ModInfo.TargetName = "TARGET: EXOSUIT";
								}
							}
							else
							{
								ModInfo.TargetName = "TARGET: " + componentInParent3.GetName().ToUpper();
							}
						}
						else
						{
							ModInfo.TargetName = "TARGET: NO LINK";
							text = "-";
						}
					}
				}
				bool flag8 = ManageAllGUIElements.ScanTargetUIGameObj != null;
				if (flag8)
				{
					bool flag9 = !Player.main.IsInside() && !Player.main.GetPDA().isInUse;
					if (flag9)
					{
						bool flag10 = componentInParent != null || componentInParent2 != null || componentInParent3 != null;
						if (flag10)
						{
							ModInfo.StopAtZero = true;
							ManageAllGUIElements.ScanTargetUIGameObj.SetActive(true);
						}
					}
					else
					{
						bool objectLock = ModInfo.ObjectLock;
						if (objectLock)
						{
							Utils.PlayEnvSound(ModInfo.lightsOffSound, ModInfo.lightsOffSound.gameObject.transform.position, 20f);
						}
						ManageAllGUIElements.ScanTargetUIGameObj.SetActive(false);
						ModInfo.StopAtZero = false;
						ModInfo.ObjectLock = false;
					}
				}
				stringBuilder.Append(text);
				text2 = stringBuilder.ToString();
			}
			else
			{
				bool flag11 = ManageAllGUIElements.ScanTargetUIGameObj != null;
				if (flag11)
				{
					bool objectLock2 = ModInfo.ObjectLock;
					if (objectLock2)
					{
						Utils.PlayEnvSound(ModInfo.lightsOffSound, ModInfo.lightsOffSound.gameObject.transform.position, 20f);
					}
					ManageAllGUIElements.ScanTargetUIGameObj.SetActive(false);
					ModInfo.StopAtZero = false;
					ModInfo.ObjectLock = false;
					ModInfo.TargetName = "";
				}
				text2 = text;
			}
			return text2;
		}
	}
}
