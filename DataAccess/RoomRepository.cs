using Domain.Entities;

namespace DataAccess
{
    public class RoomRepository : IEntityRepository<Room>
    {
        private readonly MyDbContext _myDbContext;
        public RoomRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
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
