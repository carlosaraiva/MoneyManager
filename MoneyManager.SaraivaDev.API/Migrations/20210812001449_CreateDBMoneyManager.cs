using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MoneyManager.SaraivaDev.API.Migrations
{
    public partial class CreateDBMoneyManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    EntryTypeFor = table.Column<int>(nullable: false),
                    CategoryFatherId = table.Column<Guid>(nullable: false),
                    CategoryFatherId1 = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Category_CategoryFatherId1",
                        column: x => x.CategoryFatherId1,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CostCenter",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CostCenterFatherId = table.Column<string>(nullable: true),
                    CostCenterId = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCenter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostCenter_CostCenter_CostCenterId",
                        column: x => x.CostCenterId,
                        principalTable: "CostCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    InternationalCode = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataProtectionKeys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FriendlyName = table.Column<string>(nullable: true),
                    Xml = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataProtectionKeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MMUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    TaxNumber = table.Column<string>(maxLength: 20, nullable: false),
                    IdNumber = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MMUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    MMUserId = table.Column<string>(nullable: false),
                    AccountType = table.Column<int>(nullable: false),
                    InitialValue = table.Column<decimal>(nullable: false),
                    InitialDate = table.Column<DateTime>(nullable: false),
                    CurrencyId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    HolderName = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Agency = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_MMUser_MMUserId",
                        column: x => x.MMUserId,
                        principalTable: "MMUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    MMUserId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    AddressType = table.Column<int>(nullable: true),
                    PreferedMailing = table.Column<bool>(nullable: false),
                    PublicPlace = table.Column<string>(maxLength: 1000, nullable: false),
                    Number = table.Column<string>(maxLength: 6, nullable: false),
                    Complement = table.Column<string>(maxLength: 20, nullable: true),
                    Country = table.Column<string>(maxLength: 200, nullable: false),
                    District = table.Column<string>(maxLength: 200, nullable: false),
                    City = table.Column<string>(maxLength: 200, nullable: false),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_MMUser_UserId",
                        column: x => x.UserId,
                        principalTable: "MMUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    MMUserId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    EmailType = table.Column<int>(nullable: true),
                    Email = table.Column<string>(maxLength: 600, nullable: false),
                    PreferedEmail = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Email_MMUser_UserId",
                        column: x => x.UserId,
                        principalTable: "MMUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    MMUserId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    PhoneType = table.Column<int>(nullable: true),
                    CountryNumber = table.Column<string>(maxLength: 6, nullable: false),
                    AreaNumber = table.Column<string>(maxLength: 6, nullable: false),
                    PreferedNumber = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phone_MMUser_UserId",
                        column: x => x.UserId,
                        principalTable: "MMUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_MMUser_UserId",
                        column: x => x.UserId,
                        principalTable: "MMUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_MMUser_UserId",
                        column: x => x.UserId,
                        principalTable: "MMUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserToken_MMUser_UserId",
                        column: x => x.UserId,
                        principalTable: "MMUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_MMUser_UserId",
                        column: x => x.UserId,
                        principalTable: "MMUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entry",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AccountId = table.Column<string>(nullable: false),
                    EntryType = table.Column<int>(nullable: false),
                    EntryConfirmedDate = table.Column<DateTime>(nullable: true),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    EntryValue = table.Column<decimal>(nullable: false),
                    CategoryId = table.Column<string>(nullable: true),
                    CostCenterId = table.Column<string>(nullable: true),
                    PaymentTypeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entry_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entry_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entry_CostCenter_CostCenterId",
                        column: x => x.CostCenterId,
                        principalTable: "CostCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entry_PaymentType_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryFatherId", "CategoryFatherId1", "CreateDate", "Description", "EntryTypeFor", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { "958f5ca3-cf42-4edd-99d0-63d3c703d564", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "House", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "559f1154-55ab-4d08-afa6-2598bacf0fc4", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone Bill", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "acd75628-d303-4b46-b00e-957bb5f89d22", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Car", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "00969044-db68-40bc-9408-9db980d7b49e", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "cacfda99-6ff6-4eba-8512-a3c17f81153e", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salary", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "bc2db162-979c-45bc-8973-e0f69e01d247", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Profit", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "b1761748-33e8-4944-a04d-00f455f71be7", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonus", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CostCenter",
                columns: new[] { "Id", "CostCenterFatherId", "CostCenterId", "CreateDate", "Description", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { "ccf6c9bc-0d21-44e6-9c23-4dc972119629", null, null, new DateTime(2021, 8, 12, 1, 14, 49, 243, DateTimeKind.Local).AddTicks(7893), "Savings", true, new DateTime(2021, 8, 12, 1, 14, 49, 243, DateTimeKind.Local).AddTicks(7894) },
                    { "ed28f983-b5d5-4de6-8579-8d9343f6781c", null, null, new DateTime(2021, 8, 12, 1, 14, 49, 243, DateTimeKind.Local).AddTicks(7880), "Car", true, new DateTime(2021, 8, 12, 1, 14, 49, 243, DateTimeKind.Local).AddTicks(7890) },
                    { "c57f41c0-b0a4-40ff-ba97-86bb12c5ee8a", null, null, new DateTime(2021, 8, 12, 1, 14, 49, 242, DateTimeKind.Local).AddTicks(5410), "Home", true, new DateTime(2021, 8, 12, 1, 14, 49, 243, DateTimeKind.Local).AddTicks(7563) }
                });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "Id", "CreateDate", "InternationalCode", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { "3bcd0327-526b-4cae-8195-cc2bf9fcb0f9", new DateTime(2021, 8, 12, 1, 14, 49, 262, DateTimeKind.Local).AddTicks(4448), "EUR", new DateTime(2021, 8, 12, 1, 14, 49, 262, DateTimeKind.Local).AddTicks(4483), "EURO" },
                    { "65264ffa-443a-45c9-961a-b17e9b347a61", new DateTime(2021, 8, 12, 1, 14, 49, 262, DateTimeKind.Local).AddTicks(4487), "GBP", new DateTime(2021, 8, 12, 1, 14, 49, 262, DateTimeKind.Local).AddTicks(4489), "Pound Sterling" },
                    { "43143a5f-c29d-45b7-8853-f403c4159677", new DateTime(2021, 8, 12, 1, 14, 49, 262, DateTimeKind.Local).AddTicks(4491), "USD", new DateTime(2021, 8, 12, 1, 14, 49, 262, DateTimeKind.Local).AddTicks(4493), "American Dollar" },
                    { "99b25d53-b440-4adc-8052-e4f1ddf946bd", new DateTime(2021, 8, 12, 1, 14, 49, 262, DateTimeKind.Local).AddTicks(4495), "BRL", new DateTime(2021, 8, 12, 1, 14, 49, 262, DateTimeKind.Local).AddTicks(4497), "Brazilian Real" }
                });

            migrationBuilder.InsertData(
                table: "PaymentType",
                columns: new[] { "Id", "CreateDate", "Description", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { "e99f3c2b-d57d-4822-9452-ed2161153067", new DateTime(2021, 8, 12, 1, 14, 49, 265, DateTimeKind.Local).AddTicks(2283), "Bank Transfer", true, new DateTime(2021, 8, 12, 1, 14, 49, 265, DateTimeKind.Local).AddTicks(2305) },
                    { "ba21efe5-aec1-4050-b1b3-803eac614462", new DateTime(2021, 8, 12, 1, 14, 49, 265, DateTimeKind.Local).AddTicks(2541), "Debit Card", true, new DateTime(2021, 8, 12, 1, 14, 49, 265, DateTimeKind.Local).AddTicks(2549) },
                    { "4c3cb023-0f48-494b-9349-227fb3a7f1e9", new DateTime(2021, 8, 12, 1, 14, 49, 265, DateTimeKind.Local).AddTicks(2551), "Credit Card", true, new DateTime(2021, 8, 12, 1, 14, 49, 265, DateTimeKind.Local).AddTicks(2554) },
                    { "813cd57e-1d5b-4b62-8ae4-7f2ab1a6eead", new DateTime(2021, 8, 12, 1, 14, 49, 265, DateTimeKind.Local).AddTicks(2556), "Paycheck", true, new DateTime(2021, 8, 12, 1, 14, 49, 265, DateTimeKind.Local).AddTicks(2558) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_CurrencyId",
                table: "Account",
                column: "CurrencyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Account_MMUserId",
                table: "Account",
                column: "MMUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryFatherId1",
                table: "Category",
                column: "CategoryFatherId1");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenter_CostCenterId",
                table: "CostCenter",
                column: "CostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Email_UserId",
                table: "Email",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Entry_AccountId",
                table: "Entry",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Entry_CategoryId",
                table: "Entry",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entry_CostCenterId",
                table: "Entry",
                column: "CostCenterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entry_PaymentTypeId",
                table: "Entry",
                column: "PaymentTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "MMUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "MMUser",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phone_UserId",
                table: "Phone",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "DataProtectionKeys");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Entry");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "CostCenter");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "MMUser");
        }
    }
}
