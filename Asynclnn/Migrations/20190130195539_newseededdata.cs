using Microsoft.EntityFrameworkCore.Migrations;

namespace Asynclnn.Migrations
{
    public partial class newseededdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Layouts",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AmenitiesID",
                table: "RoomAmenities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomID",
                table: "RoomAmenities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "HotelRooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomID",
                table: "HotelRooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomNumber",
                table: "HotelRooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "petFreindly",
                table: "HotelRooms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Hotel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Hotel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Hotel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Amenities",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "coffeeMachine" },
                    { 2, "Aircondition" },
                    { 3, "Microwave" },
                    { 4, "Stove" },
                    { 5, "washer" }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "Address", "Name", "phone" },
                values: new object[,]
                {
                    { 1, "seattle,wA", "Async seattle", "425-344-6390" },
                    { 2, "1123 newyork st", "Async Newyork", "425-344-6290" },
                    { 3, "278 california st", "Async Boston", "206-344-6390" },
                    { 4, "1234 madison st", "Async Portland", "371-344-6390" },
                    { 5, "Edmonds,wA", "Async Edmonds", "425-344-6790" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Layouts", "Name" },
                values: new object[,]
                {
                    { 1, "layout.onebed", "Kingfu" },
                    { 2, "layout.onebed", "Queenann" },
                    { 3, "layout.studio", "suit" },
                    { 4, "layout.twobed", "double" },
                    { 5, "layout.onebed", "shalom" },
                    { 6, "layout.onebed", "ocean" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Layouts",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "AmenitiesID",
                table: "RoomAmenities");

            migrationBuilder.DropColumn(
                name: "RoomID",
                table: "RoomAmenities");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "HotelRooms");

            migrationBuilder.DropColumn(
                name: "RoomID",
                table: "HotelRooms");

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                table: "HotelRooms");

            migrationBuilder.DropColumn(
                name: "petFreindly",
                table: "HotelRooms");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Amenities");
        }
    }
}
