using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogIt.Migrations
{
    public partial class js : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "likeBlog",
                columns: table => new
                {
                    BlogId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_likeBlog", x => new { x.UserId, x.BlogId });
                    table.ForeignKey(
                        name: "FK_likeBlog_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_likeBlog_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_likeBlog_BlogId",
                table: "likeBlog",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "likeBlog");
        }
    }
}
