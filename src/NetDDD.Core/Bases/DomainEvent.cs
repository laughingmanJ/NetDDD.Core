using NetDDD.Core.Contracts;
using System;

namespace NetDDD.Core.Bases
{
    /// <summary>
    /// Base class for a domain event.
    /// </summary>
    public abstract class DomainEvent : IDomainEvent
    {
        /// <summary>
        /// Gets the date/time of when the event was created.
        /// </summary>
        public DateTime Created { get; private set; }

        /// <summary>
        /// Initializes the class.
        /// </summary>
        protected DomainEvent()
        {
            Created = DateTime.Now;
        }
    }
}
