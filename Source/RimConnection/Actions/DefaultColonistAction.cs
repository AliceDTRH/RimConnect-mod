﻿namespace RimConnection
{
    class DefaultColonistAction : Action
    {
        public DefaultColonistAction()
        {
            this.name = "Generic Colonist";
            this.description = "You don't like me, but I like you. Maybe you could grow to like me?";
        }

        public override void execute(int amount)
        {
            PawnCreationManager.spawnDefaultColonist(1, name, description);
        }
    }
}