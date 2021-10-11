using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class PublisherDal : IPublisherDal
    {
        public void Add(Publisher entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                context.Tbl_Publishers.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Publisher entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                var toDelete = context.Tbl_Publishers.SingleOrDefault(x => x.ID == entity.ID);
                toDelete.Status = false;
                context.SaveChanges();
            }
        }

        public List<Publisher> GetAll()
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Publishers.ToList();
            }
        }

        public Publisher GetById(int id)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Publishers.SingleOrDefault(x => x.ID == id);
            }
        }

        public List<Publisher> GetByStatus(bool status)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Publishers.Where(x => x.Status == status).ToList();
            }
        }

        public void HardDelete(Publisher entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                context.Tbl_Publishers.Remove(context.Tbl_Publishers.SingleOrDefault(x => x.ID == entity.ID));
            }
        }

        public void Update(Publisher entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                var toUpdate = context.Tbl_Publishers.SingleOrDefault(x => x.ID == entity.ID);
                toUpdate.PName = entity.PName;
                toUpdate.Status = entity.Status;
                context.SaveChanges();
            }
        }
    }
}
