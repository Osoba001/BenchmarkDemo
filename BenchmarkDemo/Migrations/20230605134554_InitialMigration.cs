using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenchmarkDemo.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PasswordSalt = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFalseDeleted = table.Column<bool>(type: "bit", nullable: false),
                    FalseDeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllowSetNewPassword = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefreshTokenExpireTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PasswordRecoveryPin = table.Column<int>(type: "int", nullable: false),
                    RecoveryPinCreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserMaxProp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PasswordSalt = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFalseDeleted = table.Column<bool>(type: "bit", nullable: false),
                    FalseDeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllowSetNewPassword = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefreshTokenExpireTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PasswordRecoveryPin = table.Column<int>(type: "int", nullable: false),
                    RecoveryPinCreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMaxProp", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserMaxProp");
        }
    }
}
