using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Muhammad_Umar.Migrations
{
    public partial class StdDBFirstCreat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "formData",
                columns: table => new
                {
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    classificaton = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    language = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formData", x => x.email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "formData");
        }
    }
}
