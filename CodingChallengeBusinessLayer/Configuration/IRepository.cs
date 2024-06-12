using CodingChallengeBusinessLayer.BusinessObjects;

namespace CodingChallengeBusinessLayer.Configuration
{
    public interface IRepository<T>
    {
        bool Add(T entity);
        T GetById(int id);
        bool Update(T entity);
    }
}
