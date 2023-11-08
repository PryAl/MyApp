using Domain.Entities;

namespace DataAccess;

public class PremiseRepository : IEntityRepository<Premise>
{
    private readonly MyDbContext _dbContext;
    public PremiseRepository( MyDbContext dbContext)
    {
        _dbContext = dbContext;
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
        _dbContext.Premises.Add(entity);
        _dbContext.SaveChanges();
        return entity;
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