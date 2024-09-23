using System;
using System.Linq;
using JetBrains.Annotations;
using RegionKit.API;
using RKMFP = RegionKit.API.MoreFadePalettes;

namespace NightCycle
{
    public class NightCycleHooks
    {
        internal static NightCycleEnums.CycleTime cycleTime;

        private static bool _modsInit;
        public static void RainWorldOnOnModsInit(On.RainWorld.orig_OnModsInit initOrig, RainWorld initSelf)
        {
            initOrig(initSelf);
            if (_modsInit) return;

            try
            {
                _modsInit = true;
                On.World.ctor += World_ctor;
                On.RoomSettings.ctor += RoomSettings_ctor;
            }
            catch (Exception ex)
            {
                Plugin.s_logger.LogError(ex);
            }
        }

        private static void RoomSettings_ctor(On.RoomSettings.orig_ctor orig, RoomSettings self, string name, Region region, bool template, bool firstTemplate, SlugcatStats.Name playerChar)
        {
            orig(self, name, region, template, firstTemplate, playerChar);
            if (self != null && self.name.StartsWith("SU_"))
            {
                RoomSettings.FadePalette newFade;
                switch (cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        RKMFP.SetExtraFadePalette(self, 1, null);
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88880, self.fadePalette.fades.Length);
                        for (int i = 0; i < self.fadePalette.fades.Length; i++)
                        {
                            newFade.fades[i] = 0.75f;
                        }
                        RKMFP.SetExtraFadePalette(self, 1, newFade);
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(10, self.fadePalette.fades.Length);
                        for (int i = 0; i < self.fadePalette.fades.Length; i++)
                        {
                            newFade.fades[i] = 0.75f;
                        }
                        RKMFP.SetExtraFadePalette(self, 1, newFade);
                        break;
                }
            }
        }

        private static void World_ctor(On.World.orig_ctor orig, World self, RainWorldGame game, Region region, string name, bool singleRoomWorld)
        {
            orig(self, game, region, name, singleRoomWorld);
            if (game  != null && game.IsStorySession)
            {
                if ((game.GetStorySession.saveState.cycleNumber % 3) == 0)
                {
                    cycleTime = NightCycleEnums.CycleTime.Day;
                }
                if ((game.GetStorySession.saveState.cycleNumber % 3) == 1)
                {
                    cycleTime = NightCycleEnums.CycleTime.Dusk;
                }
                if ((game.GetStorySession.saveState.cycleNumber % 3) == 2)
                {
                    cycleTime = NightCycleEnums.CycleTime.Night;
                }
            }
        }
    }
}
