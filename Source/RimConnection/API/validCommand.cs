﻿using System.Collections.Generic;

#pragma warning disable IDE1006 // Naming Styles
namespace RimConnection
{
    public class ValidCommand
    {
        public string actionHash { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string prefix { get; set; }
        public bool shouldShowAmount { get; set; }
        public int localCooldownMs { get; set; }
        public int globalCooldownMs { get; set; }
        public int costSilverStore { get; set; }
        public string bitStoreSKU { get; set; }

        public CommandOption toCommandOption()
        {
            return new CommandOption()
            {
                actionHash = actionHash,
                localCooldownMs = localCooldownMs,
                globalCooldownMs = globalCooldownMs,
                costSilverStore = costSilverStore
            };
        }
    }

    public class ValidCommandList
    {
        public List<ValidCommand> validCommands { get; set; }
    }
}