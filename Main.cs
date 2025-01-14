using System;
using BepInEx;
using BepInEx.Logging;
using MonoMod.RuntimeDetour;

namespace NightCycle
{
    [BepInPlugin(MOD_ID, MOD_NAME, MOD_VER)]
    public class Main : BaseUnityPlugin
    {
        private const string MOD_ID = "qtpi.felipe.nightcycle";
        private const string MOD_NAME = "NightCycle";
        private const string MOD_VER = "0.1.1";

        internal static ManualLogSource s_logger;

        internal static Enums.CycleTime cycleTime;
            
        public void OnEnable()
        {
            Main.s_logger = base.Logger;
            Hooks.Initialize(this);
        

            try
            {
                On.RainWorld.OnModsInit += Hooks.RainWorldOnOnModsInit;
            }
            catch (Exception ex)
            {
                s_logger.LogError(ex);
            }
        }
    }
}
