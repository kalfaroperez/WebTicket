using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.DatabaseContext.Migrations
{
    public partial class SigoTicketMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Piso",
                table: "Ticket",
                newName: "Ubicacion");

            migrationBuilder.AlterColumn<int>(
                name: "Tipo_Trabajo",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Proceso",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Prioridad",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<int>(
                name: "Id_Planta",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_EquipoSec",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_EquipoPrinc",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_Componente",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Entrega",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Estado",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Area_Id",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comentarios",
                table: "Ticket",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SeqTicketId",
                table: "SigoTicket",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AddColumn<int>(
                name: "CambioNumero",
                table: "SigoTicket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NotasTrabajo",
                table: "SigoTicket",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Area",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentarios",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "CambioNumero",
                table: "SigoTicket");

            migrationBuilder.DropColumn(
                name: "NotasTrabajo",
                table: "SigoTicket");

            migrationBuilder.RenameColumn(
                name: "Ubicacion",
                table: "Ticket",
                newName: "Piso");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo_Trabajo",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Proceso",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<byte>(
                name: "Prioridad",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Id_Planta",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Id_EquipoSec",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Id_EquipoPrinc",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Id_Componente",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha_Entrega",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Area_Id",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<uint>(
                name: "SeqTicketId",
                table: "SigoTicket",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
