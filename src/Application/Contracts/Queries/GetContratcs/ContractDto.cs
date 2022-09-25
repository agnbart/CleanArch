using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Mappings;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Contracts.Queries.GetContratcs;
internal class ContractDto : IMapFrom<Contract>
{
    public string? ContractId { get; set; }
    public string? Contractor1 { get; set; }
    public string? Contractor2 { get; set; }
    public DateTime? ContractDate { get; set; }
}
