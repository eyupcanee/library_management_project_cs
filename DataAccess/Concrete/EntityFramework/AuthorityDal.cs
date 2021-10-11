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
    public class AuthorityDal : IAuthorityDal
    {
        public void Add(Authority entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                context.Tbl_Authorities.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Authority entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                var toDelete = context.Tbl_Authorities.SingleOrDefault(x => x.ID == entity.ID);
                toDelete.Status = false;
            }
        }

        public List<Authority> GetAll()
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Authorities.ToList();
            }
        }

        public Authority GetById(int id)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Authorities.SingleOrDefault(x => x.ID == id);
            }
        }

        public List<Authority> GetByStatus(bool status)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                return context.Tbl_Authorities.Where(x => x.Status == status).ToList();
            }
        }

        public void HardDelete(Authority entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                context.Tbl_Authorities.Remove(context.Tbl_Authorities.SingleOrDefault(x => x.ID == entity.ID));
                context.SaveChanges();
            }
        }

        public void Update(Authority entity)
        {
            using (LibraryDbContextDal context = new LibraryDbContextDal())
            {
                var toUpdate = context.Tbl_Authorities.SingleOrDefault(x => x.ID == entity.ID);
                toUpdate.AutName = entity.AutName;
                toUpdate.Status = entity.Status;
                context.SaveChanges();
            }
        }
    }
}
