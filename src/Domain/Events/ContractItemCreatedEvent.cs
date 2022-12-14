using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Events;
public class ContractItemCreatedEvent : BaseEvent
{
    public ContractItemCreatedEvent(ContractItemCreatedEvent item)
    {
        Item = item;
    }

    public ContractItemCreatedEvent Item { get; }
}
