﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;

namespace RimConnection
{
    class GoldAction : Action
    {
        public GoldAction()
        {
            this.name = "Gold";
            this.description = "All that glitters is not gold, but this is!";
            this.canSpawnMultiple = true;
            this.category = "Resources";
        }

        public override void execute(int amount)
        {
            DropPodManager.createDropFromDef(ThingDefOf.Gold, amount, name, description);
        }
    }
}
