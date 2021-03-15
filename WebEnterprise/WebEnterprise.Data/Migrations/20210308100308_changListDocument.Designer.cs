﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebEnterprise.Data.EF;

namespace WebEnterprise.Data.Migrations
{
    [DbContext(typeof(WebEnterpriseDbContext))]
    [Migration("20210308100308_changListDocument")]
    partial class changListDocument
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("a0626e5f-0945-425c-9135-421ce9ffd4a1"),
                            RoleId = new Guid("9936b153-37a9-41d8-9781-f0532c25e732")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserToken");
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.Contact", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApartmentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameStreet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalofDocument")
                        .HasColumnType("int");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            ApartmentNumber = "10",
                            NameStreet = "My Da Dong",
                            TotalofDocument = 0,
                            UserID = new Guid("a0626e5f-0945-425c-9135-421ce9ffd4a1")
                        });
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.Document", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacultyOfDocumentID")
                        .HasColumnType("int");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<int>("MagazineID")
                        .HasColumnType("int");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FacultyOfDocumentID");

                    b.HasIndex("MagazineID");

                    b.HasIndex("UserID");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.Faculty", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Faculty");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "IT"
                        });
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.FacultyOfDocument", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("FacultyOfDocument");
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.GroupUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GroupUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9936b153-37a9-41d8-9781-f0532c25e732"),
                            ConcurrencyStamp = "83e8b8ce-57ae-41e0-8bc9-c2b5ba5e4b48",
                            Name = "admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.Language", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = "vi",
                            IsDefault = true,
                            Name = "Tiếng Việt"
                        },
                        new
                        {
                            Id = "en",
                            IsDefault = false,
                            Name = "English"
                        });
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.Magazine", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Magazines");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Magazine Information Technology"
                        });
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.Position", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacultyID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("FacultyID");

                    b.HasIndex("UserID");

                    b.ToTable("Position");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FacultyID = 1,
                            Name = "No Position",
                            UserID = new Guid("a0626e5f-0945-425c-9135-421ce9ffd4a1")
                        });
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.SchoolYear", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDayYear")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDayYear")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("SchoolYears");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            EndDayYear = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDayYear = new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserID = new Guid("a0626e5f-0945-425c-9135-421ce9ffd4a1")
                        });
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a0626e5f-0945-425c-9135-421ce9ffd4a1"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "73e0f1fb-817f-4aa4-b983-492ff7d42020",
                            CreateOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(2000, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "minhvu09033@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Tran Van",
                            LastName = "Minh Vu",
                            LockoutEnabled = false,
                            NormalizedEmail = "minhvu09033@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAENkOvV39z6YoF+NFuKlHK93cl2BKwYcd6INbXlL71MWTCXH4HrXsvFn+pZZHUyzU0A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            Sex = false,
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.UserImage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ContactID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DayCreated")
                        .HasColumnType("datetime2");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ContactID");

                    b.ToTable("UserImages");
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.Contact", b =>
                {
                    b.HasOne("WebEnterprise.Data.Entities.User", "Users")
                        .WithMany("Contacts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.Document", b =>
                {
                    b.HasOne("WebEnterprise.Data.Entities.FacultyOfDocument", "FacultyOfDocuments")
                        .WithMany("Documents")
                        .HasForeignKey("FacultyOfDocumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebEnterprise.Data.Entities.Magazine", "Magazines")
                        .WithMany("Documents")
                        .HasForeignKey("MagazineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebEnterprise.Data.Entities.User", "User")
                        .WithMany("Documents")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.Position", b =>
                {
                    b.HasOne("WebEnterprise.Data.Entities.Faculty", "Faculties")
                        .WithMany("Positions")
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebEnterprise.Data.Entities.User", "Users")
                        .WithMany("Positions")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.SchoolYear", b =>
                {
                    b.HasOne("WebEnterprise.Data.Entities.User", "Users")
                        .WithMany("SchoolYears")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebEnterprise.Data.Entities.UserImage", b =>
                {
                    b.HasOne("WebEnterprise.Data.Entities.Contact", "Contacts")
                        .WithMany("UserImages")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
