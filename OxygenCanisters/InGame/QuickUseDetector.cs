using System;
using System.Linq;
using HarmonyLib;
using OxygenCanisters.Info;
using OxygenCanisters.Modules;
using UnityEngine;

namespace OxygenCanisters.InGame
{
	// Token: 0x02000011 RID: 17
	internal class QuickUseDetector : MonoBehaviour
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003348 File Offset: 0x00001548
		public ItemsContainer itemsContainer
		{
			get
			{
				return Inventory.main.container;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003364 File Offset: 0x00001564
		public void Update()
		{
			bool runConsumption = ModInfo.runConsumption;
			if (runConsumption)
			{
				GameModeOption value = Traverse.Create(Player.main).Field("currentGameMode").GetValue<GameModeOption>();
				bool flag = value > GameModeOption.None;
				bool flag2 = !flag;
				if (flag2)
				{
					bool flag3 = Player.main.GetOxygenAvailable().IsBetween(0f, ModInfo.consumeOxyTrigger);
					if (flag3)
					{
						bool flag4 = !Player.main.CanBreathe();
						if (flag4)
						{
							Pickupable pickupable = (from item in this.itemsContainer.Where(delegate(InventoryItem item)
								{
									bool flag5 = item == null;
									global::UnityEngine.Object @object;
									if (flag5)
									{
										@object = null;
									}
									else
									{
										Pickupable item2 = item.item;
										bool flag6 = item2 == null;
										if (flag6)
										{
											@object = null;
										}
										else
										{
											GameObject gameObject = item2.gameObject;
											bool flag7 = gameObject == null;
											if (flag7)
											{
												@object = null;
											}
											else
											{
												ImOxygenCanister componentInChildren = gameObject.GetComponentInChildren<ImOxygenCanister>();
												bool flag8 = componentInChildren == null;
												if (flag8)
												{
													@object = null;
												}
												else
												{
													GameObject gameObject2 = componentInChildren.gameObject;
													@object = ((gameObject2 != null) ? gameObject2.GetComponentInChildren<Pickupable>() : null);
												}
											}
										}
									}
									return @object != null;
								})
								select item.item.gameObject.GetComponentInChildren<ImOxygenCanister>().gameObject.GetComponentInChildren<Pickupable>()).FirstOrDefault<Pickupable>();
							this.survival.Eat(pickupable.gameObject);
							this.itemsContainer.RemoveItem(pickupable, false);
						}
					}
				}
			}
		}

		// Token: 0x0400000D RID: 13
		public Survival survival = new Survival();
	}
}
