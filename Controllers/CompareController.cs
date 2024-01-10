using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour___Endpoints.Services.Compare;

namespace MiniChallengeTwoToFour___Endpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class CompareController : ControllerBase
{
    private readonly ICompareService _compareService;
    public CompareController(ICompareService compareService)
    {
        _compareService = compareService;
    }

    [HttpPost]
    [Route("Compare/{numA}/{numB}")]
    public string Compare(string numA, string numB)
    {
        return _compareService.Compare(numA, numB);
    }
}