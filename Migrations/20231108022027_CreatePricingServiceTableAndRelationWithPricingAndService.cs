using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentorTemplate.Migrations
{
    public partial class CreatePricingServiceTableAndRelationWithPricingAndService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PricingServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricingId = table.Column<int>(type: "int", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PricingServices_Pricings_PricingId",
                        column: x => x.PricingId,
                        principalTable: "Pricings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PricingServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PricingServices_PricingId",
                table: "PricingServices",
                column: "PricingId");

            migrationBuilder.CreateIndex(
                name: "IX_PricingServices_ServiceId",
                table: "PricingServices",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PricingServices");
        }
    }
}
