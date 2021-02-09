﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingAPI.Data.Migrations
{
    public partial class MessageEntityAdded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SenderUserName",
                table: "Messages",
                newName: "SenderUsername");

            migrationBuilder.RenameColumn(
                name: "RecipientUserName",
                table: "Messages",
                newName: "RecipientUsername");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SenderUsername",
                table: "Messages",
                newName: "SenderUserName");

            migrationBuilder.RenameColumn(
                name: "RecipientUsername",
                table: "Messages",
                newName: "RecipientUserName");
        }
    }
}
