using System;
using ToolsFlashLight.InfoObjects;
using UnityEngine;

namespace ToolsFlashLight.InGame
{
	// Token: 0x0200001D RID: 29
	internal class UpdateLightIntensity
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00003F44 File Offset: 0x00002144
		public static void UpdateLightIntensityLED(Light thisLight, bool increaseValues)
		{
			if (increaseValues)
			{
				bool flag = thisLight.range < ModInfo.lightRangeTop;
				if (flag)
				{
					thisLight.range += ModInfo.rangeDelta;
				}
				bool flag2 = thisLight.intensity < ModInfo.lightIntensityTop;
				if (flag2)
				{
					thisLight.intensity += ModInfo.intensDelta;
				}
				bool flag3 = thisLight.spotAngle > ModInfo.lightSpotAngleFar;
				if (flag3)
				{
					thisLight.spotAngle -= ModInfo.spotAngleDelta;
				}
				bool flag4 = thisLight.innerSpotAngle > ModInfo.lightInnerSpotAngleFar;
				if (flag4)
				{
					thisLight.innerSpotAngle -= ModInfo.innerSpotAngleDelta;
				}
			}
			else
			{
				bool flag5 = thisLight.range > ModInfo.lightRange;
				if (flag5)
				{
					thisLight.range -= ModInfo.rangeDelta;
				}
				bool flag6 = thisLight.intensity > ModInfo.lightIntensity;
				if (flag6)
				{
					thisLight.intensity -= ModInfo.intensDelta;
				}
				bool flag7 = thisLight.spotAngle < ModInfo.lightSpotAngle;
				if (flag7)
				{
					thisLight.spotAngle += ModInfo.spotAngleDelta;
				}
				bool flag8 = thisLight.innerSpotAngle < ModInfo.lightInnerSpotAngle;
				if (flag8)
				{
					thisLight.innerSpotAngle += ModInfo.innerSpotAngleDelta;
				}
			}
		}
	}
}
