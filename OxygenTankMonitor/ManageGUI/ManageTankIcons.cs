using System;
using OxygenTankMonitor.Helpers;
using OxygenTankMonitor.InfoObjects;
using UnityEngine;
using UnityEngine.UI;

namespace OxygenTankMonitor.ManageGUI
{
	// Token: 0x0200000F RID: 15
	internal class ManageTankIcons
	{
		// Token: 0x06000048 RID: 72 RVA: 0x000040B0 File Offset: 0x000022B0
		internal static void ManageTanks()
		{
			MakeMoniGUIObjects.MakeMoniObjects();
			bool flag = ManageTankIcons.UI_BG_ObjsOK() && ManageTankIcons.UI_Tank_ObjsOK() && ManageTankIcons.UI_Bar_ObjsOK() && ManageTankIcons.UI_TxtObjectsOK();
			if (flag)
			{
				int count = TankList.GetTankList().Count;
				bool flag2 = count > 0;
				if (flag2)
				{
					GameObject[] array = new GameObject[]
					{
						ManageAllGUIElements.TankTextObj00,
						ManageAllGUIElements.TankTextObj01,
						ManageAllGUIElements.TankTextObj02,
						ManageAllGUIElements.TankTextObj03,
						ManageAllGUIElements.TankTextObj04,
						ManageAllGUIElements.TankTextObj05
					};
					bool flag3 = count > 6;
					if (flag3)
					{
						int num = (int)Mathf.Round(ManageTankIcons.SumO2Available());
						Text component = ManageAllGUIElements.TankTextObj00.GetComponent<Text>();
						component.text = "O₂Σ\n" + num.ToString();
						Text component2 = ManageAllGUIElements.TankTextObj01.GetComponent<Text>();
						component2.text = count.ToString() + " x";
						ManageTankIcons.ProcessSumBar(ManageAllGUIElements.TankBarMoni00UIGameObject);
						ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni01UIGameObject, 1, true);
					}
					else
					{
						for (int i = 0; i < count; i++)
						{
							Text component3 = array[i].GetComponent<Text>();
							component3.text = "O₂\n" + ((int)Mathf.Round(TankList.GetTankList()[i].oxygenAvailable)).ToString();
						}
						switch (count)
						{
						case 1:
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni00UIGameObject, 0, false);
							break;
						case 2:
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni00UIGameObject, 0, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni01UIGameObject, 1, false);
							break;
						case 3:
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni00UIGameObject, 0, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni01UIGameObject, 1, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni02UIGameObject, 2, false);
							break;
						case 4:
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni00UIGameObject, 0, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni01UIGameObject, 1, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni02UIGameObject, 2, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni03UIGameObject, 3, false);
							break;
						case 5:
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni00UIGameObject, 0, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni01UIGameObject, 1, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni02UIGameObject, 2, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni03UIGameObject, 3, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni04UIGameObject, 4, false);
							break;
						case 6:
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni00UIGameObject, 0, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni01UIGameObject, 1, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni02UIGameObject, 2, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni03UIGameObject, 3, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni04UIGameObject, 4, false);
							ManageTankIcons.ProcessBar(ManageAllGUIElements.TankBarMoni05UIGameObject, 5, false);
							break;
						}
					}
					Image component4 = ManageAllGUIElements.BGrightUIGameObject.GetComponent<Image>();
					bool flag4 = count == 1;
					if (flag4)
					{
						ManageAllGUIElements.BGleftUIGameObject.SetActive(false);
						ManageAllGUIElements.BGrightUIGameObject.SetActive(false);
						ManageAllGUIElements.BGc01UIGameObject.SetActive(false);
						ManageAllGUIElements.BGc02UIGameObject.SetActive(false);
						ManageAllGUIElements.BGc03UIGameObject.SetActive(false);
						ManageAllGUIElements.BGc04UIGameObject.SetActive(false);
						ManageAllGUIElements.BGsingleUIGameObject.SetActive(true);
						ManageAllGUIElements.TankTextObj00.SetActive(true);
						ManageAllGUIElements.TankTextObj01.SetActive(false);
						ManageAllGUIElements.TankTextObj02.SetActive(false);
						ManageAllGUIElements.TankTextObj03.SetActive(false);
						ManageAllGUIElements.TankTextObj04.SetActive(false);
						ManageAllGUIElements.TankTextObj05.SetActive(false);
						ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni00UIGameObject);
						ManageAllGUIElements.TankBarMoni00UIGameObject.SetActive(true);
						ManageAllGUIElements.TankBarMoni01UIGameObject.SetActive(false);
						ManageAllGUIElements.TankBarMoni02UIGameObject.SetActive(false);
						ManageAllGUIElements.TankBarMoni03UIGameObject.SetActive(false);
						ManageAllGUIElements.TankBarMoni04UIGameObject.SetActive(false);
						ManageAllGUIElements.TankBarMoni05UIGameObject.SetActive(false);
						ManageAllGUIElements.TankIconMoni00UIGameObject.SetActive(true);
						ManageAllGUIElements.TankIconMoni01UIGameObject.SetActive(false);
						ManageAllGUIElements.TankIconMoni02UIGameObject.SetActive(false);
						ManageAllGUIElements.TankIconMoni03UIGameObject.SetActive(false);
						ManageAllGUIElements.TankIconMoni04UIGameObject.SetActive(false);
						ManageAllGUIElements.TankIconMoni05UIGameObject.SetActive(false);
					}
					else
					{
						ManageAllGUIElements.BGleftUIGameObject.SetActive(true);
						ManageAllGUIElements.BGsingleUIGameObject.SetActive(false);
						switch (count)
						{
						case 2:
							ManageAllGUIElements.BGc01UIGameObject.SetActive(false);
							ManageAllGUIElements.BGc02UIGameObject.SetActive(false);
							ManageAllGUIElements.BGc03UIGameObject.SetActive(false);
							ManageAllGUIElements.BGc04UIGameObject.SetActive(false);
							ManageTankIcons.PlaceBG(component4, 2f);
							ManageAllGUIElements.BGrightUIGameObject.SetActive(true);
							ManageAllGUIElements.TankTextObj00.SetActive(true);
							ManageAllGUIElements.TankTextObj01.SetActive(true);
							ManageAllGUIElements.TankTextObj02.SetActive(false);
							ManageAllGUIElements.TankTextObj03.SetActive(false);
							ManageAllGUIElements.TankTextObj04.SetActive(false);
							ManageAllGUIElements.TankTextObj05.SetActive(false);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni00UIGameObject);
							ManageAllGUIElements.TankBarMoni00UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni01UIGameObject);
							ManageAllGUIElements.TankBarMoni01UIGameObject.SetActive(true);
							ManageAllGUIElements.TankBarMoni02UIGameObject.SetActive(false);
							ManageAllGUIElements.TankBarMoni03UIGameObject.SetActive(false);
							ManageAllGUIElements.TankBarMoni04UIGameObject.SetActive(false);
							ManageAllGUIElements.TankBarMoni05UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni00UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni01UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni02UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni03UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni04UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni05UIGameObject.SetActive(false);
							break;
						case 3:
							ManageAllGUIElements.BGc01UIGameObject.SetActive(true);
							ManageAllGUIElements.BGc02UIGameObject.SetActive(false);
							ManageAllGUIElements.BGc03UIGameObject.SetActive(false);
							ManageAllGUIElements.BGc04UIGameObject.SetActive(false);
							ManageTankIcons.PlaceBG(component4, 3f);
							ManageAllGUIElements.BGrightUIGameObject.SetActive(true);
							ManageAllGUIElements.TankTextObj00.SetActive(true);
							ManageAllGUIElements.TankTextObj01.SetActive(true);
							ManageAllGUIElements.TankTextObj02.SetActive(true);
							ManageAllGUIElements.TankTextObj03.SetActive(false);
							ManageAllGUIElements.TankTextObj04.SetActive(false);
							ManageAllGUIElements.TankTextObj05.SetActive(false);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni00UIGameObject);
							ManageAllGUIElements.TankBarMoni00UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni01UIGameObject);
							ManageAllGUIElements.TankBarMoni01UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni02UIGameObject);
							ManageAllGUIElements.TankBarMoni02UIGameObject.SetActive(true);
							ManageAllGUIElements.TankBarMoni03UIGameObject.SetActive(false);
							ManageAllGUIElements.TankBarMoni04UIGameObject.SetActive(false);
							ManageAllGUIElements.TankBarMoni05UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni00UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni01UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni02UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni03UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni04UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni05UIGameObject.SetActive(false);
							break;
						case 4:
							ManageAllGUIElements.BGc01UIGameObject.SetActive(true);
							ManageAllGUIElements.BGc02UIGameObject.SetActive(true);
							ManageAllGUIElements.BGc03UIGameObject.SetActive(false);
							ManageAllGUIElements.BGc04UIGameObject.SetActive(false);
							ManageTankIcons.PlaceBG(component4, 4f);
							ManageAllGUIElements.BGrightUIGameObject.SetActive(true);
							ManageAllGUIElements.TankTextObj00.SetActive(true);
							ManageAllGUIElements.TankTextObj01.SetActive(true);
							ManageAllGUIElements.TankTextObj02.SetActive(true);
							ManageAllGUIElements.TankTextObj03.SetActive(true);
							ManageAllGUIElements.TankTextObj04.SetActive(false);
							ManageAllGUIElements.TankTextObj05.SetActive(false);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni00UIGameObject);
							ManageAllGUIElements.TankBarMoni00UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni01UIGameObject);
							ManageAllGUIElements.TankBarMoni01UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni02UIGameObject);
							ManageAllGUIElements.TankBarMoni02UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni03UIGameObject);
							ManageAllGUIElements.TankBarMoni03UIGameObject.SetActive(true);
							ManageAllGUIElements.TankBarMoni04UIGameObject.SetActive(false);
							ManageAllGUIElements.TankBarMoni05UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni00UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni01UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni02UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni03UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni04UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni05UIGameObject.SetActive(false);
							break;
						case 5:
							ManageAllGUIElements.BGc01UIGameObject.SetActive(true);
							ManageAllGUIElements.BGc02UIGameObject.SetActive(true);
							ManageAllGUIElements.BGc03UIGameObject.SetActive(true);
							ManageAllGUIElements.BGc04UIGameObject.SetActive(false);
							ManageTankIcons.PlaceBG(component4, 5f);
							ManageAllGUIElements.BGrightUIGameObject.SetActive(true);
							ManageAllGUIElements.TankTextObj00.SetActive(true);
							ManageAllGUIElements.TankTextObj01.SetActive(true);
							ManageAllGUIElements.TankTextObj02.SetActive(true);
							ManageAllGUIElements.TankTextObj03.SetActive(true);
							ManageAllGUIElements.TankTextObj04.SetActive(true);
							ManageAllGUIElements.TankTextObj05.SetActive(false);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni00UIGameObject);
							ManageAllGUIElements.TankBarMoni00UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni01UIGameObject);
							ManageAllGUIElements.TankBarMoni01UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni02UIGameObject);
							ManageAllGUIElements.TankBarMoni02UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni03UIGameObject);
							ManageAllGUIElements.TankBarMoni03UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni04UIGameObject);
							ManageAllGUIElements.TankBarMoni04UIGameObject.SetActive(true);
							ManageAllGUIElements.TankBarMoni05UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni00UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni01UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni02UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni03UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni04UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni05UIGameObject.SetActive(false);
							break;
						case 6:
							ManageAllGUIElements.BGc01UIGameObject.SetActive(true);
							ManageAllGUIElements.BGc02UIGameObject.SetActive(true);
							ManageAllGUIElements.BGc03UIGameObject.SetActive(true);
							ManageAllGUIElements.BGc04UIGameObject.SetActive(true);
							ManageTankIcons.PlaceBG(component4, 6f);
							ManageAllGUIElements.BGrightUIGameObject.SetActive(true);
							ManageAllGUIElements.TankTextObj00.SetActive(true);
							ManageAllGUIElements.TankTextObj01.SetActive(true);
							ManageAllGUIElements.TankTextObj02.SetActive(true);
							ManageAllGUIElements.TankTextObj03.SetActive(true);
							ManageAllGUIElements.TankTextObj04.SetActive(true);
							ManageAllGUIElements.TankTextObj05.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni00UIGameObject);
							ManageAllGUIElements.TankBarMoni00UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni01UIGameObject);
							ManageAllGUIElements.TankBarMoni01UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni02UIGameObject);
							ManageAllGUIElements.TankBarMoni02UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni03UIGameObject);
							ManageAllGUIElements.TankBarMoni03UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni04UIGameObject);
							ManageAllGUIElements.TankBarMoni04UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni05UIGameObject);
							ManageAllGUIElements.TankBarMoni05UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni00UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni01UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni02UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni03UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni04UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni05UIGameObject.SetActive(true);
							break;
						default:
							ManageAllGUIElements.BGc01UIGameObject.SetActive(false);
							ManageAllGUIElements.BGc02UIGameObject.SetActive(false);
							ManageAllGUIElements.BGc03UIGameObject.SetActive(false);
							ManageAllGUIElements.BGc04UIGameObject.SetActive(false);
							ManageTankIcons.PlaceBG(component4, 2f);
							ManageAllGUIElements.BGrightUIGameObject.SetActive(true);
							ManageAllGUIElements.TankTextObj00.SetActive(true);
							ManageAllGUIElements.TankTextObj01.SetActive(true);
							ManageAllGUIElements.TankTextObj02.SetActive(false);
							ManageAllGUIElements.TankTextObj03.SetActive(false);
							ManageAllGUIElements.TankTextObj04.SetActive(false);
							ManageAllGUIElements.TankTextObj05.SetActive(false);
							ManageAllGUIElements.SetImageColour(Color.green, ManageAllGUIElements.TankBarMoni00UIGameObject);
							ManageAllGUIElements.TankBarMoni00UIGameObject.SetActive(true);
							ManageAllGUIElements.SetImageColour(Color.white, ManageAllGUIElements.TankBarMoni01UIGameObject);
							ManageAllGUIElements.TankBarMoni01UIGameObject.SetActive(true);
							ManageAllGUIElements.TankBarMoni02UIGameObject.SetActive(false);
							ManageAllGUIElements.TankBarMoni03UIGameObject.SetActive(false);
							ManageAllGUIElements.TankBarMoni04UIGameObject.SetActive(false);
							ManageAllGUIElements.TankBarMoni05UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni00UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni01UIGameObject.SetActive(true);
							ManageAllGUIElements.TankIconMoni02UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni03UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni04UIGameObject.SetActive(false);
							ManageAllGUIElements.TankIconMoni05UIGameObject.SetActive(false);
							break;
						}
					}
				}
				else
				{
					ManageTankIcons.TurnBGUIoff();
					ManageTankIcons.TurnTankUIoff();
					ManageTankIcons.TurnBarUIoff();
					ManageTankIcons.TurnTxtUIoff();
				}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004D64 File Offset: 0x00002F64
		internal static bool UI_BG_ObjsOK()
		{
			bool flag = ManageAllGUIElements.BGleftUIGameObject != null;
			bool flag2 = ManageAllGUIElements.BGrightUIGameObject != null;
			bool flag3 = ManageAllGUIElements.BGc01UIGameObject != null;
			bool flag4 = ManageAllGUIElements.BGc02UIGameObject != null;
			bool flag5 = ManageAllGUIElements.BGc03UIGameObject != null;
			bool flag6 = ManageAllGUIElements.BGc04UIGameObject != null;
			bool flag7 = ManageAllGUIElements.BGsingleUIGameObject != null;
			return flag && flag2 && flag3 && flag4 && flag5 && flag6 && flag7;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004DE0 File Offset: 0x00002FE0
		internal static bool UI_Tank_ObjsOK()
		{
			bool flag = ManageAllGUIElements.TankIconMoni00UIGameObject != null;
			bool flag2 = ManageAllGUIElements.TankIconMoni01UIGameObject != null;
			bool flag3 = ManageAllGUIElements.TankIconMoni02UIGameObject != null;
			bool flag4 = ManageAllGUIElements.TankIconMoni03UIGameObject != null;
			bool flag5 = ManageAllGUIElements.TankIconMoni04UIGameObject != null;
			bool flag6 = ManageAllGUIElements.TankIconMoni05UIGameObject != null;
			return flag && flag2 && flag3 && flag4 && flag5 && flag6;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004E4C File Offset: 0x0000304C
		internal static bool UI_Bar_ObjsOK()
		{
			bool flag = ManageAllGUIElements.TankBarMoni00UIGameObject != null;
			bool flag2 = ManageAllGUIElements.TankBarMoni01UIGameObject != null;
			bool flag3 = ManageAllGUIElements.TankBarMoni02UIGameObject != null;
			bool flag4 = ManageAllGUIElements.TankBarMoni03UIGameObject != null;
			bool flag5 = ManageAllGUIElements.TankBarMoni04UIGameObject != null;
			bool flag6 = ManageAllGUIElements.TankBarMoni05UIGameObject != null;
			return flag && flag2 && flag3 && flag4 && flag5 && flag6;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004EB8 File Offset: 0x000030B8
		internal static void TurnBGUIoff()
		{
			ManageAllGUIElements.BGleftUIGameObject.SetActive(false);
			ManageAllGUIElements.BGrightUIGameObject.SetActive(false);
			ManageAllGUIElements.BGc01UIGameObject.SetActive(false);
			ManageAllGUIElements.BGc02UIGameObject.SetActive(false);
			ManageAllGUIElements.BGc03UIGameObject.SetActive(false);
			ManageAllGUIElements.BGc04UIGameObject.SetActive(false);
			ManageAllGUIElements.BGsingleUIGameObject.SetActive(false);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004F1C File Offset: 0x0000311C
		internal static void TurnTankUIoff()
		{
			ManageAllGUIElements.TankIconMoni00UIGameObject.SetActive(false);
			ManageAllGUIElements.TankIconMoni01UIGameObject.SetActive(false);
			ManageAllGUIElements.TankIconMoni02UIGameObject.SetActive(false);
			ManageAllGUIElements.TankIconMoni03UIGameObject.SetActive(false);
			ManageAllGUIElements.TankIconMoni04UIGameObject.SetActive(false);
			ManageAllGUIElements.TankIconMoni05UIGameObject.SetActive(false);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004F74 File Offset: 0x00003174
		internal static void TurnBarUIoff()
		{
			ManageAllGUIElements.TankBarMoni00UIGameObject.SetActive(false);
			ManageAllGUIElements.TankBarMoni01UIGameObject.SetActive(false);
			ManageAllGUIElements.TankBarMoni02UIGameObject.SetActive(false);
			ManageAllGUIElements.TankBarMoni03UIGameObject.SetActive(false);
			ManageAllGUIElements.TankBarMoni04UIGameObject.SetActive(false);
			ManageAllGUIElements.TankBarMoni05UIGameObject.SetActive(false);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004FCC File Offset: 0x000031CC
		internal static bool UI_TxtObjectsOK()
		{
			bool flag = ManageAllGUIElements.TankTextObj00 != null;
			bool flag2 = ManageAllGUIElements.TankTextObj01 != null;
			bool flag3 = ManageAllGUIElements.TankTextObj02 != null;
			bool flag4 = ManageAllGUIElements.TankTextObj03 != null;
			bool flag5 = ManageAllGUIElements.TankTextObj04 != null;
			bool flag6 = ManageAllGUIElements.TankTextObj05 != null;
			return flag && flag2 && flag3 && flag4 && flag5 && flag6;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005038 File Offset: 0x00003238
		internal static void TurnTxtUIoff()
		{
			ManageAllGUIElements.TankTextObj00.SetActive(false);
			ManageAllGUIElements.TankTextObj01.SetActive(false);
			ManageAllGUIElements.TankTextObj02.SetActive(false);
			ManageAllGUIElements.TankTextObj03.SetActive(false);
			ManageAllGUIElements.TankTextObj04.SetActive(false);
			ManageAllGUIElements.TankTextObj05.SetActive(false);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005090 File Offset: 0x00003290
		internal static void PlaceBG(Image BGrightUIImage, float BGposition)
		{
			RectTransform component = BGrightUIImage.GetComponent<RectTransform>();
			bool flag = BGposition == 1f;
			if (flag)
			{
				component.localPosition = new Vector3(ModInfo.BGmoveLeftRightX, ModInfo.BGmoveUpDownY, 0f);
			}
			else
			{
				component.localPosition = new Vector3(ModInfo.BGmoveLeftRightX + ModInfo.shiftRight * (BGposition - 1f), ModInfo.BGmoveUpDownY, 0f);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000050F8 File Offset: 0x000032F8
		internal static void PlaceBar(Image BGrightUIImage, float BarPosition)
		{
			RectTransform component = BGrightUIImage.GetComponent<RectTransform>();
			bool flag = BarPosition == 1f;
			if (flag)
			{
				component.localPosition = new Vector3(ModInfo.icon_TankBarX, ModInfo.icon_TankBarY, 0f);
			}
			else
			{
				component.localPosition = new Vector3(ModInfo.icon_TankBarX + ModInfo.shiftRight * (BarPosition - 1f), ModInfo.icon_TankBarY, 0f);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005160 File Offset: 0x00003360
		internal static void PlaceIcon(Image BGrightUIImage, float IconPosition)
		{
			RectTransform component = BGrightUIImage.GetComponent<RectTransform>();
			bool flag = IconPosition == 1f;
			if (flag)
			{
				component.localPosition = new Vector3(ModInfo.icon_TankMoniX, ModInfo.icon_TankMoniY, 0f);
			}
			else
			{
				component.localPosition = new Vector3(ModInfo.icon_TankMoniX + ModInfo.shiftRight * (IconPosition - 1f), ModInfo.icon_TankMoniY, 0f);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000051C8 File Offset: 0x000033C8
		internal static void PlaceTxt(Text thisTxt, float TxtPosition)
		{
			RectTransform component = thisTxt.GetComponent<RectTransform>();
			bool flag = TxtPosition == 1f;
			if (flag)
			{
				component.localPosition = new Vector3(ModInfo.TxtLeftRightX, ModInfo.BGmoveUpDownY, 0f);
			}
			else
			{
				component.localPosition = new Vector3(ModInfo.TxtLeftRightX + ModInfo.shiftRight * (TxtPosition - 1f), ModInfo.BGmoveUpDownY, 0f);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005230 File Offset: 0x00003430
		internal static void ProcessBar(GameObject thisGameObject, int arraySpot, bool restoreDefaultSize)
		{
			float num = TankList.GetTankList()[arraySpot].oxygenAvailable / TankList.GetTankList()[arraySpot].oxygenCapacity;
			Image component = thisGameObject.GetComponent<Image>();
			RectTransform component2 = component.GetComponent<RectTransform>();
			if (restoreDefaultSize)
			{
				component2.sizeDelta = new Vector2(ModInfo.BGsizeX - 73f, ModInfo.BGsizeY - 53f);
			}
			else
			{
				component2.sizeDelta = new Vector2(ModInfo.BGsizeX - 73f, (ModInfo.BGsizeY - 53f) * num);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000052BC File Offset: 0x000034BC
		internal static void ProcessSumBar(GameObject thisGameObject)
		{
			float num = ManageTankIcons.SumO2Available() / ManageTankIcons.SumO2Capacity();
			Image component = thisGameObject.GetComponent<Image>();
			RectTransform component2 = component.GetComponent<RectTransform>();
			component2.sizeDelta = new Vector2(ModInfo.BGsizeX - 73f, (ModInfo.BGsizeY - 53f) * num);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005308 File Offset: 0x00003508
		internal static void SetColour(Color thisColor, GameObject gameObject)
		{
			bool flag = gameObject != null;
			if (flag)
			{
				Image component = gameObject.GetComponent<Image>();
				bool flag2 = component != null;
				if (flag2)
				{
					component.color = thisColor;
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005340 File Offset: 0x00003540
		internal static float SumO2Available()
		{
			float num = 0f;
			foreach (Oxygen oxygen in TankList.GetTankList())
			{
				num += oxygen.oxygenAvailable;
			}
			return num;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000053A4 File Offset: 0x000035A4
		internal static float SumO2Capacity()
		{
			float num = 0f;
			foreach (Oxygen oxygen in TankList.GetTankList())
			{
				num += oxygen.oxygenCapacity;
			}
			return num;
		}
	}
}
