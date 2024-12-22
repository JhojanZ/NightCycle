using System;
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
            if (self.world?.region != null && self.abstractRoom.name.StartsWith("GATE_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(26, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.1f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Bloom, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.6f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(10, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.6f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.4f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("SU_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88800, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Bloom, 0.2f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(88801, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.9f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.FireFlies, 0.2f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("SI_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88802, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(88803, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.9f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Desaturation, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Hue, 0.95f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("DS_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88804, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(10, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Desaturation, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Flies, 0.3f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("HI_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88805, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Bloom, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(10, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.85f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Desaturation, 0.2f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("CC_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88806, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Bloom, 0.4f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(10, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.75f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.FireFlies, 0.4f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Desaturation, 0.2f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("GW_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88807, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Bloom, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.WaterGlowworm, 0.1f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(88808, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.9f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Desaturation, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.FireFlies, 0.4f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.WaterGlowworm, 0.2f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("SL_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88809, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.75f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Bloom, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.WaterGlowworm, 0.2f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(88803, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.9f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Desaturation, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.WaterGlowworm, 0.4f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("LF_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88810, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.FireFlies, 0.2f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(10, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.8f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.FireFlies, 0.4f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("UW_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                if (self.abstractRoom.subregionName == "The Leg" || self.abstractRoom.subregionName == "Underhang")
                {
                    switch (Plugin.cycleTime)
                    {
                        case NightCycleEnums.CycleTime.Day:
                            break;

                        case NightCycleEnums.CycleTime.Dusk:
                            newFade = new(88811, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.6f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                            break;

                        case NightCycleEnums.CycleTime.Night:
                            newFade = new(10, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.6f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                            break;
                    }
                }
                if (self.abstractRoom.subregionName == "The Wall")
                {
                    switch (Plugin.cycleTime)
                    {
                        case NightCycleEnums.CycleTime.Day:
                            break;

                        case NightCycleEnums.CycleTime.Dusk:
                            newFade = new(88812, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.6f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                            break;

                        case NightCycleEnums.CycleTime.Night:
                            newFade = new(10, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.6f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                            break;
                    }
                }
                else
                {
                    switch (Plugin.cycleTime)
                    {
                        case NightCycleEnums.CycleTime.Day:
                            break;

                        case NightCycleEnums.CycleTime.Dusk:
                            newFade = new(88813, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.4f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.4f, false));
                            break;

                        case NightCycleEnums.CycleTime.Night:
                            newFade = new(10, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.6f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                            break;
                    }
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("SB_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88814, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.65f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.FireFlies, 0.05f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        if (self.abstractRoom.name.StartsWith("SB_F03") || self.abstractRoom.name.StartsWith("SB_TOPSIDE"))
                        {
                            newFade = new(10, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.8f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.FireFlies, 0.1f, false));
                            break;
                        }
                        else
                        {
                            newFade = new(10, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.95f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.FireFlies, 0.1f, false));
                            break;
                        }
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("SH_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(26, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.025f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.6f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(10, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.6f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("SS_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                if (self.abstractRoom.name.StartsWith("SS_D08") || self.abstractRoom.name.StartsWith("SS_E08") || self.abstractRoom.name.StartsWith("SS_S04"))
                {
                    switch (Plugin.cycleTime)
                    {
                        case NightCycleEnums.CycleTime.Day:
                            break;

                        case NightCycleEnums.CycleTime.Dusk:
                            newFade = new(26, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.1f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.6f, false));
                            break;

                        case NightCycleEnums.CycleTime.Night:
                            newFade = new(10, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.6f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);

                            break;
                    }
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("RM_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                if (self.abstractRoom.name.StartsWith("RM_D08") || self.abstractRoom.name.StartsWith("RM_E08") || self.abstractRoom.name.StartsWith("RM_S04"))
                {
                    switch (Plugin.cycleTime)
                    {
                        case NightCycleEnums.CycleTime.Day:
                            break;

                        case NightCycleEnums.CycleTime.Dusk:
                            newFade = new(26, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.1f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.6f, false));
                            break;

                        case NightCycleEnums.CycleTime.Night:
                            newFade = new(10, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.6f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);

                            break;
                    }
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("DM_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                if (self.abstractRoom.name.StartsWith("DM_ROOF") || self.abstractRoom.name.StartsWith("DM_WALL") || self.abstractRoom.name.StartsWith("DM_TEMPLE") || self.abstractRoom.name.StartsWith("DM_VISTA") || self.abstractRoom.name.StartsWith("DM_STOP"))
                {
                    switch (Plugin.cycleTime)
                    {
                        case NightCycleEnums.CycleTime.Day:
                            break;

                        case NightCycleEnums.CycleTime.Dusk:
                            newFade = new(26, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.2f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.6f, false));
                            break;

                        case NightCycleEnums.CycleTime.Night:
                            newFade = new(10, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.6f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);

                            break;
                    }
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("LM_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88809, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.WaterGlowworm, 0.2f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(88803, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.8f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Desaturation, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.4f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.WaterGlowworm, 0.4f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("MS_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(26, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.4f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.4f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(10, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.8f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Desaturation, 0.2f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("OE_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                if (self.abstractRoom.subregionName == "Sunken Pier")
                {
                    switch (Plugin.cycleTime)
                    {
                        case NightCycleEnums.CycleTime.Day:
                            break;

                        case NightCycleEnums.CycleTime.Dusk:
                            newFade = new(88816, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.2f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.6f, false));
                            break;

                        case NightCycleEnums.CycleTime.Night:
                            newFade = new(10, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.6f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                            break;
                    }
                }
                else
                {
                    switch (Plugin.cycleTime)
                    {
                        case NightCycleEnums.CycleTime.Day:
                            break;

                        case NightCycleEnums.CycleTime.Dusk:
                            newFade = new(88816, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.4f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.4f, false));
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.FireFlies, 0.2f, false));
                            break;

                        case NightCycleEnums.CycleTime.Night:
                            newFade = new(10, screenCount);
                            for (int i = 0; i < screenCount; i++)
                            {
                                newFade.fades[i] = 0.4f;
                            }
                            RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Desaturation, 0.2f, false));
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.6f, false));
                            self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.FireFlies, 0.4f, false));
                            break;
                    }
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("VS_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88815, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(88803, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Desaturation, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("LC_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(26, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.3f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.4f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(35, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.6f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Desaturation, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.6f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("UG_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(88804, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.2f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(10, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.7f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Desaturation, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Flies, 0.3f, false));
                        break;
                }
            }
            else if (self.world?.region != null && self.abstractRoom.name.StartsWith("CL_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(26, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.4f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.4f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(10, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.6f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);

                        break;
                }
            }
            else if (self.world?.region != null && !self.abstractRoom.name.StartsWith("CW_") && !self.abstractRoom.name.StartsWith("OL_"))
            {
                var screenCount = self.cameraPositions.Length;
                RoomSettings.FadePalette newFade;
                switch (Plugin.cycleTime)
                {
                    case NightCycleEnums.CycleTime.Day:
                        break;

                    case NightCycleEnums.CycleTime.Dusk:
                        newFade = new(26, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.1f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Bloom, 0.2f, false));
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.6f, false));
                        break;

                    case NightCycleEnums.CycleTime.Night:
                        newFade = new(10, screenCount);
                        for (int i = 0; i < screenCount; i++)
                        {
                            newFade.fades[i] = 0.6f;
                        }
                        RKMFP.SetExtraFadePalette(self.roomSettings, 1, newFade);
                        self.roomSettings.effects.Add(new RoomSettings.RoomEffect(RoomSettings.RoomEffect.Type.Darkness, 0.4f, false));
                        break;
                }
            }
        }

        private static void World_ctor(On.World.orig_ctor orig, World self, RainWorldGame game, Region region, string name, bool singleRoomWorld)
        {
            orig(self, game, region, name, singleRoomWorld);
            if (game  != null && game.IsStorySession)
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
