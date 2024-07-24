using System;
using SeamothEnhancementSystem.InfoObjects;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x0200003C RID: 60
	internal class MonitorReloadKey
	{
		// Token: 0x060000DA RID: 218 RVA: 0x0000AAA4 File Offset: 0x00008CA4
		public static void MonitorReloadKeyDown(SeaMoth thisSeaMoth)
		{
			bool buttonDown = GameInput.GetButtonDown(GameInput.Button.Reload);
			if (buttonDown)
			{
				bool flag = Player.main.GetVehicle() is SeaMoth;
				if (flag)
				{
					EnergyMixin component = thisSeaMoth.gameObject.GetComponent<EnergyMixin>();
					bool flag2 = component != null;
					if (flag2)
					{
						component.InitiateReload();
					}
				}
				SeamothInfo.preventLightToggle = true;
			}
		}
	}
}
