using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGestionCitasMedicas.Migrations
{
    /// <inheritdoc />
    public partial class UnificarFechaHora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Hora",
                table: "Citas",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Citas",
                newName: "FechaHora");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_MedicoId",
                table: "Citas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_PacienteId",
                table: "Citas",
                column: "PacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Medicos_MedicoId",
                table: "Citas",
                column: "MedicoId",
                principalTable: "Medicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Pacientes_PacienteId",
                table: "Citas",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Medicos_MedicoId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Pacientes_PacienteId",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_MedicoId",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_PacienteId",
                table: "Citas");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Citas",
                newName: "Hora");

            migrationBuilder.RenameColumn(
                name: "FechaHora",
                table: "Citas",
                newName: "Fecha");
        }
    }
}
