﻿namespace RimConnection
{
    class AwfulColonistAction : Action
    {

        public AwfulColonistAction()
        {
            this.name = "Awful Colonist";
            this.description = "Well, they might be useful for parts....";
        }

        public override void execute(int amount)
        {
            PawnCreationManager.SpawnAwfulColonist(1, name, description);
        }
    }
}