using System;
using System.Collections.Generic;
using System.Text;

namespace NetDDD.Core.Contracts
{
    public interface IDomainEventHandler
    {
        string Name { get; }
    }
}
