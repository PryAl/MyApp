﻿using Domain.Dto;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private static List<RoomEntity> rooms = new List<RoomEntity>(new[] {
            new RoomEntity() { Id = 1, Name = "Kitchen", Floor = 1, Temperature = 20, Humidity = 80 },
            new RoomEntity() { Id = 2, Name = "Living room", Floor = 1, Temperature = 22, Humidity = 75 },
            new RoomEntity() { Id = 3, Name = "Hallway", Floor = 1, Temperature = 19, Humidity = 75 },
            new RoomEntity() { Id = 4, Name = "Bedroom", Floor = 2, Temperature = 21, Humidity = 70 }
        });

        private int NextRoomId => rooms.Count() == 0 ? 1 : rooms.Max(r => r.Id) + 1;

        [HttpGet]
        public IActionResult Get() => Ok(rooms);
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var room = rooms.Where(r => r.Id == id).Select(r =>
                new RoomDto()
                {
                    Id = r.Id,
                    Name = r.Name,
                    Floor = r.Floor,
                    Temperature = r.Temperature,
                    Humidity = r.Humidity
                }).FirstOrDefault();

            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        [HttpPost]
        public IActionResult Post(RoomEntity room)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            room.Id = NextRoomId;
            rooms.Add(room);
            return CreatedAtAction(nameof(Get), new { id = room.Id }, room);
        }

        [HttpPost("AddRoom")]
        public IActionResult PostBody([FromBody] RoomEntity room) => Post(room);

        [HttpPut]
        public IActionResult Put(RoomDto room)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var storedRoom = rooms.FirstOrDefault(r => r.Id == room.Id);
            if (storedRoom == null)
                return NotFound();
            storedRoom.Name = room.Name;
            storedRoom.Temperature = room.Temperature;
            storedRoom.Humidity = room.Humidity;

            return Ok(storedRoom);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            rooms.Remove(rooms.SingleOrDefault(r => r.Id == id));
            return Ok();
        }
    }
}