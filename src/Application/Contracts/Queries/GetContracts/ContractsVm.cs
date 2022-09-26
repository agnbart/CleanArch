using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Contracts.Queries.GetContracts;
public class ContractsVm
{
    public IList<ContractDto> Lists { get; set; } = new List<ContractDto>();
}
