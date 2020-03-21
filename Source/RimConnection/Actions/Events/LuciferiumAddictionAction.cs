﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using Verse;

namespace RimConnection
{
    class LuciferiumAddictionAction : Action
    {
        public LuciferiumAddictionAction()
        {
            name = "Luciferium Addction";
            description = "I don't where the colonists picked this up from";
            category = "Event";
        }

        public override void Execute(int amount)
        {
            var amountMultiplier = 10;
            var colonists = Find.ColonistBar.GetColonistsInOrder();

            var luciferiumBenefitHeDiffDef = DefDatabase<HediffDef>.GetNamed("LuciferiumHigh");
            var luciferiumAdditictionHeDiffDef = DefDatabase<HediffDef>.GetNamed("LuciferiumAddiction");

            colonists.ForEach(colonist =>
            {
                colonist.health.AddHediff(luciferiumBenefitHeDiffDef);
                colonist.health.AddHediff(luciferiumAdditictionHeDiffDef);
            });

            var amountToDrop = colonists.Count() * amountMultiplier;
            DropPodManager.createDropFromDef(ThingDefOf.Luciferium, amountToDrop, name, "Your luciferium stock, this should last you for about half a year");

            AlertManager.NormalEventNotification("Your viewers decided that everyone should have a life threatening addiction, along with some supplies");
        }
    }
}
