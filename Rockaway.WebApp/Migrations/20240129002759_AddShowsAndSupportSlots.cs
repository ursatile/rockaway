using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rockaway.WebApp.Migrations {
	/// <inheritdoc />
	public partial class AddShowsAndSupportSlots : Migration {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder) {
			migrationBuilder.CreateTable(
				name: "Show",
				columns: table => new {
					Date = table.Column<DateOnly>(type: "date", nullable: false),
					VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					HeadlineArtistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_Show", x => new { x.VenueId, x.Date });
					table.ForeignKey(
						name: "FK_Show_Artist_HeadlineArtistId",
						column: x => x.HeadlineArtistId,
						principalTable: "Artist",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
					table.ForeignKey(
						name: "FK_Show_Venue_VenueId",
						column: x => x.VenueId,
						principalTable: "Venue",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateTable(
				name: "SupportSlot",
				columns: table => new {
					SlotNumber = table.Column<int>(type: "int", nullable: false),
					ShowVenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					ShowDate = table.Column<DateOnly>(type: "date", nullable: false),
					ArtistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
				},
				constraints: table => {
					table.PrimaryKey("PK_SupportSlot", x => new { x.ShowVenueId, x.ShowDate, x.SlotNumber });
					table.ForeignKey(
						name: "FK_SupportSlot_Artist_ArtistId",
						column: x => x.ArtistId,
						principalTable: "Artist",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_SupportSlot_Show_ShowVenueId_ShowDate",
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
				values: new object[] { "7388f7ec-11d4-49fa-a535-f2d647707253", "AQAAAAIAAYagAAAAEF/JSvdPiW/oYHtyO13On8kL/XoK6XQuSTiILZXOK6omBg8IWmxf/Lcc/op0VSamUQ==", "254ed81a-8482-4139-8e88-7b623e462b90" });

			migrationBuilder.InsertData(
				table: "Show",
				columns: new[] { "Date", "VenueId", "HeadlineArtistId" },
				values: new object[,]
				{
					{ new DateOnly(2024, 5, 19), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3") },
					{ new DateOnly(2024, 5, 18), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3") },
					{ new DateOnly(2024, 5, 25), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb4"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3") },
					{ new DateOnly(2024, 5, 22), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb5"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3") },
					{ new DateOnly(2024, 5, 17), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb7"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3") },
					{ new DateOnly(2024, 5, 23), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb8"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3") },
					{ new DateOnly(2024, 5, 20), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb9"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaa3") }
				});

			migrationBuilder.InsertData(
				table: "SupportSlot",
				columns: new[] { "ShowDate", "ShowVenueId", "SlotNumber", "ArtistId" },
				values: new object[,]
				{
					{ new DateOnly(2024, 5, 19), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"), 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11") },
					{ new DateOnly(2024, 5, 19), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"), 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa15") },
					{ new DateOnly(2024, 5, 19), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"), 3, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") },
					{ new DateOnly(2024, 5, 18), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3"), 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11") },
					{ new DateOnly(2024, 5, 18), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3"), 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa15") },
					{ new DateOnly(2024, 5, 25), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb4"), 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") },
					{ new DateOnly(2024, 5, 25), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb4"), 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa29") },
					{ new DateOnly(2024, 5, 22), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb5"), 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") },
					{ new DateOnly(2024, 5, 17), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb7"), 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11") },
					{ new DateOnly(2024, 5, 17), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb7"), 2, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa15") },
					{ new DateOnly(2024, 5, 23), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb8"), 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") },
					{ new DateOnly(2024, 5, 20), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb9"), 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10") }
				});

			migrationBuilder.CreateIndex(
				name: "IX_Show_HeadlineArtistId",
				table: "Show",
				column: "HeadlineArtistId");

			migrationBuilder.CreateIndex(
				name: "IX_SupportSlot_ArtistId",
				table: "SupportSlot",
				column: "ArtistId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder) {
			migrationBuilder.DropTable(
				name: "SupportSlot");

			migrationBuilder.DropTable(
				name: "Show");

			migrationBuilder.UpdateData(
				table: "AspNetUsers",
				keyColumn: "Id",
				keyValue: "rockaway-sample-admin-user",
				columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
				values: new object[] { "862e5e3c-fbb3-4013-be93-56f68182340a", "AQAAAAIAAYagAAAAEAgop88ioRPdfBZ+ubrZaaLmvfc0hIXlDaPtGMigduTJTkS4btSAWulsvedn2WAWJA==", "ad2f3fe9-bec0-40cd-9b68-af037f8fc2f5" });
		}
	}
}