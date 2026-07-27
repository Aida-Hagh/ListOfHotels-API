using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ListOfHotels_Data.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationEntityAndSeedDataForCitiesAndHotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Hotels",
                newName: "Country");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Hotels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Hotels",
                type: "float",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "Tabriz", "TBZ" },
                    { 2, "Shiraz", "SHZ" },
                    { 3, "Esfahan", "EFN" },
                    { 4, "Kish", "KSH" },
                    { 5, "Hamedan", "HMN" },
                    { 6, "Mashhad", "MSH" },
                    { 7, "Gilan", "GLN" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "CityId", "Name", "Stars", "Address", "City", "Country", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 1, 1, "هتل اهراب", 3, "خیابان اهراب", "تبریز", "ایران", null, null },
                    { 2, 1, "Shahriyar", 5, "خیابان شهریار", "تبریز", "ایران", null, null },
                    { 3, 1, "Pars", 4, "خیابان شاه گلی", "تبریز", "ایران", null, null },
                    { 4, 4, "Negin", 3, "خیابان نگین کیش", "کیش", "ایران", null, null },
                    { 5, 2, "Golha", 4, "خیابان گلهای شیرازی", "شیراز", "ایران", null, null },
                    { 6, 6, "Yas", 3, "خیابان یاسمن", "مشهد", "ایران", null, null },
                    { 7, 4, "Azadi", 4, "خیابان آزادی", "کیش", "ایران", null, null },
                    { 8, 7, "Gisu", 4, "خیابان گیلکان", "گیلان", "ایران", null, null },
                    { 9, 3, "PolDokhtar", 5, "خیابان پل دختر", "اصفهان", "ایران", null, null },
                    { 10, 2, "Hafez", 5, "خیابان حافظ شیرازی", "شیراز", "ایران", null, null },
                    { 11, 5, "Hegmatane", 5, "خیابان هگمتانه", "همدان", "ایران", null, null },
                    { 12, 3, "ChehelSotun", 5, "خیابان چهل ستون", "اصفهان", "ایران", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Hotels");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Hotels",
                newName: "Location");
        }
    }
}
