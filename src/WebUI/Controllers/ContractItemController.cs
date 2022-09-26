using CleanArchitecture.Application.Common.Security;
using CleanArchitecture.Application.Contracts.Commands.CreateContract;
using CleanArchitecture.Application.Contracts.Queries.GetContracts;
using Microsoft.AspNetCore.Mvc;


namespace CleanArchitecture.WebUI.Controllers;
[Authorize]
public class ContractItemController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<ContractsVm>> Get()
    {
        return await Mediator.Send(new GetContractsQuery());
    }

    [HttpPost]
    public async Task<ActionResult<int>> Post(CreateContractCommand command)
    {
        return await Mediator.Send(command);
    }
}
