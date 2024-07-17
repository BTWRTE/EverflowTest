using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EverflowTest.Migrations
{
    /// <inheritdoc />
    public partial class SetDemoData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var userId = Guid.NewGuid().ToString();
            var location1Id = Guid.NewGuid().ToString();
            var location2Id = Guid.NewGuid().ToString();
            var location3Id = Guid.NewGuid().ToString();
            var location4Id = Guid.NewGuid().ToString();

            migrationBuilder
                .InsertData("AspNetUsers",
                    ["Id", "FirstName", "LastName", "UserName", "Email", "EmailConfirmed", "PhoneNumber", "PhoneNumberConfirmed", "AccessFailedCount", "TwoFactorEnabled", "LockoutEnabled"],
                    new object[,]
                    {
                        { userId, "Jamie", "Hodgson", "hodgsonjamie@hotmail.com", "hodgsonjamie@hotmail.com", true, "07401075820", true, 0, false, false }
                    });

            migrationBuilder
                .InsertData("Location",
                    ["Id", "StreetLine1", "StreetLine2", "City", "County", "PostCode", "CreatedDate", "CreatedBy", "IsDeleted"],
                    new object[,]
                    {
                        { location1Id, "16 Chantry Mews", "Bridge Street", "Morpeth", "Northumberland", "NE61 1PT", currentDateTime, userId, false },
                        { location2Id, "17 Chantry Mews", "Bridge Street", "Morpeth", "Northumberland", "NE62 2PT", currentDateTime, userId, false },
                        { location3Id, "18 Chantry Mews", "Bridge Street", "Morpeth", "Northumberland", "NE63 3PT", currentDateTime, userId, false },
                        { location4Id, "19 Chantry Mews", "Bridge Street", "Morpeth", "Northumberland", "NE64 4PT", currentDateTime, userId, false }
                    });

            migrationBuilder
                .InsertData("Event",
                    ["Id", "Name", "Description", "StartDate", "EndDate", "LocationId", "CreatedDate", "CreatedBy", "IsDeleted"],
                    new object[,]
                    {
                        { Guid.NewGuid().ToString(), "Chantry Mews Street Party", "Free food", "2024-07-16 12:00:00", "2024-07-16 16:00:00", location1Id, currentDateTime, userId, false },
                        { Guid.NewGuid().ToString(), "Chantry Mews After Party", "Free booze", "2024-07-16 19:30:00", "2024-07-17 12:00:00", location2Id, currentDateTime, userId, false },
                        { Guid.NewGuid().ToString(), "Board Game Night", "All tabletop/board games welcome (Please not Monopoly again, I'll go mad)", "2024-07-19 18:00:00", "2024-07-19 21:45:00", location3Id, currentDateTime, userId, false },
                        { Guid.NewGuid().ToString(), "Homer's BBBQ", "The extra 'B' is for BYOBB", "2024-07-20 13:30:00", "2024-07-21 02:00:00", location4Id, currentDateTime, userId, false }
                    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}