﻿using RimWorld;

namespace RimConnection
{
    class CoolerAction : Action
    {
        public CoolerAction()
        {
            this.name = "Cooler";
            this.description = "Time to chill out";
        }

        public override void execute(int amount)
        {
            DropPodManager.createDrop(ThingDefOf.Cooler, 1, name, description);
        }
    }
}
