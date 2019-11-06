﻿using RimWorld;
using System.Collections.Generic;
using Verse;

namespace RimConnection
{
    class DropPodManager
    {
        public static void createDropFromDef(ThingDef thingDef, int amount, string title, string desc, bool showMessage = true)
        {
            Thing newthing = ThingMaker.MakeThing(thingDef);
            newthing.stackCount = amount;
            if(newthing != null)
            {

                var currentMap = Find.CurrentMap;
                IntVec3 dropVector = DropCellFinder.TradeDropSpot(Find.CurrentMap);
                TradeUtility.SpawnDropPod(dropVector, currentMap, newthing);

                if (showMessage)
                {
                    string labelString = "RimConnectionDroppodMailLabel".Translate();
                    string messageString = "RimConnectionPositiveDroppodMailBody".Translate(amount, title, desc);
                    Find.LetterStack.ReceiveLetter(labelString, messageString, LetterDefOf.PositiveEvent, new TargetInfo(dropVector, currentMap));
                }
            }
        }

        public static void createDropOfThings(List<Thing> things, string title, string desc, bool showMessage = true)
        {
            if (things.Count > 0)
            {

                var currentMap = Find.CurrentMap;
                IntVec3 dropVector = DropCellFinder.TradeDropSpot(Find.CurrentMap);
                DropPodUtility.DropThingsNear(dropVector, currentMap, things);

                if (showMessage)
                {
                    string labelString = "RimConnectionDroppodMailLabel".Translate();
                    string messageString = "RimConnectionPositiveDroppodMailBody".Translate("", title, desc);
                    Find.LetterStack.ReceiveLetter(labelString, messageString, LetterDefOf.PositiveEvent, new TargetInfo(dropVector, currentMap));
                }
            }
        }

    }
}
