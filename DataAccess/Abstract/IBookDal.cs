using DataAccess.Abstract.Repository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBookDal : IRepositoryDal<Book>
    {
        List<Book> GetByWriter(Writer writer);

        List<Book> GetByPublisher(Publisher publisher);
    }
}
