using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PablosCardLtd.News.Entities;

namespace PablosCardLtd.News
{
    public class NewsDbContext : IdentityDbContext<StaffUser, StaffUserRole, Guid>
    {
        public NewsDbContext(DbContextOptions<NewsDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=pablosNewsDbExport");
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ViewCount> ViewCounts { get; set; }
        public DbSet<StaffUser> StaffUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Article>(x =>
                x.Property(y => y.ArticleId).HasDefaultValueSql("newsequentialid()"));
            modelBuilder.Entity<Category>(x =>
                x.Property(y => y.CategoryId).HasDefaultValueSql("newsequentialid()"));
            modelBuilder.Entity<ViewCount>(x =>
                x.Property(y => y.ViewCountId).HasDefaultValueSql("newsequentialid()"));
            //modelBuilder.Entity<ArticleCategory>(x =>
            //    x.Property(y => y.ArticleCategoryId).HasDefaultValueSql("newsequentialid()"));

            // Data seeding
            // Category
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = new Guid("8c81915d-438e-49e4-bf6a-9acf0af7bd40"),
                    CategoryName = "News"
                },
                new Category
                {
                    CategoryId = new Guid("676e0638-a3ef-4367-b340-e3268095a397"),
                    CategoryName = "Entertainment"
                },
                new Category
                {
                    CategoryId = new Guid("bb0bcf8c-7990-4b5b-bb3d-a7419206d761"),
                    CategoryName = "Travel"
                },
                new Category
                {
                    CategoryId = new Guid("c475e8e5-80d5-4c0c-a99a-3afc8586757c"),
                    CategoryName = "Cars"
                });
            // StaffUser
            modelBuilder.Entity<StaffUser>().HasData(
                new StaffUser
                {
                    Id = new Guid("d4295c4c-2739-48d6-9d1b-72708b7d82e7"),
                    FirstName = "Benjamin",
                    LastName = "Smith",
                    Email = "ben1.smith@hotmail.co.uk",
                    UserName = "ben1.smith@hotmail.co.uk",
                    NormalizedUserName = "BEN1.SMITH@HOTMAIL.CO.UK",
                    NormalizedEmail = "BEN1.SMITH@HOTMAIL.CO.UK",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEAPTnOqgtoDPTWbIYCUIep7gyuUxR4KtI2IGj0fSx/xT7ANgw6MjvPl6cGlvXZwU4Q==",
                    SecurityStamp = "IHOUA6XDHYAQYWLBJX6SRZ6J6MIXIMBQ",
                    ConcurrencyStamp = "1b9db57b-717c-47f7-81f3-8648badc7f3f",
                    LockoutEnabled = true
                },
                new StaffUser
                {
                    Id = new Guid("D0CCD3A8-6F7A-4883-6CFC-08D9F485C30A"),
                    FirstName = "Hayley",
                    LastName = "Sharpe",
                    Email = "h.sharpe@pablos.co.uk",
                    UserName = "h.sharpe@pablos.co.uk",
                    NormalizedUserName = "H.SHARPE@PABLOS.CO.UK",
                    NormalizedEmail = "H.SHARPE@PABLOS.CO.UK",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEO2RHoQtKZuzSFQQ+tYLsGEhiu3u1bDKfsgKdIMyC8BhGjZ3Bei+MYZD5FJdXhu1uQ==",
                    SecurityStamp = "PE6UGG57RHOOXYJUJK3KH7RHGF464AQC",
                    ConcurrencyStamp = "4c372cd8-61df-4794-b903-a7896260e60b",
                    LockoutEnabled = true
                },
                new StaffUser
                {
                    Id = new Guid("D210EA2B-E3CE-42BC-6CFB-08D9F485C30A"),
                    FirstName = "James",
                    LastName = "Carlsen",
                    Email = "james@carlsen.co.uk",
                    UserName = "james@carlsen.co.uk",
                    NormalizedUserName = "JAMES@CARLSEN.CO.UK",
                    NormalizedEmail = "JAMES@CARLSEN.CO.UK",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEF3S1BWev1pMBhwGp116e2qBhYvZBt1V+outXK9qevtAl4urm9KHgcGtT2FAI5DTCw==",
                    SecurityStamp = "D3SYUY34IEY2EL2FXB7NO3R3JU2NHVSK",
                    ConcurrencyStamp = "e51f56db-5571-42fe-ac07-271e690e7e3c",
                    LockoutEnabled = true
                });
            
        }
    }
}