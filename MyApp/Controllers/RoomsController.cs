using AutoMapper;
using BusinessLogic;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApp.Dto;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly IEntityService<Room> _roomService;
        private readonly IMapper _mapper;

        public RoomsController(IEntityService<Room> roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public IActionResult Get() => Ok(_roomService.GetAll());
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var room = _roomService.GetById(id);

            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        [HttpPost]
        public ActionResult<RoomDto> Create(RoomDto newRoom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_roomService.Create(_mapper.Map<Room>(newRoom)));
        }

        [HttpPut]
        public IActionResult Put(RoomDto room)
        {
            return BadRequest();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _roomService.Delete(id);
            if(result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }
    }
}