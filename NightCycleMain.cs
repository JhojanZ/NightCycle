﻿using System;
using BepInEx;
using BepInEx.Logging;
using MonoMod.RuntimeDetour;

namespace NightCycle
{
    [BepInPlugin(MOD_ID, MOD_NAME, MOD_VER)]
    public class NightCycleMain : BaseUnityPlugin
    {
        private const string MOD_ID = "qtpi.felipe.nightcycle";
        private const string MOD_NAME = "NightCycle";
        private const string MOD_VER = "0.1.1";

        internal static ManualLogSource s_logger;

        internal static NightCycleEnums.CycleTime cycleTime;

        public void OnEnable()
        {
            NightCycleMain.s_logger = base.Logger;
            NightCycleHooks.Initialize(this);
        

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
