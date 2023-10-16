using MediatR;

namespace Application.Process.Registers.Commands.Register.v1;
public record RegisterCommand : IRequest<bool>
{
    public string InfoName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
