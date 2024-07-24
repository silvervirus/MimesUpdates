using System;
using Nautilus.Utility;
using UnityEngine;
using Math = System.Math;

namespace ToolsFlashLight.InGame
{
	// Token: 0x0200001C RID: 28
	internal class TuneLight
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00003E70 File Offset: 0x00002070
		public static void TuneLightBeam(Light thisLight)
		{
			float num = thisLight.transform.localEulerAngles.x;
			float num2 = thisLight.transform.localEulerAngles.y;
			float z = thisLight.transform.localEulerAngles.z;
			bool keyDown = KeyCodeUtils.GetKeyDown(KeyCode.Keypad2);
			if (keyDown)
			{
				num += 1f;
			}
			bool keyDown2 = KeyCodeUtils.GetKeyDown(KeyCode.Keypad8);
			if (keyDown2)
			{
				num -= 1f;
			}
			bool keyDown3 = KeyCodeUtils.GetKeyDown(KeyCode.Keypad6);
			if (keyDown3)
			{
				num2 += 1f;
			}
			bool keyDown4 = KeyCodeUtils.GetKeyDown(KeyCode.Keypad4);
			if (keyDown4)
			{
				num2 -= 1f;
			}
			thisLight.transform.localRotation = Quaternion.Euler((float)Math.Round((double)num), (float)Math.Round((double)num2), (float)Math.Round((double)z));
		}
	}
}
