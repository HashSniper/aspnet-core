using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MPACORE.PhoneBook.Migrations
{
    public partial class Add_NewPersionAndNumberEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "PB");

            migrationBuilder.CreateTable(
                name: "Persion",
                schema: "PB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAdress = table.Column<string>(maxLength: 80, nullable: true),
                    Adress = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNum",
                schema: "PB",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Number = table.Column<string>(maxLength: 12, nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNum_Persion_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "PB",
                        principalTable: "Persion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNum_PersonId",
                schema: "PB",
                table: "PhoneNum",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneNum",
                schema: "PB");

            migrationBuilder.DropTable(
                name: "Persion",
                schema: "PB");
        }
    }
}
