using Domain.Entities;

namespace BusinessLogic
{
    public interface IRoomService
    {
        List<RoomEntity> GetRooms();
        RoomEntity GetRoomById(int id);
        RoomEntity AddRoom(RoomEntity room);
        RoomEntity UpdateRoom(RoomEntity room);
        RoomEntity DeleteRoom(int id);
    }
}
