using Business.Abstract;
using Business.Concrete.Exceptions;
using Business.Concrete.MagicStrings;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BorrowedBookManager : IBorrowedBookService
    {
        IBorrowedBookDal borrowedBookDal;

        public BorrowedBookManager(IBorrowedBookDal borrowedBookDal)
        {
            this.borrowedBookDal = borrowedBookDal;
        }

        public void Add(BorrowedBook entity)
        {
            try
            {
                borrowedBookDal.Add(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void Delete(BorrowedBook entity)
        {
            try
            {
                borrowedBookDal.Delete(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public List<BorrowedBook> GetAll()
        {
            try
            {
                return borrowedBookDal.GetAll();
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public BorrowedBook GetById(int id)
        {
            try
            {
                return borrowedBookDal.GetById(id);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public List<BorrowedBook> GetByStatus(bool status)
        {
            try
            {
                return borrowedBookDal.GetByStatus(status);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void HardDelete(BorrowedBook entity)
        {
            try
            {
                borrowedBookDal.HardDelete(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void Update(BorrowedBook entity)
        {
            try
            {
                borrowedBookDal.Update(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }
    }
}
