using CleanArchitecture.Application.Contracts.Commands.CreateContract;
using CleanArchitecture.Application.Contracts.Queries.GetContratcs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.WebUI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ContractItemController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<ContractsVm>> Get()
    {
        return await Mediator.Send(new GetContractsQuery());
    }

    // POST api/<ContractItemController>
    [HttpPost]
    public async Task<ActionResult<int>> Post(CreateContractCommand command)
    {
        return await Mediator.Send(command);
    }
}
