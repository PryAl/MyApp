using DataAccess;
using Domain.Entities;

namespace BusinessLogic.Services;

public class PremiseService : IEntityService<Premise>
{
    private readonly IEntityRepository<Premise> _premiseRepository;

    public PremiseService(IEntityRepository<Premise> premiseRepository)
    {
        _premiseRepository = premiseRepository;
    }

    public Premise GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Premise> GetAll()
    {
        throw new NotImplementedException();
    }

    public Premise Create(Premise entity)
    {
        throw new NotImplementedException();
    }

    public Premise Update(Premise entity)
    {
        throw new NotImplementedException();
    }

    public Premise Delete(int id)
    {
        throw new NotImplementedException();
    }
}