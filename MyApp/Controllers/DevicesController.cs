using AutoMapper;
using BusinessLogic;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApp.Dto;

namespace WebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class DevicesController : ControllerBase
{
    private readonly IEntityService<Device> _deviceService;
    private readonly IMapper _mapper;

    public DevicesController(IEntityService<Device> deviceService, IMapper mapper)
    {
        _deviceService = deviceService;
        _mapper = mapper;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll() => Ok(_deviceService.GetAll());

    [HttpGet("GetById/{id}")]
    public IActionResult GetById(int id) => Ok(_deviceService.GetById(id));

    [HttpPost]
    public IActionResult Create([FromBody] DeviceDto newDevice)
    {
        var test = newDevice as ThermostatDto;
        var device = _mapper.Map<Device>(newDevice);
        return Ok(_deviceService.Create(device));
    }
    
    [HttpPut]
    public IActionResult Update(Device device) => Ok(_deviceService.Update(device));

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var result = _deviceService.Delete(id);
        if (result != null)
        {
            return Ok(result);
        }

        return BadRequest();
    }
}