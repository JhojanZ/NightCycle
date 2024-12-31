using System;
using static NightCycle.NightCycleEnums;

namespace NightCycle.Utils
{
    public static class Helper
    {

        public static RemixInterfaze RemixOptions;
        private static readonly Random random = new Random();


        private static readonly NightCycleEnums.CycleTime[] CycleTimes =
        {
            NightCycleEnums.CycleTime.Day,
            NightCycleEnums.CycleTime.Dusk,
            NightCycleEnums.CycleTime.Night
        };

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
                if (RemixOptions.RandomCycle.Value)
                {
                    int randomIndex = random.Next(0, CycleTimes.Length); // Genera un número aleatorio entre 0 y 2
                    NightCycleMain.cycleTime = CycleTimes[randomIndex];
                    string debug = $"**** {randomIndex} - {NightCycleMain.cycleTime}";
                    UnityEngine.Debug.Log(debug);
                }
                else
                {
                    NightCycleMain.cycleTime = CycleTimes[game.GetStorySession.saveState.cycleNumber % CycleTimes.Length];
                    string debug = $"||| - {NightCycleMain.cycleTime}";
                    UnityEngine.Debug.Log(debug);
                }
            }
            
                
        }
    }
}
