using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoneyManager.SaraivaDev.API.Migrations
{
    public partial class ChangeSchemas_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryFatherId", "CategoryFatherId1", "CreateDate", "Description", "EntryTypeFor", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { "ea26c59e-990f-475e-9e42-66c76b447a0f", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "House", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "6551d4d6-43ee-4f79-ac58-0e1e9b9ccf0d", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone Bill", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "e533f580-df6a-453f-9a05-9aa608851cc5", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Car", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "282ad9ce-605e-4a5a-8626-6e1387e40049", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuel", 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "a621b884-b875-4fca-8ed7-b9a349c5a2ac", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salary", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9f44bfa1-7a19-4ebd-95b4-f97fd6d5a764", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Profit", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ef8ef59e-f676-4d89-ad81-716e7aecf69a", new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bonus", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CostCenter",
                columns: new[] { "Id", "CostCenterFatherId", "CostCenterId", "CreateDate", "Description", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { "f9086752-2a0a-43cb-9121-7f6d3cebf9fe", null, null, new DateTime(2021, 8, 12, 9, 43, 17, 306, DateTimeKind.Local).AddTicks(7862), "Savings", true, new DateTime(2021, 8, 12, 9, 43, 17, 306, DateTimeKind.Local).AddTicks(7864) },
                    { "69360792-c432-4d5e-9bcb-05b82783ba12", null, null, new DateTime(2021, 8, 12, 9, 43, 17, 306, DateTimeKind.Local).AddTicks(7849), "Car", true, new DateTime(2021, 8, 12, 9, 43, 17, 306, DateTimeKind.Local).AddTicks(7859) },
                    { "42dc6a25-a6c2-4c88-8d5d-8fa3090e17ab", null, null, new DateTime(2021, 8, 12, 9, 43, 17, 305, DateTimeKind.Local).AddTicks(5189), "Home", true, new DateTime(2021, 8, 12, 9, 43, 17, 306, DateTimeKind.Local).AddTicks(7522) }
                });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "Id", "CreateDate", "InternationalCode", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { "c18471a7-7fed-4a68-b029-bd8429d8c997", new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(594), "EUR", new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(622), "EURO" },
                    { "dffe9439-51f7-4cfe-a964-4be679ca8729", new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(653), "GBP", new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(655), "Pound Sterling" },
                    { "bd6647fc-bd18-4472-b129-1e3f10baadbd", new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(657), "USD", new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(659), "American Dollar" },
                    { "c0ba163d-99c4-4006-8a63-62b295880e0c", new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(661), "BRL", new DateTime(2021, 8, 12, 9, 43, 17, 325, DateTimeKind.Local).AddTicks(663), "Brazilian Real" }
                });

            migrationBuilder.InsertData(
                table: "PaymentType",
                columns: new[] { "Id", "CreateDate", "Description", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { "ead62760-9fc6-4636-99ef-a93713c1ce1b", new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5600), "Bank Transfer", true, new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5618) },
                    { "63898cd1-59bd-4308-be4b-543c216b668c", new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5853), "Debit Card", true, new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5860) },
                    { "7c94d861-7cf6-416d-9a3e-13088efb5e30", new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5863), "Credit Card", true, new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5865) },
                    { "efe9d4db-edf9-481f-bcc0-f4203994a1cc", new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5867), "Paycheck", true, new DateTime(2021, 8, 12, 9, 43, 17, 327, DateTimeKind.Local).AddTicks(5869) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "282ad9ce-605e-4a5a-8626-6e1387e40049");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "6551d4d6-43ee-4f79-ac58-0e1e9b9ccf0d");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "9f44bfa1-7a19-4ebd-95b4-f97fd6d5a764");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "a621b884-b875-4fca-8ed7-b9a349c5a2ac");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "e533f580-df6a-453f-9a05-9aa608851cc5");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "ea26c59e-990f-475e-9e42-66c76b447a0f");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "ef8ef59e-f676-4d89-ad81-716e7aecf69a");

            migrationBuilder.DeleteData(
                table: "CostCenter",
                keyColumn: "Id",
                keyValue: "42dc6a25-a6c2-4c88-8d5d-8fa3090e17ab");

            migrationBuilder.DeleteData(
                table: "CostCenter",
                keyColumn: "Id",
                keyValue: "69360792-c432-4d5e-9bcb-05b82783ba12");

            migrationBuilder.DeleteData(
                table: "CostCenter",
                keyColumn: "Id",
                keyValue: "f9086752-2a0a-43cb-9121-7f6d3cebf9fe");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "bd6647fc-bd18-4472-b129-1e3f10baadbd");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "c0ba163d-99c4-4006-8a63-62b295880e0c");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "c18471a7-7fed-4a68-b029-bd8429d8c997");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "dffe9439-51f7-4cfe-a964-4be679ca8729");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "63898cd1-59bd-4308-be4b-543c216b668c");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "7c94d861-7cf6-416d-9a3e-13088efb5e30");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "ead62760-9fc6-4636-99ef-a93713c1ce1b");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "efe9d4db-edf9-481f-bcc0-f4203994a1cc");

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
    }
}
