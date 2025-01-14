﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using Verse;

namespace RimConnection
{
    class ManhunterPackAction : Action
    {
        public ManhunterPackAction()
        {
            Name = "Manhunter Pack";
            Description = "They hunger for man-flesh";
            Category = "Event";
            Prefix = "Trigger";
        }

        public override void Execute(int amount, string boughtBy)
        {
            var currentMap = Find.CurrentMap;

            var parms = StorytellerUtility.DefaultParmsNow(IncidentCategoryDefOf.ThreatBig, currentMap);
            parms.forced = true;
            var manhunterWorker = new IncidentWorker_ManhunterPack();
            manhunterWorker.def = IncidentDef.Named("ManhunterPack");

            manhunterWorker.TryExecute(parms);
            AlertManager.BadEventNotification("{0} sent a Manhunter Pack!", boughtBy);

        }
    }
}
