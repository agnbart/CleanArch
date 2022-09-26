using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitecture.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Contracts.Queries.GetContracts;
public record GetContractsQuery :IRequest<ContractsVm>;

public class GetContractsQueryHandler : IRequestHandler<GetContractsQuery, ContractsVm>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetContractsQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ContractsVm> Handle(GetContractsQuery request, CancellationToken cancellationToken)
    {
        return new ContractsVm
        {
            Lists = await _context.Contracts
            .ProjectTo<ContractDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken)
        };
    }
}
