using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rockaway.WebApp.Migrations {
	/// <inheritdoc />
	public partial class ReplaceCountryCodeWithCultureName : Migration {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder) {
			migrationBuilder.DropColumn(
				name: "CountryCode",
				table: "Venue");

			migrationBuilder.AddColumn<string>(
				name: "CultureName",
				table: "Venue",
				type: "varchar(16)",
				unicode: false,
				maxLength: 16,
				nullable: false,
				defaultValue: "");

			migrationBuilder.UpdateData(
				table: "AspNetUsers",
				keyColumn: "Id",
				keyValue: "rockaway-sample-admin-user",
				columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
				values: new object[] { "ad5c9299-4361-4d76-9805-b2bb776db016", "AQAAAAIAAYagAAAAEJaiv+puLKDTDl/ZllBssQb2jHgj8E0k2W7y/JoIDfUHrj/0GMGF1vzm+duY3zgjKA==", "f3dc7659-23cb-4335-a7ac-9132b27ecd3f" });

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"),
				column: "CultureName",
				value: "en-GB");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"),
				column: "CultureName",
				value: "fr-FR");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3"),
				column: "CultureName",
				value: "de-DE");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb4"),
				column: "CultureName",
				value: "el-GR");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb5"),
				column: "CultureName",
				value: "nn-NO");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb6"),
				column: "CultureName",
				value: "da-DK");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb7"),
				column: "CultureName",
				value: "pt-PT");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb8"),
				column: "CultureName",
				value: "sv-SE");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb9"),
				column: "CultureName",
				value: "en-GB");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder) {
			migrationBuilder.DropColumn(
				name: "CultureName",
				table: "Venue");

			migrationBuilder.AddColumn<string>(
				name: "CountryCode",
				table: "Venue",
				type: "varchar(2)",
				unicode: false,
				maxLength: 2,
				nullable: false,
				defaultValue: "");

			migrationBuilder.UpdateData(
				table: "AspNetUsers",
				keyColumn: "Id",
				keyValue: "rockaway-sample-admin-user",
				columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
				values: new object[] { "7388f7ec-11d4-49fa-a535-f2d647707253", "AQAAAAIAAYagAAAAEF/JSvdPiW/oYHtyO13On8kL/XoK6XQuSTiILZXOK6omBg8IWmxf/Lcc/op0VSamUQ==", "254ed81a-8482-4139-8e88-7b623e462b90" });

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"),
				column: "CountryCode",
				value: "GB");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"),
				column: "CountryCode",
				value: "FR");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb3"),
				column: "CountryCode",
				value: "DE");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb4"),
				column: "CountryCode",
				value: "GR");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb5"),
				column: "CountryCode",
				value: "NO");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb6"),
				column: "CountryCode",
				value: "DK");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb7"),
				column: "CountryCode",
				value: "PT");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb8"),
				column: "CountryCode",
				value: "SE");

			migrationBuilder.UpdateData(
				table: "Venue",
				keyColumn: "Id",
				keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb9"),
				column: "CountryCode",
				value: "GB");
		}
	}
}