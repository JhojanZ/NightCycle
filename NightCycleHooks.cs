using System;
using System.Diagnostics;
using NightCycle.Utils;

namespace NightCycle
{
    public class NightCycleHooks
    {
        private static bool _modsInit;

        public static RemixInterfaze RemixOptions;

        private static NightCycleMain _nightCycleMain;


        public static void Initialize(NightCycleMain nightCycleMain)
        {
            _nightCycleMain = nightCycleMain;
        }

        public static void RainWorldOnOnModsInit(On.RainWorld.orig_OnModsInit initOrig, RainWorld initSelf)
        {
            initOrig(initSelf);
            if (_modsInit) return;

            RemixOptions = new RemixInterfaze(_nightCycleMain);
            MachineConnector.SetRegisteredOI("qtpi.felipe.nightcycle", RemixOptions);

            try
            {
                _modsInit = true;
                On.World.ctor += Helper.WorldCtor;
                On.Room.Loaded += Room_Loaded;
                On.RainCycle.Update += RainCycle_Update;
            }
            catch (Exception ex)
            {
                NightCycleMain.s_logger.LogError(ex);
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

            string place = Helper.GetPlace(self.abstractRoom.name);

            // found the word in the map
            if (RegionsPalette.TryGetValue(place, out var action))
            {
                action(self);
                Debug.WriteLine("the place is: ", place); // Changed from Debug.Log to Debug.WriteLine
            }
            else
            {
                Console.WriteLine("No action found for " + place);
            }
        }
    }
}
