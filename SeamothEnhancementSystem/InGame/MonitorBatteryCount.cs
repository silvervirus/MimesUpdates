using System;
using System.Collections.Generic;
using SeamothEnhancementSystem.InfoObjects;
using UnityEngine;

namespace SeamothEnhancementSystem.InGame
{
	// Token: 0x02000035 RID: 53
	internal class MonitorBatteryCount
	{
		// Token: 0x060000CC RID: 204 RVA: 0x0000A6B0 File Offset: 0x000088B0
		public static void MonitorSeamothBatteryCount(SeaMoth thisSeaMoth)
		{
			EnergyMixin component = thisSeaMoth.gameObject.GetComponent<EnergyMixin>();
			bool flag = component != null;
			if (flag)
			{
                IBattery battery = component.GetBattery();
                GameObject batteryGameObject = ((MonoBehaviour)battery).gameObject;
                bool flag2 = battery != null;
				if (flag2)
				{
					SeamothInfo.BatteryInSlot = 1;
				}
				else
				{
					SeamothInfo.BatteryInSlot = 0;
				}
			}
			SeamothInfo.MainBatteryCount = 0;
			foreach (InventoryItem inventoryItem in ((IEnumerable<InventoryItem>)Inventory.main.container))
			{
				bool flag3 = component.Filter(inventoryItem);
				if (flag3)
				{
					SeamothInfo.MainBatteryCount++;
				}
			}
			SeamothInfo.TotalBatteryCount = SeamothInfo.BatteryInSlot + SeamothInfo.MainBatteryCount;
		}
	}
}
