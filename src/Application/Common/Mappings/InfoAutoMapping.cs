using Application.Process.Info.Commands.CreateInfo.v1;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Mappings;

public class InfoAutoMapping : Profile
{
    public InfoAutoMapping()
    {
        CreateMap<Info, CreateInfoResponse>();
    }
}
