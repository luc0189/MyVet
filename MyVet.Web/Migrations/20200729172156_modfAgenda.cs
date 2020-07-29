using Microsoft.EntityFrameworkCore.Migrations;

namespace MyVet.Web.Migrations
{
    public partial class modfAgenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_serviceTypes_ServiceTypeId",
                table: "Histories");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_petTypes_PetTypeId",
                table: "Pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_serviceTypes",
                table: "serviceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_petTypes",
                table: "petTypes");

            migrationBuilder.RenameTable(
                name: "serviceTypes",
                newName: "ServiceTypes");

            migrationBuilder.RenameTable(
                name: "petTypes",
                newName: "PetTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceTypes",
                table: "ServiceTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PetTypes",
                table: "PetTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_ServiceTypes_ServiceTypeId",
                table: "Histories",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetTypes_PetTypeId",
                table: "Pets",
                column: "PetTypeId",
                principalTable: "PetTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_ServiceTypes_ServiceTypeId",
                table: "Histories");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetTypes_PetTypeId",
                table: "Pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceTypes",
                table: "ServiceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PetTypes",
                table: "PetTypes");

            migrationBuilder.RenameTable(
                name: "ServiceTypes",
                newName: "serviceTypes");

            migrationBuilder.RenameTable(
                name: "PetTypes",
                newName: "petTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_serviceTypes",
                table: "serviceTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_petTypes",
                table: "petTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_serviceTypes_ServiceTypeId",
                table: "Histories",
                column: "ServiceTypeId",
                principalTable: "serviceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_petTypes_PetTypeId",
                table: "Pets",
                column: "PetTypeId",
                principalTable: "petTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
