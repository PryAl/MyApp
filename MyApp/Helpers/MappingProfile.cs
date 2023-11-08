using AutoMapper;
using Domain.Entities;
using WebApp.Dto;

namespace WebApp.Helpers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<PremiseDto, Premise>();
        CreateMap<RoomDto, Room>();
        CreateMap<DeviceDto, Device>();
    }
}