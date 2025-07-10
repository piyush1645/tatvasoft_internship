﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission.Entities.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EmailAddress", "FirstName", "LastName", "Password" },
                values: new object[] { "piyush@gmail.com", "Piyush", "Mevada", "1617" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EmailAddress", "FirstName", "LastName", "Password" },
                values: new object[] { "admin@tatvasoft.com", "Admin", "Tatva", "admin" });
        }
    }
}
