﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentManagementBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddPersons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Persons",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Persons");
        }
    }
}
