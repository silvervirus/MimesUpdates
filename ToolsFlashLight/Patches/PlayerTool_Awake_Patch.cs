using System;
using HarmonyLib;
using ToolsFlashLight.InfoObjects;
using UnityEngine;

namespace ToolsFlashLight.Patches
{
	// Token: 0x0200000C RID: 12
	[HarmonyPatch(typeof(PlayerTool))]
	[HarmonyPatch("Awake")]
	internal class PlayerTool_Awake_Patch
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000028D0 File Offset: 0x00000AD0
		[HarmonyPostfix]
		public static void Postfix(PlayerTool __instance)
		{
			bool flag = __instance.GetComponent<BuilderTool>() != null;
			if (flag)
			{
				PlayerTool_Awake_Patch.AddSpotight(__instance, 0f, 27f, 0f, Color.white);
			}
			else
			{
				bool flag2 = __instance.GetComponent<LaserCutter>() != null;
				if (flag2)
				{
					PlayerTool_Awake_Patch.AddSpotight(__instance, 2f, 0f, 0f, Color.white);
				}
				else
				{
					bool flag3 = __instance.GetComponent<Welder>() != null;
					if (flag3)
					{
						PlayerTool_Awake_Patch.AddSpotight(__instance, 0f, 0f, 0f, Color.white);
					}
					else
					{
						bool flag4 = __instance.GetComponent<ScannerTool>() != null;
						if (flag4)
						{
							PlayerTool_Awake_Patch.AddSpotight(__instance, 345f, 270f, 0f, Color.white);
						}
					}
				}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002994 File Offset: 0x00000B94
		public static void AddSpotight(PlayerTool __instance, float x, float y, float z, Color thisColor)
		{
			GameObject gameObject = new GameObject("LEDSpotlight");
			gameObject.transform.SetParent(__instance.transform, false);
			gameObject.transform.localRotation = Quaternion.Euler(x, y, z);
			bool flag = __instance.GetComponent<LaserCutter>() != null;
			if (flag)
			{
				gameObject.transform.localPosition = new Vector3(0f, 0f, 0.3f);
			}
			Light light = gameObject.EnsureComponent<Light>();
			light.type = LightType.Spot;
			light.color = thisColor;
			light.spotAngle = ModInfo.lightSpotAngle;
			light.innerSpotAngle = ModInfo.lightInnerSpotAngle;
			light.range = ModInfo.lightRange;
			light.intensity = ModInfo.lightIntensity;
			light.shadows = LightShadows.Hard;
			bool lightTesting = ModInfo.lightTesting;
			if (lightTesting)
			{
				light.enabled = true;
			}
			else
			{
				light.enabled = false;
			}
		}
	}
}
