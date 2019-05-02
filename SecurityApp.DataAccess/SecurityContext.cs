namespace SecurityApp.DataAccess
{
    using SecurityApp.Models;
    using System.Data.Entity;

    public class SecurityContext : DbContext
    {
        public SecurityContext()
            : base("name=SecurityContext")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public virtual DbSet<User> Users { get; set; }
    }
}