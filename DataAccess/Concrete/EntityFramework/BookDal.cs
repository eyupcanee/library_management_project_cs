using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class BookDal : IBookDal
    {
        public void Add(Book entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                context.Tbl_Books.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Book entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                var toDelete = context.Tbl_Books.SingleOrDefault(x => x.ID == entity.ID);
                toDelete.Status = false;
                context.SaveChanges();
            }
        }

        public List<Book> GetAll()
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Books.ToList();
            }
        }

        public Book GetById(int id)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Books.SingleOrDefault(x => x.ID == id);
            }
        }

        public List<Book> GetByPublisher(Publisher publisher)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Books.Where(x => x.PublisherID == publisher.ID).ToList();
            }
        }

        public List<Book> GetByStatus(bool status)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Books.Where(x => x.Status == status).ToList();
            }
        }

        public List<Book> GetByWriter(Writer writer)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Books.Where(x => x.WriterID == writer.ID).ToList();
            }
        }

        public void HardDelete(Book entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                context.Tbl_Books.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(Book entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                var toUpdate = context.Tbl_Books.SingleOrDefault(x => x.ID == entity.ID);
                toUpdate.Name = entity.Name;
                toUpdate.WriterID = entity.WriterID;
                toUpdate.Piece = entity.Piece;
                toUpdate.Page = entity.Page;
                toUpdate.PublisherID = entity.PublisherID;
                toUpdate.Status = entity.Status;
                context.SaveChanges();
            }
        }
    }
}
