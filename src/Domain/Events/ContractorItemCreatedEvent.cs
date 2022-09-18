using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Events;
public class ContractorItemCreatedEvent :BaseEvent
{
    public ContractorItemCreatedEvent(ContractorItemCreatedEvent item)
    {
        Item = item;
    }

    public ContractorItemCreatedEvent Item { get; }
}
