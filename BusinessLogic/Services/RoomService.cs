using DataAccess;
using Domain.Entities;

namespace BusinessLogic.Services
{
    public class RoomService : IEntityService<Room>
    {
        private readonly IEntityRepository<Room> _roomRepository;
        public RoomService(IEntityRepository<Room> roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public Room GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetAll()
        {
            throw new NotImplementedException();
        }

        public Room Create(Room entity)
        {
            throw new NotImplementedException();
        }

        public Room Update(Room entity)
        {
            throw new NotImplementedException();
        }

        public Room Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
