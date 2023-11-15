using AutoMapper;
using BusinessLogic;
using Domain.Entities;
using Domain.Entities.DeviceTypes;
using Microsoft.AspNetCore.Mvc;
using WebApp.Dto;

namespace WebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class DeviceController : ControllerBase
{
    private readonly IEntityService<Device> _deviceService;
    private readonly IMapper _mapper;

    public DeviceController(IEntityService<Device> deviceService, IMapper mapper)
    {
        _deviceService = deviceService;
        _mapper = mapper;
    }
    [HttpPost("add")]
    public ActionResult<Device> Create(DeviceDto newDevice)
    {
        var socket = _mapper.Map<Socket>(newDevice);
        
        return Ok(_deviceService.Create(socket));
    }
}