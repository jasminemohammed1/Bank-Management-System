using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNET14_EF03_EF04.Migrations
{
    /// <inheritdoc />
    public partial class relationshipbetweenbranchaccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_BranchId",
                table: "Accounts",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Branches_BranchId",
                table: "Accounts",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Branches_BranchId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_BranchId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Accounts");
        }
    }
}
