using Domain.Entities;

namespace DataAccess;

public class DeviceRepository : IEntityRepository<Device>
{
    private readonly MyDbContext _dbContext;
    public DeviceRepository( MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Device GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Device> GetAll()
    {
        throw new NotImplementedException();
    }

    public Device Create(Device entity)
    {
        throw new NotImplementedException();
    }

    public Device Update(Device entity)
    {
        throw new NotImplementedException();
    }

    public Device Delete(int id)
    {
        throw new NotImplementedException();
    }
}