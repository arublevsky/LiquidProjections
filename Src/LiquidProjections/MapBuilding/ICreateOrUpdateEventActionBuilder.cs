﻿using System;
using System.Threading.Tasks;

namespace LiquidProjections.MapBuilding
{
    /// <summary>
    /// Allows to configure event map how to handle projection creation or updating
    /// for events of type <typeparamref name="TEvent"/> and projections of type <typeparamref name="TProjection"/>
    /// using context <typeparamref name="TContext"/>.
    /// </summary>
    public interface ICreateOrUpdateEventActionBuilder<TEvent, TProjection, out TContext>
    {
        /// <summary>
        /// Finishes configuring a projection creation or updating handler.
        /// </summary>
        /// <param name="projector">
        /// The asynchronous delegate that initializes the created projection or updates the existing projection.
        /// Takes the projection, the event and the context as the parameters.
        /// </param>
        void Using(Func<TProjection, TEvent, TContext, Task> projector);
    }
}