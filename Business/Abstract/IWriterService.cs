using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWriterService : Repository.IRepositoryService<Writer>
    {
        Writer GetByUserId(int uID);

        List<Writer> GetByConfirmation(bool confirmation);
    }
}
