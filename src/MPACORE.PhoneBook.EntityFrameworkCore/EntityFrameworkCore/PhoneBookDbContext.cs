using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MPACORE.PhoneBook.Authorization.Roles;
using MPACORE.PhoneBook.Authorization.Users;
using MPACORE.PhoneBook.MultiTenancy;
using MPACORE.PhoneBook.PhoneBooks.Persons;
using MPACORE.PhoneBook.PhoneBooks.PhoneNumbers;

namespace MPACORE.PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
     
        public DbSet<Person> Persons { get; set; }

        public DbSet<PhoneNum> PhoneNums { get; set; }

        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Persion", "PB");
            modelBuilder.Entity<PhoneNum>().ToTable("PhoneNum", "PB");

            base.OnModelCreating(modelBuilder);
        }
    }
}
