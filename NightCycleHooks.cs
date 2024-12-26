using System;

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
                On.Room.Loaded += Room_Loaded;
                On.RainCycle.Update += RainCycle_Update;
            }
            catch (Exception ex)
            {
                Plugin.s_logger.LogError(ex);
            }
        }

        
        private static void RainCycle_Update(On.RainCycle.orig_Update orig, RainCycle self)
        {
            orig(self);
            self.dayNightCounter = 0;
        }

        private static void Room_Loaded(On.Room.orig_Loaded orig, Room self)
        {
            orig(self);
            if (self.world?.region == null) return;

            string place = getPlace(self.abstractRoom.name);

            // found the word in the map
            if (NightCycleRegionsPalette.TryGetValue(place, out var action))
            {
                action(self);
            }
            else
            {
                Console.WriteLine("No action found for " + place);
            }
        }

        public static string getPlace(string region)
        {
            int index = region.IndexOf('_');
            return index >= 0 ? region.Substring(0, index) : "";
        }

        private static void World_ctor(On.World.orig_ctor orig, World self, RainWorldGame game, Region region, string name, bool singleRoomWorld)
        {
            orig(self, game, region, name, singleRoomWorld);
            if (game != null && game.IsStorySession)
            {
                switch (game.GetStorySession.saveState.cycleNumber % 3)
                {
                    case 0:
                        Plugin.cycleTime = NightCycleEnums.CycleTime.Day;
                        break;
                    case 1:
                        Plugin.cycleTime = NightCycleEnums.CycleTime.Dusk;
                        break;
                    case 2:
                        Plugin.cycleTime = NightCycleEnums.CycleTime.Night;
                        break;
                }
            }
        }
    }
}



