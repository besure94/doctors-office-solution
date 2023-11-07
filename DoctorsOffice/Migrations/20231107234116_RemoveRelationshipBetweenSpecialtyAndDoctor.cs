using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorsOffice.Migrations
{
    public partial class RemoveRelationshipBetweenSpecialtyAndDoctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_Doctors_DoctorId",
                table: "Specialties");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Specialties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_Doctors_DoctorId",
                table: "Specialties",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_Doctors_DoctorId",
                table: "Specialties");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Specialties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_Doctors_DoctorId",
                table: "Specialties",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
