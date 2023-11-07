using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorsOffice.Migrations
{
    public partial class UpdateTableNamesToDoctorSpecialtiesAndDoctorPatients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatient_Doctors_DoctorId",
                table: "DoctorPatient");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatient_Patients_PatientId",
                table: "DoctorPatient");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorSpecialty_Doctors_DoctorId",
                table: "DoctorSpecialty");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorSpecialty_Specialty_SpecialtyId",
                table: "DoctorSpecialty");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialty_Doctors_DoctorId",
                table: "Specialty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialty",
                table: "Specialty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorSpecialty",
                table: "DoctorSpecialty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorPatient",
                table: "DoctorPatient");

            migrationBuilder.RenameTable(
                name: "Specialty",
                newName: "Specialties");

            migrationBuilder.RenameTable(
                name: "DoctorSpecialty",
                newName: "DoctorSpecialties");

            migrationBuilder.RenameTable(
                name: "DoctorPatient",
                newName: "DoctorPatients");

            migrationBuilder.RenameIndex(
                name: "IX_Specialty_DoctorId",
                table: "Specialties",
                newName: "IX_Specialties_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorSpecialty_SpecialtyId",
                table: "DoctorSpecialties",
                newName: "IX_DoctorSpecialties_SpecialtyId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorSpecialty_DoctorId",
                table: "DoctorSpecialties",
                newName: "IX_DoctorSpecialties_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorPatient_PatientId",
                table: "DoctorPatients",
                newName: "IX_DoctorPatients_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorPatient_DoctorId",
                table: "DoctorPatients",
                newName: "IX_DoctorPatients_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialties",
                table: "Specialties",
                column: "SpecialtyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorSpecialties",
                table: "DoctorSpecialties",
                column: "DoctorSpecialtyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorPatients",
                table: "DoctorPatients",
                column: "DoctorPatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatients_Doctors_DoctorId",
                table: "DoctorPatients",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatients_Patients_PatientId",
                table: "DoctorPatients",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorSpecialties_Doctors_DoctorId",
                table: "DoctorSpecialties",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorSpecialties_Specialties_SpecialtyId",
                table: "DoctorSpecialties",
                column: "SpecialtyId",
                principalTable: "Specialties",
                principalColumn: "SpecialtyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialties_Doctors_DoctorId",
                table: "Specialties",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatients_Doctors_DoctorId",
                table: "DoctorPatients");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatients_Patients_PatientId",
                table: "DoctorPatients");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorSpecialties_Doctors_DoctorId",
                table: "DoctorSpecialties");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorSpecialties_Specialties_SpecialtyId",
                table: "DoctorSpecialties");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialties_Doctors_DoctorId",
                table: "Specialties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialties",
                table: "Specialties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorSpecialties",
                table: "DoctorSpecialties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorPatients",
                table: "DoctorPatients");

            migrationBuilder.RenameTable(
                name: "Specialties",
                newName: "Specialty");

            migrationBuilder.RenameTable(
                name: "DoctorSpecialties",
                newName: "DoctorSpecialty");

            migrationBuilder.RenameTable(
                name: "DoctorPatients",
                newName: "DoctorPatient");

            migrationBuilder.RenameIndex(
                name: "IX_Specialties_DoctorId",
                table: "Specialty",
                newName: "IX_Specialty_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorSpecialties_SpecialtyId",
                table: "DoctorSpecialty",
                newName: "IX_DoctorSpecialty_SpecialtyId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorSpecialties_DoctorId",
                table: "DoctorSpecialty",
                newName: "IX_DoctorSpecialty_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatient",
                newName: "IX_DoctorPatient_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorPatients_DoctorId",
                table: "DoctorPatient",
                newName: "IX_DoctorPatient_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialty",
                table: "Specialty",
                column: "SpecialtyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorSpecialty",
                table: "DoctorSpecialty",
                column: "DoctorSpecialtyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorPatient",
                table: "DoctorPatient",
                column: "DoctorPatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatient_Doctors_DoctorId",
                table: "DoctorPatient",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatient_Patients_PatientId",
                table: "DoctorPatient",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorSpecialty_Doctors_DoctorId",
                table: "DoctorSpecialty",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorSpecialty_Specialty_SpecialtyId",
                table: "DoctorSpecialty",
                column: "SpecialtyId",
                principalTable: "Specialty",
                principalColumn: "SpecialtyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialty_Doctors_DoctorId",
                table: "Specialty",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
