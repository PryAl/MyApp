using DataAccess;
using Domain.Entities;

namespace BusinessLogic.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public RoomEntity AddRoom(RoomEntity room)
        {
            _roomRepository.AddRoom(room);
            return room;
        }

        public RoomEntity DeleteRoom(int id)
        {
            return _roomRepository.DeleteRoom(id);
        }

        public RoomEntity GetRoomById(int id)
        {
            return _roomRepository.GetRoomById(id);
        }

        public List<RoomEntity> GetRooms()
        {
            return _roomRepository.GetRooms();
        }

        public RoomEntity UpdateRoom(RoomEntity room)
        {
            return _roomRepository.UpdateRoom(room);
        }
    }
}
