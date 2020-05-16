﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ThePeopleSearch.Data.Migrations
{
    public partial class AddPersonStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Persons",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Persons");
        }
    }
}
