using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Nautilus.Handlers;
using Debug = UnityEngine.Debug;
using BetterHUDInfo.Modules;

namespace BetterHUDInfo.InfoObjects
{
    public class ModInfo : MonoBehaviour
    {
        internal static GameObject staticGameObject;
        internal static string colorWhite = "<color=white>";
        internal static string colorLightGray = "<color=#bfbfbf>";
        internal static string colorDarkGray = "<color=#808080>";
        internal static string colorYellow = "<color=yellow>";
        internal static string colorBlue = "<color=blue>";
        internal static string colorRed = "<color=red>";
        internal static string colorEnd = "</color>";
        internal static string caps = "(<color=#ADF8FFFF>" + uGUI.GetDisplayTextForBinding("Caps") + "</color>)";
        internal static string shift = "(<color=#ADF8FFFF>" + uGUI.GetDisplayTextForBinding("Shift") + "</color>)";
        internal static string ctrl = "(<color=#ADF8FFFF>" + uGUI.GetDisplayTextForBinding("Ctrl") + "</color>)";
        internal static string alt = "(<color=#ADF8FFFF>" + uGUI.GetDisplayTextForBinding("Alt") + "</color>)";
        
        // Static fields for UI texts
        internal static Text timeDisplayText;
        internal static Text oxyDisplayText;

        // Static fields for various parameters
        internal static float timer;
        internal static float fadeTimer = 0f;
        internal static float fadeTimerStop = 2f;
        internal static bool changeShowing = false;
        internal static bool PlayerIsFree = false;
        internal static bool PlayerInVehicle = false;
        internal static bool PlayerInCyclopsFree = false;
        internal static bool PlayerInCyclopsPiloting = false;
        internal static bool PlayerInCyclopsCamera = false;
        internal static bool PlayerInBaseFree = false;
        internal static bool PlayerInBaseCamera = false;
        internal static bool CompassIsAdjusted = false;
        internal static bool ChipInserted = false;
        internal static float MoveCompassDown = Mathf.Floor(BetterHUDInfo.Configuration.Config.MoveCompassSliderValue);
        internal static float CompassSteady = 0f;
        internal static float HUDTimeOxy_H = -190f;
        internal static float HUDTimeOxy_V = 463f;
        internal static float HUDTimeOxyPilot_H = -240f;
        internal static float HUDTimeOxyPilot_V = 443f;
        internal static float HUDTimeOxyTxt_H = -190f;
        internal static float HUDTimeOxyTxt_V = 453f;
        internal static float HUDTimeOxyTxtPilot_H = 50f;
        internal static float HUDTimeOxyTxtPilot_V = 0f;
        internal static float HullPowerTemp_H = 705f;
        internal static float HullPowerTemp_V = -350f;
        internal static float FontPlus = 5f;
        internal static float ScanDot_H = 0f;
        internal static float ScanDot_V = 0f;
        internal static float TotalRotation = 0f;
        internal static bool MoveToRight = true;
        internal static bool StopAtZero = false;
        internal static bool ObjectLock = false;
        internal static string TargetName;
        internal static bool ScannerIsOn = false;
        
        // Static fields for SeaMoth and its components
        internal static SeaMoth seaMothTemplate;
        internal static ToggleLights toggleLights;
        internal static FMOD_StudioEventEmitter lightsOnSound;
        internal static FMOD_StudioEventEmitter lightsOffSound;

        // Static fields for UI positioning and sizing
        internal static Vector3 MainOutBackground_Position = new Vector3(0f, 507f, 0f);
        internal static Vector2 MainOutBackground_Size = new Vector2(550f, 60f);
        internal static Vector3 MainOutBackPilot_Position = new Vector3(0f, 515f, 0f);
        internal static Vector2 MainOutBackPilot_Size = new Vector2(690f, 45f);
        internal static Vector3 MainOutBackCamera_Position = new Vector3(0f, 525f, 0f);
        internal static Vector2 MainOutBackCamera_Size = new Vector2(550f, 35f);
        internal static Vector3 TimeOutBackground_Position = new Vector3(HUDTimeOxy_H, HUDTimeOxy_V, 0f);
        internal static Vector2 TimeOutBackground_Size = new Vector2(156f, 95f);
        internal static Vector3 TimePilotBackground_Position = new Vector3(HUDTimeOxyPilot_H, HUDTimeOxyPilot_V, 0f);
        internal static Vector2 TimePilotBackground_Size = new Vector2(170f, 55f);
        internal static Vector3 OxyOutBackground_Position = new Vector3(HUDTimeOxy_H, HUDTimeOxy_V, 0f);
        internal static Vector2 OxyOutBackground_Size = new Vector2(156f, 95f);
        internal static Vector3 OxyPilotBackground_Position = new Vector3(HUDTimeOxyPilot_H, HUDTimeOxyPilot_V, 0f);
        internal static Vector2 OxyPilotBackground_Size = new Vector2(170f, 55f);
        internal static Vector3 CameraTemperatureBackground_Position = new Vector3(0f, -470f, 0f);
        internal static Vector2 CameraTemperatureBackground_Size = new Vector2(272f, 78f);
        internal static Vector3 ScanDot_Position = new Vector3(ScanDot_H, ScanDot_V, 0f);
        internal static Vector2 ScanDot_Size = new Vector2(80f, 80f);
        internal static Vector3 LockBeam_Position = new Vector3(480f, -270f, 0f);
        internal static Vector2 LockBeam_Size = new Vector2(960f, 540f);
        internal static float ControlBackground_x = 660f;
        internal static float ControlBackground_y = -464f;
        internal static Vector3 HUD_ControlBackground_Position = new Vector3(ControlBackground_x, ControlBackground_y, 0f);
        internal static Vector2 HUD_ControlBackground_Size = new Vector2(300f, 90f);
        internal static float Controls_x = 568f;
        internal static float Controls_y = -460f;
        internal static Vector3 HUD_ControlsOnOff_Position = new Vector3(Controls_x, Controls_y, 0f);
        internal static Vector2 HUD_ControlsOnOff_Size = new Vector2(60f, 25f);
        internal static Vector3 CyclopsCamHealth_Position = new Vector3(-572f, -304f, 0f);
        internal static Vector2 CyclopsCamHealth_Size = new Vector2(214f, 80f);
        internal static Vector3 CyclopsCamPower_Position = new Vector3(572f, -304f, 0f);
        internal static Vector2 CyclopsCamPower_Size = new Vector2(210f, 80f);
        internal static Vector3 TimeText_Position = new Vector3(HUDTimeOxyTxt_H, HUDTimeOxyTxt_V, 0f);
        internal static Vector2 TimeText_Size = new Vector2(160f, 60f);
        internal static Vector3 OxyText_Position = new Vector3(-1f * HUDTimeOxyTxt_H, HUDTimeOxyTxt_V, 0f);
        internal static Vector2 OxyText_Size = new Vector2(160f, 60f);
        internal static Vector3 ScannerText_Position = new Vector3(0f, 80f, 0f);
        internal static Vector2 ScannerText_Size = new Vector2(300f, 80f);
        internal static Vector3 CameraTemperText_Position = new Vector3(45f, -475f, 0f);
        internal static Vector2 CameraTemperText_Size = new Vector2(300f, 80f);
        internal static Vector3 HUD_ControlText_Position = new Vector3(741f, -551f, 0f);
        internal static Vector3 HUD_ControlText_ExoPos = new Vector3(731f, -557f, 0f);
        internal static Vector2 HUD_ControlText_Size = new Vector2(400f, 150f);
        internal static Vector3 CyclopsCamHealthText_Position = new Vector3(-550f, -300f, 0f);
        internal static Vector2 CyclopsCamHealthText_Size = new Vector2(160f, 60f);
        internal static Vector3 CyclopsCamPowerText_Position = new Vector3(600f, -300f, 0f);
        internal static Vector2 CyclopsCamPowerText_Size = new Vector2(160f, 60f);
        internal static Vector3 HullDescText_Position = new Vector3(620f, -370f, 0f);
        internal static Vector2 HullDescText_Size = new Vector2(150f, 50f);
        internal static Vector3 PowerDescText_Position = new Vector3(795f, -343f, 0f);
        internal static Vector2 PowerDescText_Size = new Vector2(150f, 50f);
        internal static Vector3 TemperDescText_Position = new Vector3(780f, -409f, 0f);
        internal static Vector2 TemperDescText_Size = new Vector2(150f, 50f);
        internal static Vector3 HUD_ControlDescText_Position = new Vector3(665f, -435f, 0f);
        internal static Vector3 HUD_ControlDescExoText_Position = new Vector3(665f, -441f, 0f);
        internal static Vector2 HUD_ControlDescText_Size = new Vector2(200f, 50f);
        internal static Vector3 LockBeamText_Position = new Vector3(480f, -200f, 0f);
        internal static Vector2 LockBeamText_Size = new Vector2(960f, 540f);
        internal static Vector3 HUD_ChangeText_Position = new Vector3(0f, -120f, 0f);
        internal static Vector2 HUD_ChangeText_Size = new Vector2(400f, 80f);
        public static void CheckChipStatus(Player main)
        {
            Inventory main2 = Inventory.main;
            ModInfo.ChipInserted = main2.equipment.GetCount(EnhancedHUDChip.TechTypeID) > 0;
        }
        private void Start()
        {
            // Asynchronous initialization
            InitializeAsync().ConfigureAwait(false);
        }

        private async System.Threading.Tasks.Task InitializeAsync()
        {
            seaMothTemplate = await GetSeaMothAsync();

            if (seaMothTemplate != null)
            {
                toggleLights = seaMothTemplate.toggleLights;
                lightsOnSound = toggleLights.lightsOnSound;
                lightsOffSound = toggleLights.lightsOffSound;
                Debug.Log("SeaMoth template initialized successfully.");
            }
            else
            {
                Debug.LogError("Failed to initialize SeaMoth template.");
            }
        }

        public Task<SeaMoth> GetSeaMothAsync()
        {
            var tcs = new TaskCompletionSource<SeaMoth>();
            StartCoroutine(GetGameObjectCoroutine(tcs));
            return tcs.Task;
        }

        private IEnumerator GetGameObjectCoroutine(TaskCompletionSource<SeaMoth> tcs)
        {
            CoroutineTask<GameObject> task = CraftData.GetPrefabForTechTypeAsync(TechType.Seamoth);
            yield return task;
            GameObject prefab = task.GetResult();
            GameObject obj = GameObject.Instantiate(prefab);
            prefab.SetActive(false);

            obj.SetActive(true);

            SeaMoth seaMoth = obj.GetComponent<SeaMoth>();
            tcs.SetResult(seaMoth);
        }
    }
}
