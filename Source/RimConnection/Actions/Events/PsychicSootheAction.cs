﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using Verse;

namespace RimConnection
{
    class PsychicSootheAction : Action
    {
        public PsychicSootheAction()
        {
            this.name = "Psychic Soothe";
            this.description = "Why doesn't everyone just like, chill out";
            this.category = "Event";
        }

        public override void Execute(int amount)
        {
            var currentMap = Find.CurrentMap;

            var parms = StorytellerUtility.DefaultParmsNow(IncidentCategoryDefOf.ThreatBig, currentMap);
            parms.forced = true;

            var worker = new IncidentWorker_PsychicSoothe();
            worker.def = IncidentDef.Named("PsychicSoothe");

            worker.TryExecute(parms);
        }
    }
}
