using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Common.Security;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Contracts.Queries.GetContratcs;
[Authorize]
public record GetContractsQuery : IRequest<ContractsVm>;
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
            Lists = (IList<ContractsVm>)await _context.Contracts
                .AsNoTracking()
                .ProjectTo<ContractDto>(_mapper.ConfigurationProvider)
                .OrderBy(t => t.ContractId)
                .ToListAsync(cancellationToken)
        };
    }
}
