using MediatR;

namespace Application.Process.Info.Commands.CreateInfo.v1;

public record CreateInfoCommand : IRequest<CreateInfoResponse>
{
    public string Name { get; set; } = string.Empty;
}
