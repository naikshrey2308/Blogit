using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogIt.Migrations
{
    public partial class sss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserBlogs",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    BlogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBlogs", x => new { x.UserId, x.BlogId });
                    table.ForeignKey(
                        name: "FK_UserBlogs_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBlogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserBlogs_BlogId",
                table: "UserBlogs",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBlogs");
        }
    }
}
