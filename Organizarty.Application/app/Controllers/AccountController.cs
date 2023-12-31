using Microsoft.AspNetCore.Mvc;
using Organizarty.Domain.UseCases.Users;

using Organizarty.Application.app.Dtos.Requests;

namespace Organizarty.Application.app.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly ILogger<AccountController> _logger;
    private readonly ISignUseCase _sign;

    public AccountController(ILogger<AccountController> logger, ISignUseCase sign)
    {
        _logger = logger;
        _sign = sign;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login(LoginDTO userdto)
    {
        var (user, token) = await _sign.Login(userdto.Email, userdto.Password);

        var data = new
        {
            token,
            user = new
            {
                id = user.Id,
                user_name = user.UserName,
                email = user.Email
            }
        };

        return Ok(data);
    }

    [HttpGet("ConfirmCode/{code:Guid}")]
    public async Task<IActionResult> Login(Guid code)
    {
        await _sign.ConfirmEmailCode(code.ToString());

        return Ok("Account verified");
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register(RegisterDTO userdto)
    {
        var user = await _sign.Register(userdto.UserName, userdto.Email, userdto.Password);

        var data = new
        {
            user = new
            {
                id = user.Id,
                user_name = user.UserName,
                email = user.Email
            }
        };

        return Ok(data);
    }
}
