using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Data.Entity;
using System.Linq;

namespace TestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new UserDal());

            var e = userManager.GetById(1);

            Console.WriteLine(e.FirstName + " "+ e.LastName + " " + e.Username + " "+ e.Gsm + " " + e.AuthorityID);
        }
    }
}
