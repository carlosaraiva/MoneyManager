﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoneyManager.SaraivaDev.API.Contexts;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MoneyManager.SaraivaDev.API.Migrations
{
    [DbContext(typeof(MoneyManagerContext))]
    [Migration("20210812081507_ChangeSchemas_1")]
    partial class ChangeSchemas_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FriendlyName")
                        .HasColumnType("text");

                    b.Property<string>("Xml")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionKeys");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.AccountModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar");

                    b.Property<int>("AccountType")
                        .HasColumnType("integer");

                    b.Property<string>("Agency")
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CurrencyId")
                        .IsRequired()
                        .HasColumnType("character varying");

                    b.Property<string>("HolderName")
                        .HasColumnType("text");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("InitialValue")
                        .HasColumnType("numeric");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("MMUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId")
                        .IsUnique();

                    b.HasIndex("MMUserId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.AddressModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar");

                    b.Property<int?>("AddressType")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Complement")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("MMUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("character varying(6)")
                        .HasMaxLength(6);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("character varying(10)")
                        .HasMaxLength(10);

                    b.Property<bool>("PreferedMailing")
                        .HasColumnType("boolean");

                    b.Property<string>("PublicPlace")
                        .IsRequired()
                        .HasColumnType("character varying(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.CategoryModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar");

                    b.Property<Guid>("CategoryFatherId")
                        .HasColumnType("uuid");

                    b.Property<string>("CategoryFatherId1")
                        .HasColumnType("character varying");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EntryTypeFor")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryFatherId1");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = "507dd21a-4f68-4ac7-a687-d915de206755",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "House",
                            EntryTypeFor = 2,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "62a56149-d7be-46ab-a6b3-6567937a967b",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phone Bill",
                            EntryTypeFor = 2,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "bd23d5e6-60ed-4a62-a168-21c0d2d68843",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Car",
                            EntryTypeFor = 2,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "8467ee69-d880-4e1d-994c-2b8c355d7687",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fuel",
                            EntryTypeFor = 2,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "3e12f3c7-23b9-4ab0-82d9-ae81cb7b94ab",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Salary",
                            EntryTypeFor = 1,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "574d9496-4fd2-4bfb-806e-032bb042207b",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Profit",
                            EntryTypeFor = 1,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "4e5125ba-4a6a-4a8c-a684-01dc8a3decf5",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bonus",
                            EntryTypeFor = 1,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.CostCenterModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar");

                    b.Property<string>("CostCenterFatherId")
                        .HasColumnType("text");

                    b.Property<string>("CostCenterId")
                        .HasColumnType("character varying");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CostCenterId");

                    b.ToTable("CostCenter");

                    b.HasData(
                        new
                        {
                            Id = "be0cc173-92d9-47dc-9470-5bd8701739a5",
                            CreateDate = new DateTime(2021, 8, 12, 9, 15, 7, 636, DateTimeKind.Local).AddTicks(2229),
                            Description = "Home",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 15, 7, 637, DateTimeKind.Local).AddTicks(4875)
                        },
                        new
                        {
                            Id = "66650b10-fbb3-4b3b-b59b-65ae8250dfd1",
                            CreateDate = new DateTime(2021, 8, 12, 9, 15, 7, 637, DateTimeKind.Local).AddTicks(5189),
                            Description = "Car",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 15, 7, 637, DateTimeKind.Local).AddTicks(5199)
                        },
                        new
                        {
                            Id = "3c9eea0f-50f2-434f-8482-e6b673a1808d",
                            CreateDate = new DateTime(2021, 8, 12, 9, 15, 7, 637, DateTimeKind.Local).AddTicks(5202),
                            Description = "Savings",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 15, 7, 637, DateTimeKind.Local).AddTicks(5204)
                        });
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.CurrencyModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("InternationalCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Currency");

                    b.HasData(
                        new
                        {
                            Id = "151fe323-0cdc-48c0-86a9-00350512f9f0",
                            CreateDate = new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(1965),
                            InternationalCode = "EUR",
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(1991),
                            Name = "EURO"
                        },
                        new
                        {
                            Id = "5d5c9abe-0162-4e4a-8fd4-1773df2778fa",
                            CreateDate = new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(1994),
                            InternationalCode = "GBP",
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(1997),
                            Name = "Pound Sterling"
                        },
                        new
                        {
                            Id = "5921e2be-f3b0-43b3-bd09-f7d2f99cd560",
                            CreateDate = new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(1999),
                            InternationalCode = "USD",
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(2001),
                            Name = "American Dollar"
                        },
                        new
                        {
                            Id = "f04d370a-057d-4361-bd5a-f8602e05fc94",
                            CreateDate = new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(2003),
                            InternationalCode = "BRL",
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(2004),
                            Name = "Brazilian Real"
                        });
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.EmailModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(600)")
                        .HasMaxLength(600);

                    b.Property<int?>("EmailType")
                        .HasColumnType("integer");

                    b.Property<string>("MMUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("PreferedEmail")
                        .HasColumnType("boolean");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.EntryModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("character varying");

                    b.Property<string>("CategoryId")
                        .HasColumnType("character varying");

                    b.Property<string>("CostCenterId")
                        .HasColumnType("character varying");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("EntryConfirmedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("EntryType")
                        .HasColumnType("integer");

                    b.Property<decimal>("EntryValue")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PaymentTypeId")
                        .HasColumnType("character varying");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CostCenterId");

                    b.HasIndex("PaymentTypeId")
                        .IsUnique();

                    b.ToTable("Entry");
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.MMUserModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TaxNumber")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("MMUser");
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.PaymentTypeModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("PaymentType");

                    b.HasData(
                        new
                        {
                            Id = "43987c58-0e04-49fc-b0cf-0bdec0f7d2d2",
                            CreateDate = new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5535),
                            Description = "Bank Transfer",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5553)
                        },
                        new
                        {
                            Id = "2446972a-fa17-4035-bec3-1ae408169870",
                            CreateDate = new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5778),
                            Description = "Debit Card",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5786)
                        },
                        new
                        {
                            Id = "be6b5488-f916-417a-bc38-85228fe96a51",
                            CreateDate = new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5788),
                            Description = "Credit Card",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5790)
                        },
                        new
                        {
                            Id = "1aa99d92-8582-4556-91e6-479df1569f68",
                            CreateDate = new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5792),
                            Description = "Paycheck",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5794)
                        });
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.PhoneModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar");

                    b.Property<string>("AreaNumber")
                        .IsRequired()
                        .HasColumnType("character varying(6)")
                        .HasMaxLength(6);

                    b.Property<string>("CountryNumber")
                        .IsRequired()
                        .HasColumnType("character varying(6)")
                        .HasMaxLength(6);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("MMUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("PhoneType")
                        .HasColumnType("integer");

                    b.Property<bool>("PreferedNumber")
                        .HasColumnType("boolean");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.MMUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.MMUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.MMUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.MMUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.AccountModel", b =>
                {
                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.CurrencyModel", "Currency")
                        .WithOne()
                        .HasForeignKey("MoneyManager.SaraivaDev.API.Models.Domain.AccountModel", "CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.MMUserModel", "MMUser")
                        .WithMany()
                        .HasForeignKey("MMUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.AddressModel", b =>
                {
                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.MMUserModel", "MMUser")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.CategoryModel", b =>
                {
                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.CategoryModel", "CategoryFather")
                        .WithMany()
                        .HasForeignKey("CategoryFatherId1");
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.CostCenterModel", b =>
                {
                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.CostCenterModel", "CostCenter")
                        .WithMany()
                        .HasForeignKey("CostCenterId");
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.EmailModel", b =>
                {
                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.MMUserModel", "MMUser")
                        .WithMany("Emails")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.EntryModel", b =>
                {
                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.AccountModel", "Account")
                        .WithMany("Entries")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.CategoryModel", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.CostCenterModel", "CostCenter")
                        .WithMany()
                        .HasForeignKey("CostCenterId");

                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.PaymentTypeModel", "PaymentType")
                        .WithOne()
                        .HasForeignKey("MoneyManager.SaraivaDev.API.Models.Domain.EntryModel", "PaymentTypeId");
                });

            modelBuilder.Entity("MoneyManager.SaraivaDev.API.Models.Domain.PhoneModel", b =>
                {
                    b.HasOne("MoneyManager.SaraivaDev.API.Models.Domain.MMUserModel", "MMUser")
                        .WithMany("Phones")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
