using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class Contract : BaseAuditableEntity
{   
    public string ContractId { get; set; }
    public string Contractor1 { get; set; }
    public string? Contractor1Description { get; set; }
    public string Contractor2 { get; set; }
    public string? Contractor2Description { get; set; }
    public DateTime ContractDate { get; set; }
    public string? ContractDescription { get; set; }
}
