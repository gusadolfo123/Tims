using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tims.WebApp.Data.Migrations
{
    public partial class FullBillingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ConsumptionTax",
                table: "Billing",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "CutoffDate",
                table: "Billing",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateBilledPeriod",
                table: "Billing",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "ExtraCharge",
                table: "Billing",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FullMonth",
                table: "Billing",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FullPriceBill",
                table: "Billing",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MonthlyCharge",
                table: "Billing",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PreviouPayment",
                table: "Billing",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ReceptionTypeId",
                table: "Billing",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateBilledPeriod",
                table: "Billing",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "TaxBase",
                table: "Billing",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimelyPayment",
                table: "Billing",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalChargeMonth",
                table: "Billing",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "ReceptionType",
                columns: table => new
                {
                    ReceptionTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReceptionTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionType", x => x.ReceptionTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Billing_ReceptionTypeId",
                table: "Billing",
                column: "ReceptionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Billing_ReceptionType_ReceptionTypeId",
                table: "Billing",
                column: "ReceptionTypeId",
                principalTable: "ReceptionType",
                principalColumn: "ReceptionTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billing_ReceptionType_ReceptionTypeId",
                table: "Billing");

            migrationBuilder.DropTable(
                name: "ReceptionType");

            migrationBuilder.DropIndex(
                name: "IX_Billing_ReceptionTypeId",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "ConsumptionTax",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "CutoffDate",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "EndDateBilledPeriod",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "ExtraCharge",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "FullMonth",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "FullPriceBill",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "MonthlyCharge",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "PreviouPayment",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "ReceptionTypeId",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "StartDateBilledPeriod",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "TaxBase",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "TimelyPayment",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "TotalChargeMonth",
                table: "Billing");
        }
    }
}
