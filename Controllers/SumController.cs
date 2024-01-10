using MiniChallengeTwoToFour___Endpoints.Services.Sum;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeTwoToFour___Endpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class SumController : ControllerBase
{
    private readonly ISumService _SumService;
    public SumController(ISumService sumService)
    {
        _SumService = sumService;
    }
    [HttpPost]
    [Route("Addition/{aNum}/{bNum}")]
    public string Addition(string aNum, string bNum)
    {
        return _SumService.Addition(aNum, bNum);
    }
}