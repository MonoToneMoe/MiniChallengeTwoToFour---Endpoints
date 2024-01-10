
using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour___Endpoints.Services.name;

namespace MiniChallengeTwoToFour___Endpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class NameController : ControllerBase
{
    private readonly INameService _nameService;

    public NameController(INameService nameService)
    {
        _nameService = nameService;
    }
    [HttpPost]
    [Route("Name/{name}/{time}")]
    public string Name(string name, string time)
    {
        return _nameService.Name(name, time);
    }

}