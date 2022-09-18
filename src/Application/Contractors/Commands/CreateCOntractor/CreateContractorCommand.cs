using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Contractors.Commands.CreateCOntractor;
public class CreateContractorCommand : IRequest<int>
{
    public string ContractorId { get; set; }
    public string? Name1 { get; set; }
    public string? Name2 { get; set; }
    public string? City { get; set; }
    public string Nip { get; set; }
}

public class CreateContractorCommandHandler : IRequestHandler<CreateContractorCommand, int>
{
    private readonly IApplicationDbContext _context;
    public CreateContractorCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateContractorCommand request, CancellationToken cancellationToken)
    {
        var entity = new Contractor
        {
            ContractorId = request.ContractorId,
            Name1 = request.Name1,
            Name2 = request.Name2,
            City = request.City,
            Nip = request.Nip,
        };

        _context.Contractors.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}