using Domain.Entities;

namespace DataAccess
{
    public class RoomRepository : IRoomRepository
    {
        private readonly RoomDbContext _roomDbContext;
        public RoomRepository(RoomDbContext roomDbContext)
        {
            _roomDbContext = roomDbContext;
        }

        public RoomEntity AddRoom(RoomEntity room)
        {
            _roomDbContext.Rooms.Add(room);
            _roomDbContext.SaveChanges();
            return room;
        }

        public RoomEntity? DeleteRoom(int id)
        {
            var room = _roomDbContext.Rooms.FirstOrDefault(r => r.Id == id);
            if (room != null)
            {
                _roomDbContext.Rooms.Remove(room);
                _roomDbContext.SaveChanges();

                return room;
            }

            return null;
        }

        public RoomEntity? GetRoomById(int id)
        {
            return _roomDbContext.Rooms.FirstOrDefault(r => r.Id == id);
        }

        public List<RoomEntity> GetRooms()
        {
            return _roomDbContext.Rooms.ToList();
        }

        public RoomEntity? UpdateRoom(RoomEntity room)
        {
            var exRoom = _roomDbContext.Rooms.FirstOrDefault(r => r.Id == room.Id);

            if (exRoom != null)
            {
                exRoom.Id = room.Id;
                exRoom.Name = room.Name;
                exRoom.Floor = room.Floor;
                exRoom.Temperature = room.Temperature;
                exRoom.Humidity = room.Humidity;
                exRoom.Light = room.Light;

                _roomDbContext.SaveChanges();
                return exRoom;
            }
            else
            {
                return null;
            }
        }
    }
}
