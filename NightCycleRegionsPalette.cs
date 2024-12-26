using System;
using System.Collections.Generic;
using RKMFP = RegionKit.API.MoreFadePalettes;

namespace NightCycle
{
    public static class NightCycleRegionsPalette
    {
        public static bool TryGetValue(string key, out Action<Room> action)
        {
            return actions.TryGetValue(key, out action);
        }


        private static Dictionary<string, Action<Room>> actions = new Dictionary<string, Action<Room>>
        {
            { "GATE", (self) =>
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
            },
            { "SU", (self) =>
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
            },
            { "SI", (self) =>
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
            },
            { "DS", (self) =>
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
            },
            { "HI", (self) =>
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
            },
            { "CC", (self) =>
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
            },
            { "GW", (self) =>
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
            },
            { "SL", (self) =>
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
            },
            { "LF", (self) =>
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
            },
            { "UW", (self) =>
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
            },
            { "SB", (self) =>
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
            },
            { "SH", (self) =>
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
            },
            { "SS", (self   ) =>
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
            },
            { "RM", (self) =>
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
            },
            { "DM", (self) =>
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
            },
            { "LM", (self   ) =>
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
            },
            { "MS", (self) =>
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
            },
            { "OE", (self) =>
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
            },
            { "VS", (self) =>
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
            },
            { "LC", (self) =>
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
            },
            { "UG", (self) =>
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
            },
            { "CL", (self   ) =>
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
            },
            { "CW", (self) =>
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
        };
    }
}
