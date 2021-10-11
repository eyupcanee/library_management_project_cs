using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class LibraryDbContextDal : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementProjectDB;Trusted_Connection=true");
        }

        public DbSet<Authority> Tbl_Authorities { get; set; }

        public DbSet<Book> Tbl_Books { get; set; }

        public DbSet<BorrowedBook> Tbl_BorrowedBooks { get; set; }

        public DbSet<Publisher> Tbl_Publishers { get; set; }

        public DbSet<User> Tbl_Users { get; set; }

        public DbSet<Writer> Tbl_Writers { get; set; }
    }
}
