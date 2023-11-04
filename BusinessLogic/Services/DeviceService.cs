using DataAccess;
using Domain.Entities;

namespace BusinessLogic.Services;

public class DeviceService : IEntityService<Device>
{
    private readonly IEntityRepository<Device> _deviceRepository;

    public DeviceService(IEntityRepository<Device> deviceRepository)
    {
        _deviceRepository = deviceRepository;
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