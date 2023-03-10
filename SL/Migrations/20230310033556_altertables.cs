using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Migrations
{
    public partial class altertables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "permiso",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    permiso = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permiso", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "permiso_permiso",
                columns: table => new
                {
                    id_permiso_permiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_permiso_padre = table.Column<int>(type: "int", nullable: true),
                    id_permiso_hijo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permiso_permiso", x => x.id_permiso_permiso);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    pw = table.Column<string>(type: "nvarchar(90)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    dni = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    idioma = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id_usuario);
                });

            migrationBuilder.CreateTable(
                name: "usuarios_permisos",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    id_permiso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios_permisos", x => new { x.id_permiso, x.id_usuario });
                    table.ForeignKey(
                        name: "FK_usuarios_permisos_permiso_id_permiso",
                        column: x => x.id_permiso,
                        principalTable: "permiso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuarios_permisos_usuarios_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_permisos_id_usuario",
                table: "usuarios_permisos",
                column: "id_usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "permiso_permiso");

            migrationBuilder.DropTable(
                name: "usuarios_permisos");

            migrationBuilder.DropTable(
                name: "permiso");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
