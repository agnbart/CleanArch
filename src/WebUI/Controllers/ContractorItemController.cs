using CleanArchitecture.Application.Common.Security;
using CleanArchitecture.Application.Contractors.Commands.CreateCOntractor;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.WebUI.Controllers;
[Authorize]
public class ContractorItemController : ApiControllerBase
{
    [HttpPost]
    public async Task<ActionResult<int>> Post(CreateContractorCommand command)
    {
        return await Mediator.Send(command);
    }
}
