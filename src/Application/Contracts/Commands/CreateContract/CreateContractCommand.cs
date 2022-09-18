using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Contracts.Commands.CreateContract;
public class CreateContractCommand : IRequest<int>
{
    public string ContractId { get; set; }
    public string Contractor1 { get; set; }
    public string? Contractor1Description { get; set; }
    public string Contractor2 { get; set; }
    public string? Contractor2Description { get; set; }
    public DateTime ContractDate { get; set; }
    public string? ContractDescription { get; set; }
}

public class CreateContractCommandHandler : IRequestHandler<CreateContractCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateContractCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<int> Handle(CreateContractCommand request, CancellationToken cancellationToken)
    {
        var entity = new Contract
        {
            ContractId = request.ContractId,
            Contractor1 = request.Contractor1,
            Contractor2 = request.Contractor2,
            ContractDate = request.ContractDate,
            ContractDescription = request.ContractDescription,
        };

        _context.Contracts.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
