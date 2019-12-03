﻿namespace Rescues
{
    public sealed class GameSystemsController : GameStateController
    {
        #region ClassLifeCycles
        
        public GameSystemsController(GameContext context, Services services)
        {
            AddUpdateFeature(new MainControllers(context, services));
        }

        #endregion
    }
}
