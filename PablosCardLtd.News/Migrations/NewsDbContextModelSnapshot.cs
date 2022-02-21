﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PablosCardLtd.News;

#nullable disable

namespace PablosCardLtd.News.Migrations
{
    [DbContext(typeof(NewsDbContext))]
    partial class NewsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PablosCardLtd.News.Entities.Article", b =>
                {
                    b.Property<Guid>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ViewCountId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ArticleId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ViewCountId")
                        .IsUnique();

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("PablosCardLtd.News.Entities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("8c81915d-438e-49e4-bf6a-9acf0af7bd40"),
                            CategoryName = "News"
                        },
                        new
                        {
                            CategoryId = new Guid("676e0638-a3ef-4367-b340-e3268095a397"),
                            CategoryName = "Entertainment"
                        },
                        new
                        {
                            CategoryId = new Guid("bb0bcf8c-7990-4b5b-bb3d-a7419206d761"),
                            CategoryName = "Travel"
                        },
                        new
                        {
                            CategoryId = new Guid("c475e8e5-80d5-4c0c-a99a-3afc8586757c"),
                            CategoryName = "Cars"
                        });
                });

            modelBuilder.Entity("PablosCardLtd.News.Entities.StaffUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d4295c4c-2739-48d6-9d1b-72708b7d82e7"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1b9db57b-717c-47f7-81f3-8648badc7f3f",
                            Email = "ben1.smith@hotmail.co.uk",
                            EmailConfirmed = true,
                            FirstName = "Benjamin",
                            LastName = "Smith",
                            LockoutEnabled = true,
                            NormalizedEmail = "BEN1.SMITH@HOTMAIL.CO.UK",
                            NormalizedUserName = "BEN1.SMITH@HOTMAIL.CO.UK",
                            PasswordHash = "AQAAAAEAACcQAAAAEAPTnOqgtoDPTWbIYCUIep7gyuUxR4KtI2IGj0fSx/xT7ANgw6MjvPl6cGlvXZwU4Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "IHOUA6XDHYAQYWLBJX6SRZ6J6MIXIMBQ",
                            TwoFactorEnabled = false,
                            UserName = "ben1.smith@hotmail.co.uk"
                        },
                        new
                        {
                            Id = new Guid("d0ccd3a8-6f7a-4883-6cfc-08d9f485c30a"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4c372cd8-61df-4794-b903-a7896260e60b",
                            Email = "h.sharpe@pablos.co.uk",
                            EmailConfirmed = true,
                            FirstName = "Hayley",
                            LastName = "Sharpe",
                            LockoutEnabled = true,
                            NormalizedEmail = "H.SHARPE@PABLOS.CO.UK",
                            NormalizedUserName = "H.SHARPE@PABLOS.CO.UK",
                            PasswordHash = "AQAAAAEAACcQAAAAEO2RHoQtKZuzSFQQ+tYLsGEhiu3u1bDKfsgKdIMyC8BhGjZ3Bei+MYZD5FJdXhu1uQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "PE6UGG57RHOOXYJUJK3KH7RHGF464AQC",
                            TwoFactorEnabled = false,
                            UserName = "h.sharpe@pablos.co.uk"
                        },
                        new
                        {
                            Id = new Guid("d210ea2b-e3ce-42bc-6cfb-08d9f485c30a"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e51f56db-5571-42fe-ac07-271e690e7e3c",
                            Email = "james@carlsen.co.uk",
                            EmailConfirmed = true,
                            FirstName = "James",
                            LastName = "Carlsen",
                            LockoutEnabled = true,
                            NormalizedEmail = "JAMES@CARLSEN.CO.UK",
                            NormalizedUserName = "JAMES@CARLSEN.CO.UK",
                            PasswordHash = "AQAAAAEAACcQAAAAEF3S1BWev1pMBhwGp116e2qBhYvZBt1V+outXK9qevtAl4urm9KHgcGtT2FAI5DTCw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "D3SYUY34IEY2EL2FXB7NO3R3JU2NHVSK",
                            TwoFactorEnabled = false,
                            UserName = "james@carlsen.co.uk"
                        });
                });

            modelBuilder.Entity("PablosCardLtd.News.Entities.StaffUserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("PablosCardLtd.News.Entities.ViewCount", b =>
                {
                    b.Property<Guid>("ViewCountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<int>("ViewCountAmount")
                        .HasColumnType("int");

                    b.HasKey("ViewCountId");

                    b.ToTable("ViewCounts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("PablosCardLtd.News.Entities.StaffUserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("PablosCardLtd.News.Entities.StaffUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("PablosCardLtd.News.Entities.StaffUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("PablosCardLtd.News.Entities.StaffUserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PablosCardLtd.News.Entities.StaffUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("PablosCardLtd.News.Entities.StaffUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PablosCardLtd.News.Entities.Article", b =>
                {
                    b.HasOne("PablosCardLtd.News.Entities.StaffUser", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PablosCardLtd.News.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PablosCardLtd.News.Entities.ViewCount", "ViewCount")
                        .WithOne("Article")
                        .HasForeignKey("PablosCardLtd.News.Entities.Article", "ViewCountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("ViewCount");
                });

            modelBuilder.Entity("PablosCardLtd.News.Entities.StaffUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("PablosCardLtd.News.Entities.ViewCount", b =>
                {
                    b.Navigation("Article")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
