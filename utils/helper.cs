using System;
using BepInEx;
using static NightCycle.Enums;

namespace NightCycle.Utils
{
    public static class Helper
    {

        public static RemixInterfaze RemixOptions;
        public static int dayRandom;
        public static int secion;
        private static readonly Random random = new Random();


        private static readonly Enums.CycleTime[] CycleTimes =
        {
            Enums.CycleTime.Day,
            Enums.CycleTime.Dusk,
            Enums.CycleTime.Night
        };

        public static string GetPlace(string region)
        {
            int index = region.IndexOf('_');
            return index >= 0 ? region.Substring(0, index) : "";
        }

        public static void ChangeRand(RainWorldGame game)
        {
            if (game.GetStorySession.saveState.cycleNumber != secion)
            {
                secion = game.GetStorySession.saveState.cycleNumber;
                dayRandom = random.Next(0, CycleTimes.Length); // Genera un número aleatorio entre 0 y 2
            }
        }

        //Sospecho de que
        public static void WorldCtor(On.World.orig_ctor orig, World self, RainWorldGame game, Region region, string name, bool singleRoomWorld)
        {
            orig(self, game, region, name, singleRoomWorld);
            if (game != null && game.IsStorySession)
            {
                if (RemixOptions.RandomCycle.Value)
                {
                    Main.cycleTime = CycleTimes[dayRandom];
                    ChangeRand(game);
                    UnityEngine.Debug.Log($"**** {dayRandom} - {Main.cycleTime} || {game.GetStorySession.saveState.cycleNumber} -> {secion}");
                }
                else
                {
                    Main.cycleTime = CycleTimes[game.GetStorySession.saveState.cycleNumber % CycleTimes.Length];
                    UnityEngine.Debug.Log($"||| - {Main.cycleTime}");
                }
            }
            
            
        }
    }
}
