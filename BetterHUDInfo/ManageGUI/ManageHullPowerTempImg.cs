using System;
using BetterHUDInfo.Configuration;
using BetterHUDInfo.InfoObjects;
using HarmonyLib;
using UnityEngine;

namespace BetterHUDInfo.ManageGUI
{
	// Token: 0x02000020 RID: 32
	internal class ManageHullPowerTempImg
	{
		// Token: 0x06000051 RID: 81 RVA: 0x000062B4 File Offset: 0x000044B4
		internal static void ManageHullPowerTemp(GameObject HullPowerTempObj, float HullPowerTemp_H, float HullPowerTemp_V)
		{
			Player main = Player.main;
			bool flag = main != null && Config.ShowHullPowerTempToggleValue && ModInfo.PlayerIsFree && ModInfo.ChipInserted;
			if (flag)
			{
				ManageAllGUIElements.TemperDescTextObject.SetActive(true);
			}
			else
			{
				ManageAllGUIElements.TemperDescTextObject.SetActive(false);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006308 File Offset: 0x00004508
		internal static void ManageScanDot(GameObject thisScanDotObject, GameObject thisScanTargetObject)
		{
			Player main = Player.main;
			HandReticle.IconType value = Traverse.Create(HandReticle.main).Field("iconType").GetValue<HandReticle.IconType>();
			bool flag = main != null && Config.ShowHullPowerTempToggleValue && !main.IsInside() && !Player.main.GetPDA().isInUse && value == HandReticle.IconType.Default && ModInfo.ScannerIsOn;
			if (flag)
			{
				float num = 0.05f;
				float num2 = 2f;
				float num3 = -40f;
				float num4 = num3 * -1f;
				ModInfo.timer += Time.deltaTime;
				bool flag2 = ModInfo.timer >= num;
				if (flag2)
				{
					bool flag3 = !ModInfo.StopAtZero || ModInfo.TotalRotation != 0f;
					if (flag3)
					{
						bool flag4 = ModInfo.TotalRotation <= num3;
						if (flag4)
						{
							ModInfo.MoveToRight = false;
						}
						bool flag5 = ModInfo.TotalRotation >= num4;
						if (flag5)
						{
							ModInfo.MoveToRight = true;
						}
						bool moveToRight = ModInfo.MoveToRight;
						if (moveToRight)
						{
							thisScanDotObject.transform.Rotate(new Vector3(0f, 0f, num2 * -1f));
							ModInfo.TotalRotation -= num2;
						}
						else
						{
							thisScanDotObject.transform.Rotate(new Vector3(0f, 0f, num2));
							ModInfo.TotalRotation += num2;
						}
					}
					else
					{
						bool flag6 = !ModInfo.ObjectLock;
						if (flag6)
						{
							Utils.PlayEnvSound(ModInfo.lightsOnSound, ModInfo.lightsOnSound.gameObject.transform.position, 20f);
						}
						ModInfo.ObjectLock = true;
					}
					ModInfo.timer = 0f;
					thisScanDotObject.SetActive(true);
				}
			}
			else
			{
				thisScanDotObject.SetActive(false);
				thisScanTargetObject.SetActive(false);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000064DC File Offset: 0x000046DC
		internal static void ManageLockBeam(GameObject thisLockBeamObj)
		{
			Player main = Player.main;
			bool flag = main != null && Config.ShowLockBeamToggleValue && ModInfo.ScannerIsOn && ModInfo.ObjectLock;
			if (flag)
			{
				thisLockBeamObj.SetActive(true);
			}
			else
			{
				thisLockBeamObj.SetActive(false);
			}
		}
	}
}
