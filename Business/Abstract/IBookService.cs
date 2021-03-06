using Business.Abstract.Repository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookService : Repository.IRepositoryService<Book>
    {
        List<Book> GetByWriter(Writer writer);

        List<Book> GetByPublisher(Publisher publisher);
    }
}
