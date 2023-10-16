using Application.Common.Models;
using Application.Process.Info.Commands.CreateInfo.v1;
using Microsoft.AspNetCore.Mvc;

namespace Member.Controllers;

[ApiController]
[Route("[controller]")]
public class InfoController : ApiControllerBase
{
    private readonly ILogger<InfoController> _logger;
    public InfoController(ILogger<InfoController> logger)
    {
        _logger = logger;
    }

    [HttpPost("v1/create")]
    public async Task<IActionResult> Create(CreateInfoCommand command)
    {
        try
        {
            var result = await Mediator.Send(command);
            return Ok(BaseResponse.Ok(result));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, nameof(Create));
            return Ok(BaseResponse.Error500(errorCode: "202310162357", devErrorMessage: ex.Message));
        }

    }
}
