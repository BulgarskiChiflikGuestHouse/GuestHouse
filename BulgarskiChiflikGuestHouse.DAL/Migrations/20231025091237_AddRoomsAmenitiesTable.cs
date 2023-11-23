using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GuestHouse.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddRoomsAmenitiesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_Rooms_RoomId",
                table: "Amenities");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageSource_Rooms_RoomId",
                table: "ImageSource");

            migrationBuilder.DropIndex(
                name: "IX_Amenities_RoomId",
                table: "Amenities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageSource",
                table: "ImageSource");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Amenities");

            migrationBuilder.RenameTable(
                name: "ImageSource",
                newName: "ImageSources");

            migrationBuilder.RenameIndex(
                name: "IX_ImageSource_RoomId",
                table: "ImageSources",
                newName: "IX_ImageSources_RoomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageSources",
                table: "ImageSources",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AmenityRoom",
                columns: table => new
                {
                    AmenitiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmenityRoom", x => new { x.AmenitiesId, x.RoomsId });
                    table.ForeignKey(
                        name: "FK_AmenityRoom_Amenities_AmenitiesId",
                        column: x => x.AmenitiesId,
                        principalTable: "Amenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmenityRoom_Rooms_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmenityRoom_RoomsId",
                table: "AmenityRoom",
                column: "RoomsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageSources_Rooms_RoomId",
                table: "ImageSources",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageSources_Rooms_RoomId",
                table: "ImageSources");

            migrationBuilder.DropTable(
                name: "AmenityRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageSources",
                table: "ImageSources");

            migrationBuilder.RenameTable(
                name: "ImageSources",
                newName: "ImageSource");

            migrationBuilder.RenameIndex(
                name: "IX_ImageSources_RoomId",
                table: "ImageSource",
                newName: "IX_ImageSource_RoomId");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "Amenities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageSource",
                table: "ImageSource",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_RoomId",
                table: "Amenities",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_Rooms_RoomId",
                table: "Amenities",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageSource_Rooms_RoomId",
                table: "ImageSource",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
