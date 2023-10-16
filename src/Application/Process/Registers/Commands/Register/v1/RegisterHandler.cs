using Application.Common.Interfaces.Repositories;
using MediatR;

namespace Application.Process.Registers.Commands.Register.v1;

public class RegisterHandler : IRequestHandler<RegisterCommand, bool>
{
    private readonly IInfoRepository _infoRepository;
    private readonly IMemberRepository _memberRepository;
    public RegisterHandler(IInfoRepository infoRepository, IMemberRepository memberRepository)
    {
        _infoRepository = infoRepository;
        _memberRepository = memberRepository;
    }
    public async Task<bool> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.Info info = new()
        {
            Id = Guid.NewGuid(),
            Name = request.InfoName,
            //Plan = Free,Basic,Standrad,Premium
            Status = 0
        };
        await _infoRepository.CreateAsync(info, cancellationToken);

        Domain.Entities.Member member = new()
        {
            Id = Guid.NewGuid(),
            InfoId = info.Id,
            RoleId = 2, //Owner
            FirstName = request.FirstName ?? "",
            LastName = request.LastName ?? "",
            Status = 1
        };

        await _memberRepository.CreateAsync(member, cancellationToken);
        //Send Email Validate

        return true;
    }
}
