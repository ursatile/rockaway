using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rockaway.WebApp.Migrations {
	/// <inheritdoc />
	public partial class AddTicketTypes : Migration {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder) {
			migrationBuilder.CreateTable(
				name: "TicketType",
				columns: table => new {
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					ShowVenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					ShowDate = table.Column<DateOnly>(type: "date", nullable: false),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Price = table.Column<decimal>(type: "money", nullable: false),
					Limit = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table => {
					table.PrimaryKey("PK_TicketType", x => x.Id);
					table.ForeignKey(
						name: "FK_TicketType_Show_ShowVenueId_ShowDate",
						columns: x => new { x.ShowVenueId, x.ShowDate },
						principalTable: "Show",
						principalColumns: new[] { "VenueId", "Date" },
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.UpdateData(
				table: "AspNetUsers",
				keyColumn: "Id",
				keyValue: "rockaway-sample-admin-user",
				columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
				values: new object[] { "bdd45fae-ac8e-48ac-985d-0da5f3a69cc4", "AQAAAAIAAYagAAAAEM805Lx3soBdCQPpabTDUyEafFyAKwvvR8kncBLtxUuRM648xjjqJFZIwd1Vg5XScQ==", "b3f05678-d851-463e-af4f-e40e984dd698" });

			migrationBuilder.InsertData(
				table: "TicketType",
				columns: new[] { "Id", "Limit", "Name", "Price", "ShowDate", "ShowVenueId" },
				values: new object[,]
				{
					{ new Guid("cccccccc-cccc-cccc-cccc-cccccccccc10"), null, "General Admission", 350m, new DateOnly(2024, 5, 22), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb5") },
					{ new Guid("cccccccc-cccc-cccc-cccc-cccccccccc11"), null, "VIP Meet & Greet", 750m, new DateOnly(2024, 5, 22), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb5") },
					{ new Guid("cccccccc-cccc-cccc-cccc-cccccccccc12"), null, "General Admission", 300m, new DateOnly(2024, 5, 23), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb8") },
					{ new Guid("cccccccc-cccc-cccc-cccc-cccccccccc13"), null, "VIP Meet & Greet", 720m, new DateOnly(2024, 5, 23), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb8") },
					{ new Guid("cccccccc-cccc-cccc-cccc-cccccccccc14"), null, "General Admission", 25m, new DateOnly(2024, 5, 25), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb4") },
					{ new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc1"), null, "Upstairs unallocated seating", 25m, new DateOnly(2024, 5, 17), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb7") },
					{ new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc2"), null, "Downstairs standing", 25m, new DateOnly(2024, 5, 17), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb7") },
					{ new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc3"), null, "Cabaret table (4 people)", 120m, new DateOnly(2024, 5, 17), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb7") },
					{ new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc4"), null, "General Admission", 35m, new DateOnly(2024, 5, 18), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3") },
					{ new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc5"), null, "VIP Meet & Greet", 75m, new DateOnly(2024, 5, 18), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3") },
					{ new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc6"), null, "General Admission", 35m, new DateOnly(2024, 5, 19), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2") },
					{ new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc7"), null, "VIP Meet & Greet", 75m, new DateOnly(2024, 5, 19), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2") },
					{ new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc8"), null, "General Admission", 25m, new DateOnly(2024, 5, 20), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb9") },
					{ new Guid("cccccccc-cccc-cccc-cccc-ccccccccccc9"), null, "VIP Meet & Greet", 55m, new DateOnly(2024, 5, 20), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb9") }
				});

			migrationBuilder.CreateIndex(
				name: "IX_TicketType_ShowVenueId_ShowDate",
				table: "TicketType",
				columns: new[] { "ShowVenueId", "ShowDate" });
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder) {
			migrationBuilder.DropTable(
				name: "TicketType");

			migrationBuilder.UpdateData(
				table: "AspNetUsers",
				keyColumn: "Id",
				keyValue: "rockaway-sample-admin-user",
				columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
				values: new object[] { "ad5c9299-4361-4d76-9805-b2bb776db016", "AQAAAAIAAYagAAAAEJaiv+puLKDTDl/ZllBssQb2jHgj8E0k2W7y/JoIDfUHrj/0GMGF1vzm+duY3zgjKA==", "f3dc7659-23cb-4335-a7ac-9132b27ecd3f" });
		}
	}
}