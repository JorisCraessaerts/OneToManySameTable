using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkTestProject.Migrations
{
    public partial class seeddatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_StudentId1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentId1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Students",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Name", "ParentId" },
                values: new object[] { 1, "Joris", null });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_ParentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ParentId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentId1",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentId1",
                table: "Students",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_StudentId1",
                table: "Students",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
