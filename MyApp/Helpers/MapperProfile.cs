using AutoMapper;
using Domain.Entities;
using Domain.Entities.DeviceTypes;
using WebApp.Dto;

namespace WebApp.Helpers;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<SocketDto, Socket>();
    }
}