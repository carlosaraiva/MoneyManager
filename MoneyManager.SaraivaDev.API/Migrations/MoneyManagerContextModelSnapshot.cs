﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoneyManager.SaraivaDev.API.Contexts;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MoneyManager.SaraivaDev.API.Migrations
{
    [DbContext(typeof(MoneyManagerContext))]
    partial class MoneyManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = "ea26c59e-990f-475e-9e42-66c76b447a0f",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "House",
                            EntryTypeFor = 2,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "6551d4d6-43ee-4f79-ac58-0e1e9b9ccf0d",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phone Bill",
                            EntryTypeFor = 2,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "e533f580-df6a-453f-9a05-9aa608851cc5",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Car",
                            EntryTypeFor = 2,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "282ad9ce-605e-4a5a-8626-6e1387e40049",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fuel",
                            EntryTypeFor = 2,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "a621b884-b875-4fca-8ed7-b9a349c5a2ac",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Salary",
                            EntryTypeFor = 1,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "9f44bfa1-7a19-4ebd-95b4-f97fd6d5a764",
                            CategoryFatherId = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Profit",
                            EntryTypeFor = 1,
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "ef8ef59e-f676-4d89-ad81-716e7aecf69a",
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
                            Id = "42dc6a25-a6c2-4c88-8d5d-8fa3090e17ab",
                            CreateDate = new DateTime(2021, 8, 12, 9, 43, 17, 305, DateTimeKind.Local).AddTicks(5189),
                            Description = "Home",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 43, 17, 306, DateTimeKind.Local).AddTicks(7522)
                        },
                        new
                        {
                            Id = "69360792-c432-4d5e-9bcb-05b82783ba12",
                            CreateDate = new DateTime(2021, 8, 12, 9, 43, 17, 306, DateTimeKind.Local).AddTicks(7849),
                            Description = "Car",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 43, 17, 306, DateTimeKind.Local).AddTicks(7859)
                        },
                        new
                        {
                            Id = "f9086752-2a0a-43cb-9121-7f6d3cebf9fe",
                            CreateDate = new DateTime(2021, 8, 12, 9, 43, 17, 306, DateTimeKind.Local).AddTicks(7862),
                            Description = "Savings",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 43, 17, 306, DateTimeKind.Local).AddTicks(7864)
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
                            Id = "c18471a7-7fed-4a68-b029-bd8429d8c997",
                            CreateDate = new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(594),
                            InternationalCode = "EUR",
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(622),
                            Name = "EURO"
                        },
                        new
                        {
                            Id = "dffe9439-51f7-4cfe-a964-4be679ca8729",
                            CreateDate = new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(653),
                            InternationalCode = "GBP",
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(655),
                            Name = "Pound Sterling"
                        },
                        new
                        {
                            Id = "bd6647fc-bd18-4472-b129-1e3f10baadbd",
                            CreateDate = new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(657),
                            InternationalCode = "USD",
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(659),
                            Name = "American Dollar"
                        },
                        new
                        {
                            Id = "c0ba163d-99c4-4006-8a63-62b295880e0c",
                            CreateDate = new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(661),
                            InternationalCode = "BRL",
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(663),
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
                            Id = "ead62760-9fc6-4636-99ef-a93713c1ce1b",
                            CreateDate = new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5600),
                            Description = "Bank Transfer",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5618)
                        },
                        new
                        {
                            Id = "63898cd1-59bd-4308-be4b-543c216b668c",
                            CreateDate = new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5853),
                            Description = "Debit Card",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5860)
                        },
                        new
                        {
                            Id = "7c94d861-7cf6-416d-9a3e-13088efb5e30",
                            CreateDate = new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5863),
                            Description = "Credit Card",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5865)
                        },
                        new
                        {
                            Id = "efe9d4db-edf9-481f-bcc0-f4203994a1cc",
                            CreateDate = new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5867),
                            Description = "Paycheck",
                            IsActive = true,
                            ModifiedDate = new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5869)
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