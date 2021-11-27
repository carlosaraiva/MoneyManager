using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoneyManager.SaraivaDev.API.Migrations
{
    public partial class ChangeSchemas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Entry_CategoryId",
                table: "Entry");

            migrationBuilder.DropIndex(
                name: "IX_Entry_CostCenterId",
                table: "Entry");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "00969044-db68-40bc-9408-9db980d7b49e");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "559f1154-55ab-4d08-afa6-2598bacf0fc4");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "958f5ca3-cf42-4edd-99d0-63d3c703d564");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "acd75628-d303-4b46-b00e-957bb5f89d22");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "b1761748-33e8-4944-a04d-00f455f71be7");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "bc2db162-979c-45bc-8973-e0f69e01d247");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "cacfda99-6ff6-4eba-8512-a3c17f81153e");

            migrationBuilder.DeleteData(
                table: "CostCenter",
                keyColumn: "Id",
                keyValue: "c57f41c0-b0a4-40ff-ba97-86bb12c5ee8a");

            migrationBuilder.DeleteData(
                table: "CostCenter",
                keyColumn: "Id",
                keyValue: "ccf6c9bc-0d21-44e6-9c23-4dc972119629");

            migrationBuilder.DeleteData(
                table: "CostCenter",
                keyColumn: "Id",
                keyValue: "ed28f983-b5d5-4de6-8579-8d9343f6781c");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "3bcd0327-526b-4cae-8195-cc2bf9fcb0f9");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "43143a5f-c29d-45b7-8853-f403c4159677");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "65264ffa-443a-45c9-961a-b17e9b347a61");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "Id",
                keyValue: "99b25d53-b440-4adc-8052-e4f1ddf946bd");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "4c3cb023-0f48-494b-9349-227fb3a7f1e9");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "813cd57e-1d5b-4b62-8ae4-7f2ab1a6eead");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "ba21efe5-aec1-4050-b1b3-803eac614462");

            migrationBuilder.DeleteData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: "e99f3c2b-d57d-4822-9452-ed2161153067");

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

            migrationBuilder.CreateIndex(
                name: "IX_Entry_CategoryId",
                table: "Entry",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Entry_CostCenterId",
                table: "Entry",
                column: "CostCenterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Entry_CategoryId",
                table: "Entry");

            migrationBuilder.DropIndex(
                name: "IX_Entry_CostCenterId",
                table: "Entry");

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
                name: "IX_Entry_CategoryId",
                table: "Entry",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entry_CostCenterId",
                table: "Entry",
                column: "CostCenterId",
                unique: true);
        }
    }
}
