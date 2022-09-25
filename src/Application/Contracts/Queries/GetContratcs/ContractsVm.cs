using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Queries.GetContratcs;
public class ContractsVm
{
    public IList<ContractsVm> Lists { get; set; } = new List<ContractsVm>();
}
