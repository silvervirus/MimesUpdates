using System;
using System.Reflection;
using BepInEx;
using FMOD;
using HarmonyLib;
using static OVRPlugin;

namespace StartWithEmptyHands
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    public class MainPatcher : BaseUnityPlugin
    {
        private const string
        MODNAME = "StartWithEmptyHands",
        AUTHOR = "Upgrader Cookay",
        GUID = "StartWithEmptyHands",
        VERSION = "1.0.0.0";
        public void Awake()
		{
			Harmony harmony = new Harmony("com.mimes.subnautica.startwithemptyhands");
			harmony.PatchAll(Assembly.GetExecutingAssembly());
		}
	}
}
