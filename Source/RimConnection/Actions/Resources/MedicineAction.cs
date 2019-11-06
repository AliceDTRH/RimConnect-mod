﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;

namespace RimConnection
{
    class MedicineAction : Action
    {
        public MedicineAction()
        {
            this.name = "Medicine";
            this.description = "Patch yourself up!";
            this.canSpawnMultiple = true;
            this.category = "Resources";
        }

        public override void execute(int amount)
        {
            DropPodManager.createDropFromDef(ThingDefOf.MedicineIndustrial, amount, name, description);
        }
    }
}
