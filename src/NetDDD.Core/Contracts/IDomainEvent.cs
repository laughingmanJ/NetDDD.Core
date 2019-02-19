using System;
using System.Collections.Generic;
using System.Text;

namespace NetDDD.Core.Contracts
{
    public interface IDomainEvent
    {
        /// <summary>
        /// Gets the date/time of when the event was created.
        /// </summary>
        DateTime Created { get; }
    }
}
