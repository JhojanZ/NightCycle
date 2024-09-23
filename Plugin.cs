using System;
using BepInEx;
using BepInEx.Logging;
using MonoMod.RuntimeDetour;

namespace NightCycle
{
    [BepInPlugin(MOD_ID, MOD_NAME, MOD_VER)]
    public class Plugin : BaseUnityPlugin
    {
        private const string MOD_ID = "qtpi.nightcycle";
        private const string MOD_NAME = "NightCycle";
        private const string MOD_VER = "0.1.0";

        internal static ManualLogSource s_logger;

        internal static NightCycleEnums.CycleTime cycleTime;

        public void OnEnable()
        {
            Plugin.s_logger = base.Logger;

            try
            {
                On.RainWorld.OnModsInit += NightCycleHooks.RainWorldOnOnModsInit;
            }
            catch (Exception ex)
            {
                s_logger.LogError(ex);
            }
        }
    }
}
