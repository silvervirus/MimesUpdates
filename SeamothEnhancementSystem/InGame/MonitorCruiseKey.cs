using System;
using SeamothEnhancementSystem.Configuration;
using SeamothEnhancementSystem.InfoObjects;
using Nautilus.Utility;
using UnityEngine;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x02000036 RID: 54
	internal class MonitorCruiseKey
	{
		// Token: 0x060000CE RID: 206 RVA: 0x0000A770 File Offset: 0x00008970
		public static void MonitorCruiseKeyDown()
		{
			bool flag = KeyCodeUtils.GetKeyDown(KeyCode.W) || KeyCodeUtils.GetKeyDown(KeyCode.S) || KeyCodeUtils.GetKeyDown(KeyCode.E);
			if (flag)
			{
				SeamothInfo.CruiseControlOn = false;
			}
			bool flag2 = KeyCodeUtils.GetKeyDown(Config.CruiseKeybindValue) && !SeamothInfo.safeEjectActive;
			if (flag2)
			{
				bool cruiseControlOn = SeamothInfo.CruiseControlOn;
				if (cruiseControlOn)
				{
					SeamothInfo.CruiseControlOn = false;
				}
				else
				{
					SeamothInfo.CruiseControlOn = true;
				}
			}
		}
	}
}
