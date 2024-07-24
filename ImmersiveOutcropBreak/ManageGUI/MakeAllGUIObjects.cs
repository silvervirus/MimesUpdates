using System;
using ImmersiveOutcropBreak.Info;

namespace ImmersiveOutcropBreak.ManageGUI
{
	// Token: 0x0200000F RID: 15
	internal class MakeAllGUIObjects
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00003614 File Offset: 0x00001814
		internal static void MakeAllGUIObj()
		{
			bool flag = ManageAllGUIElements.PulseSmallUIGameObj == null;
			if (flag)
			{
				ManageAllGUIElements.PulseSmallUIGameObj = PrepareGUIObjects.PrepareGUIObject("PulseSmallUI", ModInfo.Pulse_Position);
			}
			bool flag2 = ManageAllGUIElements.PulseSmallUIGameObj != null;
			if (flag2)
			{
				ManageAllGUIElements.PulseSmallUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.PulseSmallUIGameObj, "PulseS", ModInfo.Pulse_Position, ModInfo.Pulse_Size, true);
			}
			bool flag3 = ManageAllGUIElements.PulseMediumUIGameObj == null;
			if (flag3)
			{
				ManageAllGUIElements.PulseMediumUIGameObj = PrepareGUIObjects.PrepareGUIObject("PulseMediumUI", ModInfo.Pulse_Position);
			}
			bool flag4 = ManageAllGUIElements.PulseMediumUIGameObj != null;
			if (flag4)
			{
				ManageAllGUIElements.PulseMediumUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.PulseMediumUIGameObj, "PulseM", ModInfo.Pulse_Position, ModInfo.Pulse_Size, true);
			}
			bool flag5 = ManageAllGUIElements.PulseLargeUIGameObj == null;
			if (flag5)
			{
				ManageAllGUIElements.PulseLargeUIGameObj = PrepareGUIObjects.PrepareGUIObject("PulseLargeUI", ModInfo.Pulse_Position);
			}
			bool flag6 = ManageAllGUIElements.PulseLargeUIGameObj != null;
			if (flag6)
			{
				ManageAllGUIElements.PulseLargeUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.PulseLargeUIGameObj, "PulseL", ModInfo.Pulse_Position, ModInfo.Pulse_Size, true);
			}
			bool flag7 = ManageAllGUIElements.PickupOnUIGameObj == null;
			if (flag7)
			{
				ManageAllGUIElements.PickupOnUIGameObj = PrepareGUIObjects.PrepareGUIObject("PickupOnUI", ModInfo.Pickup_Position);
			}
			bool flag8 = ManageAllGUIElements.PickupOnUIGameObj != null;
			if (flag8)
			{
				ManageAllGUIElements.PickupOnUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.PickupOnUIGameObj, "PickupOn", ModInfo.Pickup_Position, ModInfo.Pickup_Size, true);
			}
			bool flag9 = ManageAllGUIElements.PickupOffUIGameObj == null;
			if (flag9)
			{
				ManageAllGUIElements.PickupOffUIGameObj = PrepareGUIObjects.PrepareGUIObject("PickupOffUI", ModInfo.Pickup_Position);
			}
			bool flag10 = ManageAllGUIElements.PickupOffUIGameObj != null;
			if (flag10)
			{
				ManageAllGUIElements.PickupOffUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.PickupOffUIGameObj, "PickupOff", ModInfo.Pickup_Position, ModInfo.Pickup_Size, true);
			}
			bool flag11 = ManageAllGUIElements.BreakOnUIGameObj == null;
			if (flag11)
			{
				ManageAllGUIElements.BreakOnUIGameObj = PrepareGUIObjects.PrepareGUIObject("BreakOnUI", ModInfo.Break_Position);
			}
			bool flag12 = ManageAllGUIElements.BreakOnUIGameObj != null;
			if (flag12)
			{
				ManageAllGUIElements.BreakOnUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BreakOnUIGameObj, "BreakOn", ModInfo.Break_Position, ModInfo.Break_Size, true);
			}
			bool flag13 = ManageAllGUIElements.BreakOffUIGameObj == null;
			if (flag13)
			{
				ManageAllGUIElements.BreakOffUIGameObj = PrepareGUIObjects.PrepareGUIObject("BreakOffUI", ModInfo.Break_Position);
			}
			bool flag14 = ManageAllGUIElements.BreakOffUIGameObj != null;
			if (flag14)
			{
				ManageAllGUIElements.BreakOffUIGameObj = PrepareGUISprite.PrepareGuiElement(ManageAllGUIElements.BreakOffUIGameObj, "BreakOff", ModInfo.Break_Position, ModInfo.Break_Size, true);
			}
		}
	}
}
