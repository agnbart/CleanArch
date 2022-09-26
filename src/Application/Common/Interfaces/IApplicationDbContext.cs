using CleanArchitecture.Application.Contracts.Queries.GetContracts;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<Contract> Contracts { get; }

    DbSet<Contractor> Contractors { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

}
