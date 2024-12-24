using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Products.API.Migrations
{
    /// <inheritdoc />
    public partial class renameCertificationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CertificationProduct_Certifications_CertificationsId",
                table: "CertificationProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certifications",
                table: "Certifications");

            migrationBuilder.RenameTable(
                name: "Certifications",
                newName: "Certification");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certification",
                table: "Certification",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CertificationProduct_Certification_CertificationsId",
                table: "CertificationProduct",
                column: "CertificationsId",
                principalTable: "Certification",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CertificationProduct_Certification_CertificationsId",
                table: "CertificationProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certification",
                table: "Certification");

            migrationBuilder.RenameTable(
                name: "Certification",
                newName: "Certifications");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certifications",
                table: "Certifications",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CertificationProduct_Certifications_CertificationsId",
                table: "CertificationProduct",
                column: "CertificationsId",
                principalTable: "Certifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
