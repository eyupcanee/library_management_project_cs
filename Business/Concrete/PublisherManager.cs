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
    public class PublisherManager : IPublisherService
    {
        IPublisherDal publisherDal;

        public PublisherManager(IPublisherDal publisherDal)
        {
            this.publisherDal = publisherDal;
        }

        public void Add(Publisher entity)
        {
            try
            {
                publisherDal.Add(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void Delete(Publisher entity)
        {
            try
            {
                publisherDal.Delete(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public List<Publisher> GetAll()
        {
            try
            {
                return publisherDal.GetAll();
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public Publisher GetById(int id)
        {
            try
            {
                return publisherDal.GetById(id);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public List<Publisher> GetByStatus(bool status)
        {
            try
            {
                return publisherDal.GetByStatus(status);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void HardDelete(Publisher entity)
        {
            try
            {
                publisherDal.HardDelete(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void Update(Publisher entity)
        {
            try
            {
                publisherDal.Update(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }
    }
}
