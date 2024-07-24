using System;
using System.Text;
using UnityEngine;

namespace BetterHUDInfo.Helpers
{
	// Token: 0x02000029 RID: 41
	internal class CoordState
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00006BD4 File Offset: 0x00004DD4
		public static string GetCoords()
		{
			Player main = Player.main;
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = main != null;
			if (flag)
			{
				bool flag2 = main.IsInBase() && main.IsPiloting();
				int num;
				int num2;
				int num3;
				if (flag2)
				{
					uGUI_CameraDrone main2 = uGUI_CameraDrone.main;
					MapRoomCamera camera = main2.GetCamera();
					bool flag3 = camera != null;
					if (flag3)
					{
						num = Mathf.RoundToInt(camera.transform.position.x);
						num2 = Mathf.RoundToInt(camera.transform.position.y);
						num3 = Mathf.RoundToInt(camera.transform.position.z);
					}
					else
					{
						num = 0;
						num2 = 0;
						num3 = 0;
					}
				}
				else
				{
					num = Mathf.RoundToInt(main.transform.position.x);
					num2 = Mathf.RoundToInt(main.transform.position.y);
					num3 = Mathf.RoundToInt(main.transform.position.z);
				}
				stringBuilder.Append(string.Format("X {0}, Y {1}, Z {2}", num, num2, num3));
			}
			return stringBuilder.ToString();
		}
	}
}
