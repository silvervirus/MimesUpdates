using System;
using OxygenAudioMonitor.Modules;

namespace OxygenAudioMonitor.Helpers
{
	// Token: 0x0200000C RID: 12
	internal class CheckConditions
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002FA4 File Offset: 0x000011A4
		public static bool AudioChipEquipped()
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				Inventory main = Inventory.main;
				flag = main.equipment.GetCount(OxygenAudioMonitorChip.TechTypeID) > 0;
			}
			return flag;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002FE4 File Offset: 0x000011E4
		public static bool PlayerTankEquipped()
		{
			return Inventory.main.equipment.GetItemInSlot("Tank") != null;
		}
	}
}
