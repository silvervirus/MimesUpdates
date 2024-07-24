using System;
using System.Collections.Generic;
using System.Linq;

namespace OxygenTankMonitor.Helpers
{
	// Token: 0x02000017 RID: 23
	internal class TankList
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00006074 File Offset: 0x00004274
		public static List<Oxygen> GetTankList()
		{
			List<InventoryItem> items = new List<InventoryItem>();
			Inventory.main.container.GetItemTypes().ForEach(delegate(TechType type)
			{
				items.AddRange(Inventory.main.container.GetItems(type));
			});
			return (from item in items
				where item.item.gameObject.GetComponent<Oxygen>() != null
				select item.item.gameObject.GetComponent<Oxygen>()).ToList<Oxygen>();
		}
	}
}
