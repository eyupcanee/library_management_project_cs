using Business.Abstract.Repository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPublisherService : Repository.IRepositoryService<Publisher>
    {
    }
}
