using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectCardPark.Migrations
{
    /// <inheritdoc />
    public partial class AddDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RatingId1",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ratingID",
                table: "Rating",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CardsId",
                table: "Listing",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Listing",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Listing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ListingID",
                table: "Listing",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Listing",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Delivery",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_RatingId1",
                table: "User",
                column: "RatingId1");

            migrationBuilder.CreateIndex(
                name: "IX_Listing_CardsId",
                table: "Listing",
                column: "CardsId");

            migrationBuilder.CreateIndex(
                name: "IX_Listing_CategoryId1",
                table: "Listing",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Listing_UserId1",
                table: "Listing",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_UserId1",
                table: "Delivery",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_User_UserId1",
                table: "Delivery",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Listing_Cards_CardsId",
                table: "Listing",
                column: "CardsId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Listing_Category_CategoryId1",
                table: "Listing",
                column: "CategoryId1",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Listing_User_UserId1",
                table: "Listing",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Rating_RatingId1",
                table: "User",
                column: "RatingId1",
                principalTable: "Rating",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_User_UserId1",
                table: "Delivery");

            migrationBuilder.DropForeignKey(
                name: "FK_Listing_Cards_CardsId",
                table: "Listing");

            migrationBuilder.DropForeignKey(
                name: "FK_Listing_Category_CategoryId1",
                table: "Listing");

            migrationBuilder.DropForeignKey(
                name: "FK_Listing_User_UserId1",
                table: "Listing");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Rating_RatingId1",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RatingId1",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Listing_CardsId",
                table: "Listing");

            migrationBuilder.DropIndex(
                name: "IX_Listing_CategoryId1",
                table: "Listing");

            migrationBuilder.DropIndex(
                name: "IX_Listing_UserId1",
                table: "Listing");

            migrationBuilder.DropIndex(
                name: "IX_Delivery_UserId1",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "RatingId1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ratingID",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "CardsId",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "ListingID",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Delivery");
        }
    }
}
