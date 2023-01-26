using BusinessLogic;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApp.Dto;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _service;
        public RoomController(IRoomService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_service.GetRooms());
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var room = _service.GetRoomById(id);

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
            return Ok(_service.AddRoom(new RoomEntity
            {
                Id = room.Id,
                Name=room.Name,
                Floor=room.Floor,
                Temperature=room.Temperature,
                Humidity=room.Humidity,
                Light = room.Light
            }));
        }

        [HttpPut]
        public IActionResult Put(RoomDto room)
        {
            RoomEntity entry = new RoomEntity
            {
                Id = room.Id,
                Name = room.Name,
                Temperature = room.Temperature,
                Humidity = room.Humidity,
                Floor = room.Floor,
                Light = room.Light
            };
            var result = _service.UpdateRoom(entry);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.DeleteRoom(id);
            if(result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }
    }
}