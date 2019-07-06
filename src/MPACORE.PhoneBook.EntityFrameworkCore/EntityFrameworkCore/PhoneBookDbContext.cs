using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MPACORE.PhoneBook.Authorization.Roles;
using MPACORE.PhoneBook.Authorization.Users;
using MPACORE.PhoneBook.MultiTenancy;

namespace MPACORE.PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }
    }
}
