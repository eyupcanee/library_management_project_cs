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
    public class WriterManager : IWriterService
    {
        IWriterDal writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            this.writerDal = writerDal;
        }

        public void Add(Writer entity)
        {
            try
            {
                writerDal.Add(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void Delete(Writer entity)
        {
            try
            {
                writerDal.Delete(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public List<Writer> GetAll()
        {
            try
            {
                return writerDal.GetAll();
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public Writer GetById(int id)
        {
            try
            {
                return writerDal.GetById(id);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public List<Writer> GetByStatus(bool status)
        {
            try
            {
                return writerDal.GetByStatus(status);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void HardDelete(Writer entity)
        {
            try
            {
                writerDal.HardDelete(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void Update(Writer entity)
        {
            try
            {
                writerDal.Update(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }
    }
}
