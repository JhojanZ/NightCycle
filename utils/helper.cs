using System;

namespace NightCycle.Utils
{
    public static class Helper
    {
        public static string GetPlace(string region)
        {
            int index = region.IndexOf('_');
            return index >= 0 ? region.Substring(0, index) : "";
        }

        public static void WorldCtor(On.World.orig_ctor orig, World self, RainWorldGame game, Region region, string name, bool singleRoomWorld)
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
