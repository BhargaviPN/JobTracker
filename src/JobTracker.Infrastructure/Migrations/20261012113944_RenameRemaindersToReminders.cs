using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobTracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameRemaindersToReminders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remainders_JobApplications_JobApplicationId",
                table: "Remainders");

            migrationBuilder.DropIndex(
                name: "IX_StatusHistories_JobApplicationId",
                table: "StatusHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Remainders",
                table: "Remainders");

            migrationBuilder.RenameTable(
                name: "Remainders",
                newName: "Reminders");

            migrationBuilder.RenameIndex(
                name: "IX_Remainders_JobApplicationId",
                table: "Reminders",
                newName: "IX_Reminders_JobApplicationId");

            migrationBuilder.AlterColumn<string>(
                name: "InterviewerName",
                table: "Interviews",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Companies",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Reminders",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reminders",
                table: "Reminders",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StatusHistories_JobApplicationId_ChangedAt",
                table: "StatusHistories",
                columns: new[] { "JobApplicationId", "ChangedAt" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_JobApplications_JobApplicationId",
                table: "Reminders",
                column: "JobApplicationId",
                principalTable: "JobApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_JobApplications_JobApplicationId",
                table: "Reminders");

            migrationBuilder.DropIndex(
                name: "IX_StatusHistories_JobApplicationId_ChangedAt",
                table: "StatusHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reminders",
                table: "Reminders");

            migrationBuilder.RenameTable(
                name: "Reminders",
                newName: "Remainders");

            migrationBuilder.RenameIndex(
                name: "IX_Reminders_JobApplicationId",
                table: "Remainders",
                newName: "IX_Remainders_JobApplicationId");

            migrationBuilder.AlterColumn<string>(
                name: "InterviewerName",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Remainders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Remainders",
                table: "Remainders",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StatusHistories_JobApplicationId",
                table: "StatusHistories",
                column: "JobApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remainders_JobApplications_JobApplicationId",
                table: "Remainders",
                column: "JobApplicationId",
                principalTable: "JobApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
