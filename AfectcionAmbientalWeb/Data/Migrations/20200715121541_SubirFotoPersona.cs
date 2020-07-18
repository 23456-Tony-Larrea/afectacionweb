using AfectcionAmbientalWeb.Controllers;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace AfectcionAmbientalWeb.Data.Migrations
{
    public partial class SubirFotoPersona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(name:"FotografiaPerfil",
                table:"Personas",
                nullable:true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name:"FotografiaPerfil", 
                table:"Personas");
        }
    }
}
