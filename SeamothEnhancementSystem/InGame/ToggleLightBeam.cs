using System;
using SeamothEnhancementSystem.InfoObjects;
using SeamothEnhancementSystem.Patches;
using UnityEngine;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x0200003E RID: 62
	internal class ToggleLightBeam
	{
		// Token: 0x060000DE RID: 222 RVA: 0x0000ABCC File Offset: 0x00008DCC
		public static void ToggleLoHighBeam(SeaMoth thisSeamoth)
		{
			Light[] componentsInChildren = thisSeamoth.lightsParent.GetComponentsInChildren<Light>();
			bool flag = componentsInChildren != null;
			if (flag)
			{
				bool highBeamOn = Vehicle_Update_Patch.HighBeamOn;
				if (highBeamOn)
				{
					bool flag2 = !Vehicle_Update_Patch.HighBeamIsSet;
					if (flag2)
					{
						foreach (Light light in componentsInChildren)
						{
							light.spotAngle = SeamothInfo.thisLightHighSpotAngle;
							light.intensity = SeamothInfo.thisLightHighIntensity;
							light.range = SeamothInfo.thisLightHighRange;
							Vehicle_Update_Patch.SafetyBeamIsSet = false;
							Vehicle_Update_Patch.LowBeamIsSet = false;
							Vehicle_Update_Patch.HighBeamIsSet = true;
						}
					}
				}
				else
				{
					bool flag3 = !SeamothInfo.safeDepthChargerGearLightLock && !Vehicle_Update_Patch.LowBeamIsSet;
					if (flag3)
					{
						foreach (Light light2 in componentsInChildren)
						{
							light2.spotAngle = SeamothInfo.thisLightLowSpotAngle;
							light2.intensity = SeamothInfo.thisLightLowIntensity;
							light2.range = SeamothInfo.thisLightLowRange;
							Vehicle_Update_Patch.SafetyBeamIsSet = false;
							Vehicle_Update_Patch.LowBeamIsSet = true;
							Vehicle_Update_Patch.HighBeamIsSet = false;
						}
					}
					bool flag4 = SeamothInfo.safeDepthChargerGearLightLock && !Vehicle_Update_Patch.SafetyBeamIsSet;
					if (flag4)
					{
						foreach (Light light3 in componentsInChildren)
						{
							light3.spotAngle = SeamothInfo.thisLightSafetySpotAngle;
							light3.intensity = SeamothInfo.thisLightSafetyIntensity;
							light3.range = SeamothInfo.thisLightSafetyRange;
							Vehicle_Update_Patch.SafetyBeamIsSet = true;
							Vehicle_Update_Patch.LowBeamIsSet = false;
							Vehicle_Update_Patch.HighBeamIsSet = false;
						}
					}
				}
			}
		}
	}
}
