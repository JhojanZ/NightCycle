using DevInterface;
using Menu.Remix.MixedUI;
using Menu.Remix.MixedUI.ValueTypes;
using RWCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace NightCycle
{

    public class RemixInterfaze : OptionInterface
    {
        // TO DO: this code...
        // A button for random times

        public readonly Configurable<bool> RandomCycle;

        public RemixInterfaze(NightCycleMain plugins)
        {
            RandomCycle = config.Bind("PushToMeow_AlternateRivuletSound", false);
        }

        public override void Initialize()
        {
            OpTab mainTab = new OpTab(this, "Main");
            Tabs = new OpTab[] { mainTab };

            OpContainer tab1Container = new OpContainer(new Vector2(0, 0));
            mainTab.AddItems(tab1Container);

            UIelement[] opts = new UIelement[]
            {
                new OpCheckBox(RandomCycle, 10, 570 - 30),
            };

            mainTab.AddItems(opts);
        }

    }
}