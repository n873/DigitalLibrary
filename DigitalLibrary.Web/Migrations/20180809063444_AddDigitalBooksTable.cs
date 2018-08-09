using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DigitalLibrary.Web.Migrations
{
    public partial class AddDigitalBooksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DigitalBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AuthorId = table.Column<Guid>(nullable: true),
                    PublisherId = table.Column<Guid>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DigitalBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DigitalBooks_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DigitalBooks_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DigitalBooks_AuthorId",
                table: "DigitalBooks",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_DigitalBooks_PublisherId",
                table: "DigitalBooks",
                column: "PublisherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DigitalBooks");
        }
    }
}
