using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructura.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dirección = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    MailContacto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Teléfono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id_Producto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripción = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrecioUnidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id_Producto);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id_Pedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false),
                    Descripción = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dirección = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TelefonoContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Retiro = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id_Pedido);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallePedido",
                columns: table => new
                {
                    Id_Detalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Pedido = table.Column<int>(type: "int", nullable: false),
                    Id_Producto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedido", x => x.Id_Detalle);
                    table.ForeignKey(
                        name: "FK_DetallePedido_Pedido_Id_Pedido",
                        column: x => x.Id_Pedido,
                        principalTable: "Pedido",
                        principalColumn: "Id_Pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallePedido_Producto_Id_Producto",
                        column: x => x.Id_Producto,
                        principalTable: "Producto",
                        principalColumn: "Id_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    Id_Factura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IVA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BaseImponible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Pedido = table.Column<int>(type: "int", nullable: false),
                    IVADiscriminado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaYHora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.Id_Factura);
                    table.ForeignKey(
                        name: "FK_Factura_Pedido_Id_Pedido",
                        column: x => x.Id_Pedido,
                        principalTable: "Pedido",
                        principalColumn: "Id_Pedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_Id_Pedido",
                table: "DetallePedido",
                column: "Id_Pedido");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_Id_Producto",
                table: "DetallePedido",
                column: "Id_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_Id_Pedido",
                table: "Factura",
                column: "Id_Pedido");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_Id_Cliente",
                table: "Pedido",
                column: "Id_Cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallePedido");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
