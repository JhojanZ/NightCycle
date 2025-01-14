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

        public RemixInterfaze(Main plugins)
        {
            RandomCycle = config.Bind("Random_Cycles", false);
        }

        public override void Initialize()
        {
            // A pesar de que se declara el tab, no se muestra
            OpTab mainTab = new OpTab(this, "Main");
            Tabs = new OpTab[] { mainTab };

            OpContainer tab1Container = new OpContainer(new Vector2(0, 0));
            mainTab.AddItems(tab1Container);

            UIelement[] opts = new UIelement[]
            {
                new OpCheckBox(RandomCycle, 10, 540){description = "Add random day cicles" },
                new OpLabel(50, 540, "Random Cycles")
            };

            mainTab.AddItems(opts);
        }

    }
}