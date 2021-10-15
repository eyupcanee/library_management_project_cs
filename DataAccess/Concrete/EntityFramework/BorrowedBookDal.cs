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
    public class BorrowedBookDal : IBorrowedBookDal
    {
        public void Add(BorrowedBook entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                context.Tbl_BorrowedBooks.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(BorrowedBook entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                var toDelete = context.Tbl_BorrowedBooks.SingleOrDefault(x => x.ID == entity.ID);
                toDelete.Status = false;
                context.SaveChanges();
            }
        }

        public List<BorrowedBook> GetAll()
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_BorrowedBooks.ToList();
            }
        }

        public BorrowedBook GetById(int id)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_BorrowedBooks.SingleOrDefault(x => x.ID == id);
            }
        }

        public List<BorrowedBook> GetByStatus(bool status)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_BorrowedBooks.Where(x => x.Status == status).ToList();
            }
        }

        public void HardDelete(BorrowedBook entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                context.Tbl_BorrowedBooks.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(BorrowedBook entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                var toUpdate = context.Tbl_BorrowedBooks.SingleOrDefault(x => x.ID == entity.ID);
                toUpdate.BookID = entity.BookID;
                toUpdate.UserID = entity.UserID;
                toUpdate.Received = entity.Received;
                toUpdate.Delivery = entity.Delivery;
                toUpdate.Status = entity.Status;
                context.SaveChanges();
            }
        }
    }
}
