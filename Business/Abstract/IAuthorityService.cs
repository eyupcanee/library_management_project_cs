using Business.Abstract.Repository;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthorityService : Repository.IRepositoryService<Authority>
    {
        
    }
}
