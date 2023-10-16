using Application.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace Member.Controllers;

[ApiController]
[Route("[controller]")]
public class RegisterController : ApiControllerBase
{
    private readonly ILogger<RegisterController> _logger;
    public RegisterController(ILogger<RegisterController> logger)
    {
        _logger = logger;
    }

    [HttpPost("v1/create")]
    public async Task<IActionResult> Create(string command)
    {

        /*
            infoName:"",
            email:"",
            firstName:"",
            LastName:""
        
        */
        try
        {
            var result = await Mediator.Send(command);
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, nameof(Create));
            return Ok(BaseResponse.Error500(errorCode: "202310160057", devErrorMessage: ex.Message));
        }
    }

}
