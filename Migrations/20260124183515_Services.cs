using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelMgm.Migrations
{
    /// <inheritdoc />
    public partial class Services : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CleaningAssignments_Rooms_RoomID",
                table: "CleaningAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_CleaningAssignments_Users_AssignedByUserID",
                table: "CleaningAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_CleaningStaff_Users_AssignedByUserID",
                table: "CleaningStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_CleaningStaff_Users_UserID",
                table: "CleaningStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantReservations_RestaurantTables_RestaurantTableID",
                table: "RestaurantReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantReservations_Users_UserID",
                table: "RestaurantReservations");

            migrationBuilder.DropIndex(
                name: "IX_CleaningStaff_UserID",
                table: "CleaningStaff");

            migrationBuilder.CreateTable(
                name: "HotelServiceCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelServiceCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelServiceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelServiceDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeroImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeroTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeroDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRecepsionists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TotalReservationsHandled = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRecepsionists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceReservastionStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceReservastionStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelServiceReservations",
                columns: table => new
                {
                    ReservationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeSlot = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HotelServiceDetailID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationStatusID = table.Column<int>(type: "int", nullable: true),
                    ServiceRecepsionistId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelServiceReservations", x => x.ReservationID);
                    table.ForeignKey(
                        name: "FK_HotelServiceReservations_HotelServiceDetails_HotelServiceDetailID",
                        column: x => x.HotelServiceDetailID,
                        principalTable: "HotelServiceDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HotelServiceReservations_ReservationStatuses_ReservationStatusID",
                        column: x => x.ReservationStatusID,
                        principalTable: "ReservationStatuses",
                        principalColumn: "ReservationStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HotelServiceReservations_ServiceRecepsionists_ServiceRecepsionistId",
                        column: x => x.ServiceRecepsionistId,
                        principalTable: "ServiceRecepsionists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CleaningStaff_UserID",
                table: "CleaningStaff",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelServiceReservations_HotelServiceDetailID",
                table: "HotelServiceReservations",
                column: "HotelServiceDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_HotelServiceReservations_ReservationStatusID",
                table: "HotelServiceReservations",
                column: "ReservationStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_HotelServiceReservations_ServiceRecepsionistId",
                table: "HotelServiceReservations",
                column: "ServiceRecepsionistId");

            migrationBuilder.AddForeignKey(
                name: "FK_CleaningAssignments_Rooms_RoomID",
                table: "CleaningAssignments",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CleaningAssignments_Users_AssignedByUserID",
                table: "CleaningAssignments",
                column: "AssignedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CleaningStaff_Users_AssignedByUserID",
                table: "CleaningStaff",
                column: "AssignedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CleaningStaff_Users_UserID",
                table: "CleaningStaff",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantReservations_RestaurantTables_RestaurantTableID",
                table: "RestaurantReservations",
                column: "RestaurantTableID",
                principalTable: "RestaurantTables",
                principalColumn: "RestaurantTableID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantReservations_Users_UserID",
                table: "RestaurantReservations",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CleaningAssignments_Rooms_RoomID",
                table: "CleaningAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_CleaningAssignments_Users_AssignedByUserID",
                table: "CleaningAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_CleaningStaff_Users_AssignedByUserID",
                table: "CleaningStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_CleaningStaff_Users_UserID",
                table: "CleaningStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantReservations_RestaurantTables_RestaurantTableID",
                table: "RestaurantReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantReservations_Users_UserID",
                table: "RestaurantReservations");

            migrationBuilder.DropTable(
                name: "HotelServiceCards");

            migrationBuilder.DropTable(
                name: "HotelServiceReservations");

            migrationBuilder.DropTable(
                name: "HotelServices");

            migrationBuilder.DropTable(
                name: "ServiceReservastionStatuses");

            migrationBuilder.DropTable(
                name: "HotelServiceDetails");

            migrationBuilder.DropTable(
                name: "ServiceRecepsionists");

            migrationBuilder.DropIndex(
                name: "IX_CleaningStaff_UserID",
                table: "CleaningStaff");

            migrationBuilder.CreateIndex(
                name: "IX_CleaningStaff_UserID",
                table: "CleaningStaff",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CleaningAssignments_Rooms_RoomID",
                table: "CleaningAssignments",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CleaningAssignments_Users_AssignedByUserID",
                table: "CleaningAssignments",
                column: "AssignedByUserID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CleaningStaff_Users_AssignedByUserID",
                table: "CleaningStaff",
                column: "AssignedByUserID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CleaningStaff_Users_UserID",
                table: "CleaningStaff",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantReservations_RestaurantTables_RestaurantTableID",
                table: "RestaurantReservations",
                column: "RestaurantTableID",
                principalTable: "RestaurantTables",
                principalColumn: "RestaurantTableID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantReservations_Users_UserID",
                table: "RestaurantReservations",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");
        }
    }
}
