using System;
using System.Text;
using BetterHUDInfo.InfoObjects;

namespace BetterHUDInfo.Helpers
{
	// Token: 0x02000028 RID: 40
	internal class BiomeState
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00006B28 File Offset: 0x00004D28
		public static string GetBiome()
		{
			Player main = Player.main;
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = main != null;
			if (flag)
			{
				bool playerInBaseCamera = ModInfo.PlayerInBaseCamera;
				if (playerInBaseCamera)
				{
					uGUI_CameraDrone main2 = uGUI_CameraDrone.main;
					bool flag2 = main2;
					if (flag2)
					{
						MapRoomCamera camera = main2.GetCamera();
						bool flag3 = camera;
						if (flag3)
						{
							stringBuilder.Append(LargeWorld.main.GetBiome(camera.transform.position).ToUpper());
						}
					}
				}
				else
				{
					stringBuilder.Append(main.GetBiomeString().ToUpper());
				}
			}
			return stringBuilder.ToString();
		}
	}
}
