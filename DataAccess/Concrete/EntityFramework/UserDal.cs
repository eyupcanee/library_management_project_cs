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
    public class UserDal : IUserDal
    {
        public void Add(User entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                context.Tbl_Users.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(User entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                var toDelete = context.Tbl_Users.SingleOrDefault(x => x.ID == entity.ID);
                toDelete.Status = false;
                context.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Users.ToList();
            }
        }

        public User GetById(int id)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Users.SingleOrDefault(x => x.ID == id);
            }
        }

        public User GetLastUser()
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Users.OrderByDescending(x => x.ID).FirstOrDefault();
            }
        }

        public List<User> GetByStatus(bool status)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Users.Where(x => x.Status == status).ToList();
            }
        }

        public void HardDelete(User entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                context.Tbl_Users.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(User entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                var toUpdate = context.Tbl_Users.SingleOrDefault(x => x.ID == entity.ID);
                toUpdate.FirstName = entity.FirstName;
                toUpdate.LastName = entity.LastName;
                toUpdate.Username = entity.Username;
                toUpdate.Password = entity.Password;
                toUpdate.Email = entity.Email;
                toUpdate.Gsm = entity.Gsm;
                toUpdate.AuthorityID = entity.AuthorityID;
                toUpdate.Status = entity.Status;
                context.SaveChanges();
            }
        }
    }
}
