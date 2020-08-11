using Microsoft.EntityFrameworkCore.Migrations;

namespace AfectcionAmbientalWeb.Data.Migrations
{
    public partial class prueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Celulars_CelularId",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Celulars",
                table: "Celulars");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Celulars");

            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Personas",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CelularId",
                table: "Celulars",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "PersonaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Celulars",
                table: "Celulars",
                column: "CelularId");

            migrationBuilder.CreateTable(
                name: "PersonaCelular",
                columns: table => new
                {
                    PersonaCelularId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaId = table.Column<int>(nullable: false),
                    CelularId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaCelular", x => x.PersonaCelularId);
                    table.ForeignKey(
                        name: "FK_PersonaCelular_Celulars_CelularId",
                        column: x => x.CelularId,
                        principalTable: "Celulars",
                        principalColumn: "CelularId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonaCelular_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonaCelular_CelularId",
                table: "PersonaCelular",
                column: "CelularId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaCelular_PersonaId",
                table: "PersonaCelular",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Celulars_CelularId",
                table: "Personas",
                column: "CelularId",
                principalTable: "Celulars",
                principalColumn: "CelularId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Celulars_CelularId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "PersonaCelular");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Celulars",
                table: "Celulars");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "CelularId",
                table: "Celulars");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Celulars",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Celulars",
                table: "Celulars",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Celulars_CelularId",
                table: "Personas",
                column: "CelularId",
                principalTable: "Celulars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
