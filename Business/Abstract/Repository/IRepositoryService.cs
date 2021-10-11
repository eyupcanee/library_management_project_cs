using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Repository
{
    public interface IRepositoryService<T> where T:class,IEntity,new()
    {
        List<T> GetAll();

        List<T> GetByStatus(bool status);

        T GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void HardDelete(T entity);
    }
}
