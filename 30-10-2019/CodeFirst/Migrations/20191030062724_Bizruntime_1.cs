using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class Bizruntime_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    D_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D_Name = table.Column<string>(nullable: true),
                    D_Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.D_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
