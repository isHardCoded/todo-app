using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoApp.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationTaskUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorUserId",
                table: "Task",
                type: "integer",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Task_AuthorUserId",
                table: "Task",
                column: "AuthorUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_User_AuthorUserId",
                table: "Task",
                column: "AuthorUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_User_AuthorUserId",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_AuthorUserId",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "AuthorUserId",
                table: "Task");
        }
    }
}
