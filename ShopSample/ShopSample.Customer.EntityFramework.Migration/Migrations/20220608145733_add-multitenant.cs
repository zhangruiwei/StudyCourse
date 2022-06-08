using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopSample.Customer.EntityFramework.Migration.Migrations
{
    public partial class addmultitenant : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "Customer",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Customer");
        }
    }
}
