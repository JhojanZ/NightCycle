using System;
using System.Linq;
using JetBrains.Annotations;
using RegionKit.API;
using RKMFP = RegionKit.API.MoreFadePalettes;

namespace NightCycle
{
    public class NightCycleHooks
    {

        private static bool _modsInit;
        public static void RainWorldOnOnModsInit(On.RainWorld.orig_OnModsInit initOrig, RainWorld initSelf)
        {
            initOrig(initSelf);
            if (_modsInit) return;

            try
            {
                _modsInit = true;
                On.World.ctor += World_ctor;
                On.Room.ctor += Room_ctor;
            }
            catch (Exception ex)
            {
                Plugin.s_logger.LogError(ex);
            }
        }

        private static void Room_ctor(On.Room.orig_ctor orig, Room self, RainWorldGame game, World world, AbstractRoom abstractRoom)
        {
            orig(self, game, world, abstractRoom);
            if (world?.region != null && abstractRoom.name.StartsWith("SU_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, null);
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88880, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.75f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(10, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.75f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
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
                    Plugin.cycleTime = NightCycleEnums.CycleTime.Day;
                }
                if ((game.GetStorySession.saveState.cycleNumber % 3) == 1)
                {
                    Plugin.cycleTime = NightCycleEnums.CycleTime.Dusk;
                }
                if ((game.GetStorySession.saveState.cycleNumber % 3) == 2)
                {
                    Plugin.cycleTime = NightCycleEnums.CycleTime.Night;
                }
            }
        }
    }
}
