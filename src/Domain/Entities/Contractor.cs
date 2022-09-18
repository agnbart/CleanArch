using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class Contractor : BaseAuditableEntity
{
    public string ContractorId { get; set; }
    public string? Name1 { get; set; }
    public string? Name2 { get; set; }
    public string? City { get; set; }
    public string Nip { get; set; }
}
