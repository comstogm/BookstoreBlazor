using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreDatabase.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLineItems_Books_BookId",
                table: "OrderLineItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderLineItems_BookId",
                table: "OrderLineItems");

            migrationBuilder.RenameColumn(
                name: "Orderid",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.AddColumn<string>(
                name: "BookName",
                table: "OrderLineItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookName",
                table: "OrderLineItems");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "Orderid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineItems_BookId",
                table: "OrderLineItems",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLineItems_Books_BookId",
                table: "OrderLineItems",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
