using Microsoft.EntityFrameworkCore.Migrations;

namespace ImprovedWorkCenter.Migrations
{
    public partial class improvedWorkCenterDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    ActividadId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocioId = table.Column<int>(nullable: false),
                    NombreSocio = table.Column<string>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    HorarioInicio = table.Column<int>(nullable: false),
                    HorarioFinal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.ActividadId);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    PlanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocioId = table.Column<int>(nullable: false),
                    NombreSocio = table.Column<string>(nullable: false),
                    Precio = table.Column<double>(nullable: false),
                    TipoPlan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.PlanId);
                });

            migrationBuilder.CreateTable(
                name: "Socios",
                columns: table => new
                {
                    SocioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false),
                    Apellido = table.Column<string>(maxLength: 50, nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Domicilio = table.Column<string>(maxLength: 50, nullable: false),
                    Mail = table.Column<string>(nullable: false),
                    EsDeudor = table.Column<bool>(nullable: false),
                    FechaInscripcion = table.Column<string>(nullable: false),
                    MetodoDePago = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socios", x => x.SocioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "Socios");
        }
    }
}
