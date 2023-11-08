using Domain.Entities;
using Domain.Entities.DeviceTypes;

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
        switch (entity)
        {
            case Luminaire luminaire:
                _dbContext.Luminaires.Add(luminaire);
                break;
            case Socket socket:
                _dbContext.Sockets.Add(socket);
                break;
            case Thermostat termostate:
                _dbContext.Thermostats.Add(termostate);
                break;
        }
        _dbContext.SaveChanges();
        return entity;
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