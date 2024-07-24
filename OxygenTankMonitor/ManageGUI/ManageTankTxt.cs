using System;
using OxygenTankMonitor.Helpers;
using OxygenTankMonitor.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace OxygenTankMonitor.ManageGUI
{
	// Token: 0x02000010 RID: 16
	internal class ManageTankTxt
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00005414 File Offset: 0x00003614
		internal static void ManageCountText()
		{
			bool flag = ManageAllGUIElements.TankTextObj00 == null;
			if (flag)
			{
				ManageAllGUIElements.TankTextObj00 = PrepareGUIObjects.PrepareGUIObject("TankTextUI00", ModInfo.BG_Position);
				bool flag2 = ManageAllGUIElements.TankTextObj00 != null;
				if (flag2)
				{
					ManageAllGUIElements.TankTextObj00 = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.TankTextObj00, ModInfo.fontSize, true, Color.white, ModInfo.BG_Position, ModInfo.BG_Size);
				}
				bool flag3 = ManageAllGUIElements.TankTextObj00 != null;
				if (flag3)
				{
					ManageAllGUIElements.TankTextObj00.SetActive(false);
				}
			}
			bool flag4 = ManageAllGUIElements.TankTextObj01 == null;
			if (flag4)
			{
				ManageAllGUIElements.TankTextObj01 = PrepareGUIObjects.PrepareGUIObject("TankTextUI01", ModInfo.BG_Position);
				bool flag5 = ManageAllGUIElements.TankTextObj01 != null;
				if (flag5)
				{
					ManageAllGUIElements.TankTextObj01 = PrepareGUITxt.PrepareTxtElement(ManageAllGUIElements.TankTextObj01, ModInfo.fontSize, true, Color.white, ModInfo.BG_Position, ModInfo.BG_Size);
				}
				bool flag6 = ManageAllGUIElements.TankTextObj01 != null;
				if (flag6)
				{
					ManageAllGUIElements.TankTextObj01.SetActive(false);
				}
			}
			foreach (Oxygen oxygen in TankList.GetTankList())
			{
				DisplayPrompts.DisplayHint(" Tank: " + oxygen.oxygenAvailable.ToString() + " ", true);
			}
			for (int i = 0; i < 1; i++)
			{
				Text component = ManageAllGUIElements.TankTextObj00.GetComponent<Text>();
				component.text = TankList.GetTankList()[i].ToString();
			}
			bool flag7 = ManageAllGUIElements.TankTextObj00 != null;
			if (flag7)
			{
				ManageAllGUIElements.TankTextObj00.SetActive(true);
			}
		}
	}
}
