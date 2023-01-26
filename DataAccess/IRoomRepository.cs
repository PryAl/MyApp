using Domain.Entities;

namespace DataAccess
{
    public interface IRoomRepository
    {
        List<RoomEntity> GetRooms();
        RoomEntity? GetRoomById(int id);
        RoomEntity AddRoom(RoomEntity room);
        RoomEntity? UpdateRoom(RoomEntity room);
        RoomEntity? DeleteRoom(int id);
    }
}
