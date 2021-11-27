using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoneyManager.SaraivaDev.API.Migrations
{
    public partial class ChangeSchemas_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "094bec9c-1607-402e-b7f3-f8d79517cd0c");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "0e45e003-aec9-4f59-957e-513506ad75ff");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "1f809f8e-dd98-4aeb-84a9-df5b38e76113");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "2f8ed330-001e-412a-8e62-8d363aacbd1d");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "8cc256dd-8770-4fcd-b21d-a28b05e2c725");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "ad12ff36-61a9-4a7d-a2a2-325863ceef2b");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "f680d164-df62-47fa-9ac8-874b4888dd50");

            migrationBuilder.DeleteData(
                table: "CostCenter",
                keyColumn: "Id",
                keyValue: "09dde5de-fffd-4d36-baa0-18082e1dd3fd");

            migrationBuilder.DeleteData(
                table: "CostCenter",
                keyColumn: "Id",
                keyValue: "469eba5b-7298-4cff-937b-0159690b97a2");

            migrationBuilder.DeleteData(
                table: "CostCenter",
                keyColumn: "Id",
                keyValue: "bf5be565-e1f5-4d16-9faf-e8b128ead133");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "69a54784-adb3-4a30-85d4-0f39170a99b2");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "88b210cd-8d8f-42f1-905c-b004cf64b74f");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "9421dd8a-349e-40c9-b19a-8224f2cfd2d2");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "b5dd3658-8eda-46bf-965f-ad84742eb476");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "08c4321c-0372-4b7d-946c-435f146a2773");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "792eaaf7-97e2-416d-84d3-ebeaeb84ce92");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "947b15a9-236f-4872-892d-0dceda58fa02");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "b4b3ebf1-997b-4f2d-a61d-ce21a0feaa2b");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Phone",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "PaymentType",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentTypeId",
                table: "Entry",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CostCenterId",
                table: "Entry",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Entry",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Entry",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Entry",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Email",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Currency",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CostCenterId",
                table: "CostCenter",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "CostCenter",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryFatherId1",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Address",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyId",
                table: "Account",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Account",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryFatherId", "CategoryFatherId1", "CreateDate", "Description", "EntryTypeFor", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { "507dd21a-4f68-4ac7-a687-d915de206755", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "House", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "62a56149-d7be-46ab-a6b3-6567937a967b", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone Bill", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "bd23d5e6-60ed-4a62-a168-21c0d2d68843", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Car", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "8467ee69-d880-4e1d-994c-2b8c355d7687", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3e12f3c7-23b9-4ab0-82d9-ae81cb7b94ab", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salary", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "574d9496-4fd2-4bfb-806e-032bb042207b", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Profit", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4e5125ba-4a6a-4a8c-a684-01dc8a3decf5", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonus", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CostCenter",
                columns: new[] { "Id", "CostCenterFatherId", "CostCenterId", "CreateDate", "Description", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { "3c9eea0f-50f2-434f-8482-e6b673a1808d", null, null, new DateTime(2021, 8, 12, 9, 15, 7, 637, DateTimeKind.Local).AddTicks(5202), "Savings", true, new DateTime(2021, 8, 12, 9, 15, 7, 637, DateTimeKind.Local).AddTicks(5204) },
                    { "66650b10-fbb3-4b3b-b59b-65ae8250dfd1", null, null, new DateTime(2021, 8, 12, 9, 15, 7, 637, DateTimeKind.Local).AddTicks(5189), "Car", true, new DateTime(2021, 8, 12, 9, 15, 7, 637, DateTimeKind.Local).AddTicks(5199) },
                    { "be0cc173-92d9-47dc-9470-5bd8701739a5", null, null, new DateTime(2021, 8, 12, 9, 15, 7, 636, DateTimeKind.Local).AddTicks(2229), "Home", true, new DateTime(2021, 8, 12, 9, 15, 7, 637, DateTimeKind.Local).AddTicks(4875) }
                });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "Id", "CreateDate", "InternationalCode", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { "151fe323-0cdc-48c0-86a9-00350512f9f0", new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(1965), "EUR", new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(1991), "EURO" },
                    { "5d5c9abe-0162-4e4a-8fd4-1773df2778fa", new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(1994), "GBP", new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(1997), "Pound Sterling" },
                    { "5921e2be-f3b0-43b3-bd09-f7d2f99cd560", new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(1999), "USD", new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(2001), "American Dollar" },
                    { "f04d370a-057d-4361-bd5a-f8602e05fc94", new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(2003), "BRL", new DateTime(2021, 8, 12, 9, 15, 7, 655, DateTimeKind.Local).AddTicks(2004), "Brazilian Real" }
                });

            migrationBuilder.InsertData(
                table: "PaymentType",
                columns: new[] { "Id", "CreateDate", "Description", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { "43987c58-0e04-49fc-b0cf-0bdec0f7d2d2", new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5535), "Bank Transfer", true, new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5553) },
                    { "2446972a-fa17-4035-bec3-1ae408169870", new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5778), "Debit Card", true, new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5786) },
                    { "be6b5488-f916-417a-bc38-85228fe96a51", new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5788), "Credit Card", true, new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5790) },
                    { "1aa99d92-8582-4556-91e6-479df1569f68", new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5792), "Paycheck", true, new DateTime(2021, 8, 12, 9, 15, 7, 657, DateTimeKind.Local).AddTicks(5794) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "3e12f3c7-23b9-4ab0-82d9-ae81cb7b94ab");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "4e5125ba-4a6a-4a8c-a684-01dc8a3decf5");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "507dd21a-4f68-4ac7-a687-d915de206755");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "574d9496-4fd2-4bfb-806e-032bb042207b");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "62a56149-d7be-46ab-a6b3-6567937a967b");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "8467ee69-d880-4e1d-994c-2b8c355d7687");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bd23d5e6-60ed-4a62-a168-21c0d2d68843");

            migrationBuilder.DeleteData(
                table: "CostCenter",
                keyColumn: "Id",
                keyValue: "3c9eea0f-50f2-434f-8482-e6b673a1808d");

            migrationBuilder.DeleteData(
                table: "CostCenter",
                keyColumn: "Id",
                keyValue: "66650b10-fbb3-4b3b-b59b-65ae8250dfd1");

            migrationBuilder.DeleteData(
                table: "CostCenter",
                keyColumn: "Id",
                keyValue: "be0cc173-92d9-47dc-9470-5bd8701739a5");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "151fe323-0cdc-48c0-86a9-00350512f9f0");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "5921e2be-f3b0-43b3-bd09-f7d2f99cd560");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "5d5c9abe-0162-4e4a-8fd4-1773df2778fa");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "f04d370a-057d-4361-bd5a-f8602e05fc94");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "1aa99d92-8582-4556-91e6-479df1569f68");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "2446972a-fa17-4035-bec3-1ae408169870");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "43987c58-0e04-49fc-b0cf-0bdec0f7d2d2");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "be6b5488-f916-417a-bc38-85228fe96a51");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Phone",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "PaymentType",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentTypeId",
                table: "Entry",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CostCenterId",
                table: "Entry",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Entry",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "Entry",
                type: "text",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Entry",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Email",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Currency",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<string>(
                name: "CostCenterId",
                table: "CostCenter",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "CostCenter",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryFatherId1",
                table: "Category",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Address",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyId",
                table: "Account",
                type: "text",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Account",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryFatherId", "CategoryFatherId1", "CreateDate", "Description", "EntryTypeFor", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { "094bec9c-1607-402e-b7f3-f8d79517cd0c", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "House", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ad12ff36-61a9-4a7d-a2a2-325863ceef2b", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone Bill", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "8cc256dd-8770-4fcd-b21d-a28b05e2c725", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Car", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "0e45e003-aec9-4f59-957e-513506ad75ff", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "f680d164-df62-47fa-9ac8-874b4888dd50", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salary", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2f8ed330-001e-412a-8e62-8d363aacbd1d", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Profit", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1f809f8e-dd98-4aeb-84a9-df5b38e76113", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonus", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CostCenter",
                columns: new[] { "Id", "CostCenterFatherId", "CostCenterId", "CreateDate", "Description", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { "bf5be565-e1f5-4d16-9faf-e8b128ead133", null, null, new DateTime(2021, 8, 12, 8, 35, 17, 668, DateTimeKind.Local).AddTicks(9277), "Savings", true, new DateTime(2021, 8, 12, 8, 35, 17, 668, DateTimeKind.Local).AddTicks(9280) },
                    { "09dde5de-fffd-4d36-baa0-18082e1dd3fd", null, null, new DateTime(2021, 8, 12, 8, 35, 17, 668, DateTimeKind.Local).AddTicks(9264), "Car", true, new DateTime(2021, 8, 12, 8, 35, 17, 668, DateTimeKind.Local).AddTicks(9274) },
                    { "469eba5b-7298-4cff-937b-0159690b97a2", null, null, new DateTime(2021, 8, 12, 8, 35, 17, 667, DateTimeKind.Local).AddTicks(1661), "Home", true, new DateTime(2021, 8, 12, 8, 35, 17, 668, DateTimeKind.Local).AddTicks(8931) }
                });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "Id", "CreateDate", "InternationalCode", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { "88b210cd-8d8f-42f1-905c-b004cf64b74f", new DateTime(2021, 8, 12, 8, 35, 17, 687, DateTimeKind.Local).AddTicks(8695), "EUR", new DateTime(2021, 8, 12, 8, 35, 17, 687, DateTimeKind.Local).AddTicks(8734), "EURO" },
                    { "b5dd3658-8eda-46bf-965f-ad84742eb476", new DateTime(2021, 8, 12, 8, 35, 17, 687, DateTimeKind.Local).AddTicks(8738), "GBP", new DateTime(2021, 8, 12, 8, 35, 17, 687, DateTimeKind.Local).AddTicks(8740), "Pound Sterling" },
                    { "69a54784-adb3-4a30-85d4-0f39170a99b2", new DateTime(2021, 8, 12, 8, 35, 17, 687, DateTimeKind.Local).AddTicks(8742), "USD", new DateTime(2021, 8, 12, 8, 35, 17, 687, DateTimeKind.Local).AddTicks(8744), "American Dollar" },
                    { "9421dd8a-349e-40c9-b19a-8224f2cfd2d2", new DateTime(2021, 8, 12, 8, 35, 17, 687, DateTimeKind.Local).AddTicks(8747), "BRL", new DateTime(2021, 8, 12, 8, 35, 17, 687, DateTimeKind.Local).AddTicks(8748), "Brazilian Real" }
                });

            migrationBuilder.InsertData(
                table: "PaymentType",
                columns: new[] { "Id", "CreateDate", "Description", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { "b4b3ebf1-997b-4f2d-a61d-ce21a0feaa2b", new DateTime(2021, 8, 12, 8, 35, 17, 690, DateTimeKind.Local).AddTicks(5188), "Bank Transfer", true, new DateTime(2021, 8, 12, 8, 35, 17, 690, DateTimeKind.Local).AddTicks(5205) },
                    { "947b15a9-236f-4872-892d-0dceda58fa02", new DateTime(2021, 8, 12, 8, 35, 17, 690, DateTimeKind.Local).AddTicks(5437), "Debit Card", true, new DateTime(2021, 8, 12, 8, 35, 17, 690, DateTimeKind.Local).AddTicks(5444) },
                    { "08c4321c-0372-4b7d-946c-435f146a2773", new DateTime(2021, 8, 12, 8, 35, 17, 690, DateTimeKind.Local).AddTicks(5447), "Credit Card", true, new DateTime(2021, 8, 12, 8, 35, 17, 690, DateTimeKind.Local).AddTicks(5449) },
                    { "792eaaf7-97e2-416d-84d3-ebeaeb84ce92", new DateTime(2021, 8, 12, 8, 35, 17, 690, DateTimeKind.Local).AddTicks(5451), "Paycheck", true, new DateTime(2021, 8, 12, 8, 35, 17, 690, DateTimeKind.Local).AddTicks(5453) }
                });
        }
    }
}
