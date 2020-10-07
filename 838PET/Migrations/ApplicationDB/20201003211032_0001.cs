using Microsoft.EntityFrameworkCore.Migrations;

namespace _838PET.Migrations.ApplicationDB
{
    public partial class _0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PetServicos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    TechnicalDescription = table.Column<string>(nullable: true),
                    ComercialDescription = table.Column<string>(nullable: true),
                    ServiceSubscribe = table.Column<double>(nullable: false),
                    PriceMinimum = table.Column<double>(nullable: false),
                    MaxValue = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetServicos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetServicos");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
