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
    public class WriterDal : IWriterDal
    {
        public void Add(Writer entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                context.Tbl_Writers.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Writer entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                var toDelete = context.Tbl_Writers.SingleOrDefault(x => x.ID == entity.ID);
                toDelete.Status = false;
                context.SaveChanges();
            }
        }

        public List<Writer> GetAll()
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Writers.ToList();
            }
        }

        public Writer GetById(int id)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Writers.SingleOrDefault(x => x.ID == id);
            }
        }

        public Writer GetByUserId(int uID)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Writers.SingleOrDefault(x => x.UserID == uID);
            }
        }

        public List<Writer> GetByStatus(bool status)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Writers.Where(x => x.Status == status).ToList();
            }
        }

        public void HardDelete(Writer entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                context.Tbl_Writers.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(Writer entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                var toUpdate = context.Tbl_Writers.SingleOrDefault(x => x.ID == entity.ID);
                toUpdate.UserID = entity.UserID;
                toUpdate.Confirmation = entity.Confirmation;
                toUpdate.Status = entity.Status;
                context.SaveChanges();
            }
        }
    }
}
