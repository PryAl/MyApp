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
        public RoomsController(IEntityService<Room> roomService)
        {
            _roomService = roomService;
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
        public ActionResult<RoomDto> PostRoom(RoomDto room)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_roomService.Create(new Room
            {
                Id = room.Id,
                Name=room.Name,
            }));
        }

        [HttpPut]
        public IActionResult Put(RoomDto room)
        {
            Room entry = new Room
            {
                Id = room.Id,
                Name = room.Name,
            };
            var result = _roomService.Update(entry);
            if (result != null)
            {
                return Ok(result);
            }
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