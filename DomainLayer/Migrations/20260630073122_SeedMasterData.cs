using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DomainLayer.Migrations
{
    /// <inheritdoc />
    public partial class SeedMasterData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AssetDefinitions",
                columns: new[] { "AssetDefinitionId", "AssetName", "AssetTypeId", "Brand", "Description", "IsActive", "Model" },
                values: new object[,]
                {
                    { 1, "Dell Latitude 5420", 1, "Dell", "Business Laptop", true, "Latitude 5420" },
                    { 2, "Samsung Galaxy S24", 2, "Samsung", "Android Mobile", true, "S24" },
                    { 3, "HP LaserJet Pro", 3, "HP", "Office Printer", true, "M404" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorId", "Address", "ContactNumber", "ContactPerson", "Email", "IsActive", "VendorName" },
                values: new object[,]
                {
                    { 1, "Bangalore", "9876543210", "John Smith", "john@dell.com", true, "Dell Technologies" },
                    { 2, "Chennai", "9123456780", "Rahul Kumar", "rahul@hp.com", true, "HP India" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseOrders",
                columns: new[] { "PurchaseOrderId", "AssetDefinitionId", "PurchaseDate", "Quantity", "Status", "UnitPrice", "VendorId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Asset Details Registered Internally", 65000.00m, 1 },
                    { 2, 2, new DateTime(2026, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Asset Details Registered Internally", 45000.00m, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssetDefinitions",
                keyColumn: "AssetDefinitionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PurchaseOrders",
                keyColumn: "PurchaseOrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AssetDefinitions",
                keyColumn: "AssetDefinitionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AssetDefinitions",
                keyColumn: "AssetDefinitionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorId",
                keyValue: 2);
        }
    }
}
