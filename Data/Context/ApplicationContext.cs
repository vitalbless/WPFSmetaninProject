using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WPFSmetaninProject.Data.Models;

namespace WPFSmetaninProject.Data.Context
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
        /// <summary>
        /// Метод возвращает строку подключения
        /// </summary>
        /// <returns></returns>
        private string GetConnectionString()
        {
            return new SqlConnectionStringBuilder()
            {
                DataSource = "192.168.1.100",
                UserID = "ivan123",
                Password = "root",
                InitialCatalog = "ProductSM"
            }.ConnectionString;
        }
        public DbSet<AttachedProduct> AttachedProducts { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<ClientService> ClientServices { get; set; }
        public DbSet<DocumentByService> DocumentByServices { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductSale> ProductSales { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServicePhoto> ServicePhotos { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagOfClient> TagOfClients { get; set; }
    }
}
