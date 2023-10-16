using Application.Common.Interfaces.Repositories;
using AutoMapper;
using Domain.Events;
using MediatR;

namespace Application.Process.Info.Commands.CreateInfo.v1;

public class CreateInfoHandler : IRequestHandler<CreateInfoCommand, CreateInfoResponse>
{
    private readonly IInfoRepository _infoRepository;
    private readonly IMapper _mapper;

    public CreateInfoHandler(IInfoRepository infoRepository, IMapper mapper)
    {
        _infoRepository = infoRepository;
        _mapper = mapper;
    }
    public async Task<CreateInfoResponse> Handle(CreateInfoCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.Info entity = new()
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Status = 1,
            UpdateUser = Guid.Empty
        };
        entity.AddDomainEvent(new InfoCreatedEvent(entity));
        await _infoRepository.CreateAsync(entity, cancellationToken);

        return _mapper.Map<CreateInfoResponse>(entity);
    }
}
