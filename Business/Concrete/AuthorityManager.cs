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
    public class AuthorityManager : IAuthorityService
    {
        IAuthorityDal authorityDal;

        public AuthorityManager(IAuthorityDal authorityDal)
        {
            this.authorityDal = authorityDal;
        }
        
        public void Add(Authority entity)
        {
            try
            {
                authorityDal.Add(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void Delete(Authority entity)
        {
            try
            {
                authorityDal.Delete(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public List<Authority> GetAll()
        {
            try
            {
                return authorityDal.GetAll();
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public Authority GetById(int id)
        {
            try
            {
                return authorityDal.GetById(id);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public List<Authority> GetByStatus(bool status)
        {
            try
            {
                return authorityDal.GetByStatus(status);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void HardDelete(Authority entity)
        { 
            try
            {
                authorityDal.HardDelete(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void Update(Authority entity)
        {
            try
            {
                authorityDal.Update(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }
    }
}
