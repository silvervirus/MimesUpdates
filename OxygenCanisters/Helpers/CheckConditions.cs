using System;
using System.Collections.Generic;
using OxygenCanisters.Info;
using OxygenCanisters.Modules;

namespace OxygenCanisters.Helpers
{
	// Token: 0x02000013 RID: 19
	internal class CheckConditions
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000035D8 File Offset: 0x000017D8
		public static bool CanisterChipEquipped()
		{
			bool flag = false;
			bool flag2 = Player.main != null;
			if (flag2)
			{
				Inventory main = Inventory.main;
				flag = main.equipment.GetCount(OxygenCanisterMonitorChip.TechTypeID) > 0;
			}
			return flag;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003618 File Offset: 0x00001818
		public static int OxygenCanisterInInventory()
		{
            Console.Write("Checking for installed Mods");
            EnumHandler.TryGetValue("OxygenCanister", out TechType OxygenCanister);
            Inventory main = Inventory.main;
			ModInfo.numberOfCanisters = 0;
			bool flag = main != null;
			if (flag)
			{
				Inventory component = Player.main.GetComponent<Inventory>();
				List<TechType> itemTypes = component.container.GetItemTypes();
				foreach (TechType techType in itemTypes)
				{
					bool flag2 = techType == OxygenCanister;
					if (flag2)
					{
						ModInfo.numberOfCanisters = component.container.GetItems(techType).Count;
					}
				}
			}
			return ModInfo.numberOfCanisters;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000036C8 File Offset: 0x000018C8
		public static bool PlayerTankEquipped()
		{
			return Inventory.main.equipment.GetItemInSlot("Tank") != null;
		}
	}
}
