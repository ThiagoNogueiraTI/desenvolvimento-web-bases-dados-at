using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace at.Migrations
{
    /// <inheritdoc />
    public partial class AddIsDeletedToCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destino_PacotesTuristicos_PacoteTuristicoId",
                table: "Destino");

            migrationBuilder.DropIndex(
                name: "IX_Destino_PacoteTuristicoId",
                table: "Destino");

            migrationBuilder.DropColumn(
                name: "PacoteTuristicoId",
                table: "Destino");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "DestinoPacoteTuristico",
                columns: table => new
                {
                    DestinosId = table.Column<int>(type: "INTEGER", nullable: false),
                    PacotesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinoPacoteTuristico", x => new { x.DestinosId, x.PacotesId });
                    table.ForeignKey(
                        name: "FK_DestinoPacoteTuristico_Destino_DestinosId",
                        column: x => x.DestinosId,
                        principalTable: "Destino",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DestinoPacoteTuristico_PacotesTuristicos_PacotesId",
                        column: x => x.PacotesId,
                        principalTable: "PacotesTuristicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DestinoPacoteTuristico_PacotesId",
                table: "DestinoPacoteTuristico",
                column: "PacotesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DestinoPacoteTuristico");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "PacoteTuristicoId",
                table: "Destino",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destino_PacoteTuristicoId",
                table: "Destino",
                column: "PacoteTuristicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destino_PacotesTuristicos_PacoteTuristicoId",
                table: "Destino",
                column: "PacoteTuristicoId",
                principalTable: "PacotesTuristicos",
                principalColumn: "Id");
        }
    }
}
