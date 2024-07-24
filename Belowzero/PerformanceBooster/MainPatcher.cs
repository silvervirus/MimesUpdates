using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using BepInEx;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Events;

namespace PerformanceBooster
{
	// Token: 0x02000003 RID: 3
	[BepInPlugin("com.whotnt.subnautica.performanceboosterBZ.mod", "Performance Booster Bz", "2.1")]
	public class MainPatcher : BaseUnityPlugin
	{
		// Token: 0x06000004 RID: 4
		[DllImport("kernel32.dll")]
		private static extern bool SetProcessAffinityMask(IntPtr hProcess, UIntPtr dwProcessAffinityMask);

		// Token: 0x06000005 RID: 5 RVA: 0x000020E4 File Offset: 0x000002E4
		private void Awake()
		{
			try
			{
				MainPatcher.harmony = new Harmony("com.whotnt.subnautica.performancebooster.mod");
				MainPatcher.harmony.PatchAll();
				Console.WriteLine("[Performance Booster Bz] Patched");
			}
			catch (Exception ex)
			{
				global::UnityEngine.Debug.Log("Error with Performance Booster patching: " + ex.Message);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002140 File Offset: 0x00000340
		private static void setSunShaftQuality(int value)
		{
			WaterSunShaftsOnCamera waterSunShaftsOnCamera = global::UnityEngine.Object.FindObjectOfType<WaterSunShaftsOnCamera>();
			if (waterSunShaftsOnCamera != null)
			{
				value = ((QualitySettings.shadows > ShadowQuality.Disable) ? value : 0);
				MainPatcher.sunShaftQuality = value;
				if (value == 0)
				{
					waterSunShaftsOnCamera.enabled = false;
					return;
				}
				waterSunShaftsOnCamera.enabled = true;
				waterSunShaftsOnCamera.reduction = 10 - value * 2;
				waterSunShaftsOnCamera.traceStepSize = 0.2f / (float)value;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000219C File Offset: 0x0000039C
		public static void SetAffinity(int cores)
		{
			if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				global::UnityEngine.Debug.Log("Performance Booster Affinity Tweak is disabled since the system is not running Windows OS");
				return;
			}
			if (MainPatcher.affinityTweakEnabled)
			{
				global::UnityEngine.Debug.Log("PROCESSOR COUNT: " + Environment.ProcessorCount.ToString());
				if (Environment.ProcessorCount < cores * 2 - 1)
				{
					global::UnityEngine.Debug.Log("Setting Affinity was not possible. Insufficient System CPU Cores");
					return;
				}
				if (!MainPatcher.SetProcessAffinityMask(Process.GetCurrentProcess().Handle, new UIntPtr((uint)(Math.Pow(2.0, (double)(cores * 2)) - 1.0) / 3U)))
				{
					global::UnityEngine.Debug.Log("Setting Affinity Failed with Error code: " + Marshal.GetLastWin32Error().ToString());
					return;
				}
				global::UnityEngine.Debug.Log("Process Affinity set for " + cores.ToString() + " CPU cores.");
				return;
			}
			else
			{
				if (!MainPatcher.SetProcessAffinityMask(Process.GetCurrentProcess().Handle, new UIntPtr((uint)(Math.Pow(2.0, (double)Environment.ProcessorCount) - 1.0))))
				{
					global::UnityEngine.Debug.Log("Setting Affinity to all cores Failed with Error code: " + Marshal.GetLastWin32Error().ToString());
					return;
				}
				global::UnityEngine.Debug.Log("Affinity set to all cores.");
				return;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022C7 File Offset: 0x000004C7
		private static void OnCPUCoresChanged(int cores)
		{
			MainPatcher.CPUCores = cores;
			if (MainPatcher.affinityTweakEnabled)
			{
				MainPatcher.SetAffinity(cores);
			}
		}

		// Token: 0x04000003 RID: 3
		private static Harmony harmony;

		// Token: 0x04000004 RID: 4
		private static float underwaterFarClipPlane = 250f;

		// Token: 0x04000005 RID: 5
		private static float aboveWaterFarClipPlane = 1000f;

		// Token: 0x04000006 RID: 6
		private static bool affinityTweakEnabled = false;

		// Token: 0x04000007 RID: 7
		private static int graphicsTabIndex;

		// Token: 0x04000008 RID: 8
		private static int generalTabIndex;

		// Token: 0x04000009 RID: 9
		private static int CPUCores = 3;

		// Token: 0x0400000A RID: 10
		private static int sunShaftQuality = 1;

		// Token: 0x02000005 RID: 5
		[HarmonyPatch(typeof(Player), "Update")]
		private class Player_Update_Patch
		{
			// Token: 0x0600000B RID: 11 RVA: 0x0000230C File Offset: 0x0000050C
			private static void Postfix(Player __instance)
			{
				if (__instance.transform.position.y < Ocean.GetOceanLevel() - 0.75f && !SNCameraRoot.main.mainCam.GetComponent<SonarScreenFX>().enabled)
				{
					MainCamera.camera.farClipPlane = MainPatcher.underwaterFarClipPlane;
					return;
				}
				MainCamera.camera.farClipPlane = MainPatcher.aboveWaterFarClipPlane;
			}
		}

		// Token: 0x02000006 RID: 6
		[HarmonyPatch(typeof(WaterSunShaftsOnCamera), "Awake")]
		private class WaterSunShaftsOnCamera_Awake_Patch
		{
			// Token: 0x0600000D RID: 13 RVA: 0x00002373 File Offset: 0x00000573
			private static void Postfix()
			{
				MainPatcher.setSunShaftQuality(MainPatcher.sunShaftQuality);
			}
		}

		// Token: 0x02000007 RID: 7
		[HarmonyPatch(typeof(uGUI_TabbedControlsPanel), "AddTab")]
		private class uGUI_TabbedControlsPanel_AddTab_Patch
		{
			// Token: 0x0600000F RID: 15 RVA: 0x00002387 File Offset: 0x00000587
			private static void Postfix(int __result, string label)
			{
				if (label.Equals("Graphics"))
				{
					MainPatcher.graphicsTabIndex = __result;
					return;
				}
				if (label.Equals("General"))
				{
					MainPatcher.generalTabIndex = __result;
				}
			}
		}

		// Token: 0x02000008 RID: 8
		[HarmonyPatch(typeof(uGUI_OptionsPanel), "AddGraphicsTab")]
		private class AddGraphicsTab_Patch
		{
			// Token: 0x06000011 RID: 17 RVA: 0x000023B8 File Offset: 0x000005B8
			private static void Postfix(uGUI_OptionsPanel __instance)
			{
				__instance.AddHeading(MainPatcher.graphicsTabIndex, "Performance Booster Options");
				MonoBehaviour fpsCounter = global::UnityEngine.Object.FindObjectOfType<FPSCounter>();
				if (fpsCounter != null)
				{
					UnityAction<bool> unityAction = delegate(bool value)
					{
						fpsCounter.enabled = value;
					};
					__instance.AddToggleOption(MainPatcher.graphicsTabIndex, "Display Framerate", fpsCounter.enabled, unityAction, null);
				}
				__instance.AddSliderOption(MainPatcher.graphicsTabIndex, "Underwater Range", MainPatcher.underwaterFarClipPlane / 10f, 15f, 100f, 20f, 1f, delegate(float v)
				{
					MainPatcher.underwaterFarClipPlane = v * 10f;
				}, SliderLabelMode.Float, "F0", null);
				__instance.AddSliderOption(MainPatcher.graphicsTabIndex, "Surface Range", MainPatcher.aboveWaterFarClipPlane / 10f, 50f, 170f, 100f, 1f, delegate(float v)
				{
					MainPatcher.aboveWaterFarClipPlane = v * 10f;
				}, SliderLabelMode.Float, "F0", "Max value is the default Subnautica render distance");
				__instance.AddSliderOption(MainPatcher.graphicsTabIndex, "HD Distance", QualitySettings.lodBias * 10f, 5f, 100f, 13f, 1f, delegate(float v)
				{
					QualitySettings.lodBias = v / 10f;
				}, SliderLabelMode.Float, "F0", "This determines the distance at which high quality 3D models are replaced with lower quality models. Lower values improve performace.");
				__instance.AddChoiceOption(MainPatcher.graphicsTabIndex, "Texture Quality", new string[] { "Low", "Medium", "High", "Very High" }, 3 - QualitySettings.masterTextureLimit, delegate(int quality)
				{
					QualitySettings.masterTextureLimit = 3 - quality;
				}, null);
				if (QualitySettings.shadows > ShadowQuality.Disable)
				{
					__instance.AddSliderOption(MainPatcher.graphicsTabIndex, "Shadow Distance", QualitySettings.shadowDistance, 50f, 200f, 100f, 1f, delegate(float distance)
					{
						QualitySettings.shadowDistance = distance;
					}, SliderLabelMode.Float, "F0", null);
					__instance.AddChoiceOption(MainPatcher.graphicsTabIndex, "Main Shadow Resolution", new string[] { "Low", "Medium", "High", "Very High" }, (int)QualitySettings.shadowResolution, delegate(int resolution)
					{
						QualitySettings.shadowResolution = (ShadowResolution)resolution;
					}, null);
					__instance.AddChoiceOption(MainPatcher.graphicsTabIndex, "Near Shadow Resolution", new string[] { "Low", "Medium", "High" }, QualitySettings.shadowCascades / 2, delegate(int quality)
					{
						QualitySettings.shadowCascades = quality * 2;
					}, "Number of shadow cascades (0, 2 or 4)");
					__instance.AddChoiceOption(MainPatcher.graphicsTabIndex, "Sun Shaft Quality", new string[] { "Off", "Low", "Medium", "High", "Very High" }, MainPatcher.sunShaftQuality, new UnityAction<int>(MainPatcher.setSunShaftQuality), "This adjusts the quality of the shaft lighting effect when underwater near the surface. Very High is PC default and High is console default.");
					return;
				}
				__instance.AddHeading(MainPatcher.graphicsTabIndex, "Some options are disabled because low quality preset is selected");
			}
		}

		// Token: 0x02000009 RID: 9
		[HarmonyPatch(typeof(uGUI_OptionsPanel), "AddGeneralTab")]
		private class AddGeneralTab_Patch
		{
			// Token: 0x06000013 RID: 19 RVA: 0x00002708 File Offset: 0x00000908
			private static void Postfix(uGUI_OptionsPanel __instance)
			{
				if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && Environment.ProcessorCount >= 5)
				{
					__instance.AddHeading(MainPatcher.generalTabIndex, "CPU Cores Adjustment");
					__instance.AddToggleOption(MainPatcher.generalTabIndex, "Enabled", MainPatcher.affinityTweakEnabled, delegate(bool v)
					{
						MainPatcher.affinityTweakEnabled = v;
						MainPatcher.SetAffinity(MainPatcher.CPUCores);
					}, null);
					__instance.AddChoiceOption<int>(MainPatcher.generalTabIndex, "CPU Cores", new int[] { 2, 3, 4 }, MainPatcher.CPUCores, new UnityAction<int>(MainPatcher.OnCPUCoresChanged), null);
				}
			}
		}

		// Token: 0x0200000A RID: 10
		[HarmonyPatch(typeof(GameSettings), "SerializeGraphicsSettings")]
		private class SerializeGraphicsSettings_Patch
		{
			// Token: 0x06000015 RID: 21 RVA: 0x000027B0 File Offset: 0x000009B0
			private static void Postfix(GameSettings.ISerializer serializer)
			{
				QualitySettings.lodBias = serializer.Serialize("Graphics/LODBias", QualitySettings.lodBias);
				QualitySettings.shadowDistance = serializer.Serialize("Graphics/ShadowDistance", QualitySettings.shadowDistance);
				QualitySettings.shadowCascades = serializer.Serialize("Graphics/ShadowCascades", QualitySettings.shadowCascades);
				QualitySettings.shadowResolution = (ShadowResolution)serializer.Serialize("Graphics/ShadowResolution", (int)QualitySettings.shadowResolution);
				QualitySettings.masterTextureLimit = serializer.Serialize("Graphics/TextureQuality", QualitySettings.masterTextureLimit);
				MainPatcher.setSunShaftQuality(serializer.Serialize("Graphics/SunShaftQuality", MainPatcher.sunShaftQuality));
				MainPatcher.underwaterFarClipPlane = serializer.Serialize("Graphics/UWFarClipPlane", MainPatcher.underwaterFarClipPlane);
				MainPatcher.aboveWaterFarClipPlane = serializer.Serialize("Graphics/AWFarClipPlane", MainPatcher.aboveWaterFarClipPlane);
				MainPatcher.affinityTweakEnabled = serializer.Serialize("General/AffinityTweak", MainPatcher.affinityTweakEnabled);
				MainPatcher.SetAffinity(serializer.Serialize("General/CPUCores", MainPatcher.CPUCores));
			}
		}
	}
}
