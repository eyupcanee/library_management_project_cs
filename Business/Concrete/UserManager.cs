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
    public class UserManager : IUserService
    {
        IUserDal userDal;

        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }

        public void Add(User entity)
        {
            try
            {
                userDal.Add(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void Delete(User entity)
        {
            try
            {
                userDal.Delete(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public List<User> GetAll()
        {
            try
            {
                return userDal.GetAll();
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public User GetById(int id)
        {
            try
            {
                return userDal.GetById(id);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public User GetLastUser()
        {
            try
            {
                return userDal.GetLastUser();
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public List<User> GetByStatus(bool status)
        {
            try
            {
                return userDal.GetByStatus(status);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void HardDelete(User entity)
        {
            try
            {
                userDal.HardDelete(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }

        public void Update(User entity)
        {
            try
            {
                userDal.Update(entity);
            }
            catch (Exception)
            {
                throw new DbConnectionException(ExpStrings.DbConExpStr);
            }
        }
    }
}
