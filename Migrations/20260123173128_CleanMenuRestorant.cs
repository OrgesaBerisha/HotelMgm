using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelMgm.Migrations
{
    /// <inheritdoc />
    public partial class CleanMenuRestorant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CleaningStaff",
                columns: table => new
                {
                    CleaningStaffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Shift = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedByUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningStaff", x => x.CleaningStaffID);
                    table.ForeignKey(
                        name: "FK_CleaningStaff_Users_AssignedByUserID",
                        column: x => x.AssignedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CleaningStaff_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    MenuCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.MenuCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantGuests",
                columns: table => new
                {
                    GuestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantGuests", x => x.GuestID);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WelcomeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WelcomeMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WelcomeImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImageUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImageUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantTables",
                columns: table => new
                {
                    RestaurantTableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableNumber = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantTables", x => x.RestaurantTableID);
                });

            migrationBuilder.CreateTable(
                name: "CleaningAssignments",
                columns: table => new
                {
                    CleaningAssignmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    CleaningStaffID = table.Column<int>(type: "int", nullable: false),
                    AssignedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedByUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningAssignments", x => x.CleaningAssignmentID);
                    table.ForeignKey(
                        name: "FK_CleaningAssignments_CleaningStaff_CleaningStaffID",
                        column: x => x.CleaningStaffID,
                        principalTable: "CleaningStaff",
                        principalColumn: "CleaningStaffID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CleaningAssignments_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CleaningAssignments_Users_AssignedByUserID",
                        column: x => x.AssignedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    MenuItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    image_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_available = table.Column<bool>(type: "bit", nullable: false),
                    MenuCategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.MenuItemID);
                    table.ForeignKey(
                        name: "FK_MenuItems_MenuCategories_MenuCategoryID",
                        column: x => x.MenuCategoryID,
                        principalTable: "MenuCategories",
                        principalColumn: "MenuCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantReservations",
                columns: table => new
                {
                    ReservationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    date_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantTableID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantReservations", x => x.ReservationID);
                    table.ForeignKey(
                        name: "FK_RestaurantReservations_RestaurantGuests_GuestID",
                        column: x => x.GuestID,
                        principalTable: "RestaurantGuests",
                        principalColumn: "GuestID");
                    table.ForeignKey(
                        name: "FK_RestaurantReservations_RestaurantTables_RestaurantTableID",
                        column: x => x.RestaurantTableID,
                        principalTable: "RestaurantTables",
                        principalColumn: "RestaurantTableID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantReservations_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CleaningAssignments_AssignedByUserID",
                table: "CleaningAssignments",
                column: "AssignedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CleaningAssignments_CleaningStaffID",
                table: "CleaningAssignments",
                column: "CleaningStaffID");

            migrationBuilder.CreateIndex(
                name: "IX_CleaningAssignments_RoomID",
                table: "CleaningAssignments",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_CleaningStaff_AssignedByUserID",
                table: "CleaningStaff",
                column: "AssignedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CleaningStaff_UserID",
                table: "CleaningStaff",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MenuCategoryID",
                table: "MenuItems",
                column: "MenuCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantReservations_GuestID",
                table: "RestaurantReservations",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantReservations_RestaurantTableID",
                table: "RestaurantReservations",
                column: "RestaurantTableID");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantReservations_UserID",
                table: "RestaurantReservations",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CleaningAssignments");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "RestaurantReservations");

            migrationBuilder.DropTable(
                name: "RestaurantSettings");

            migrationBuilder.DropTable(
                name: "CleaningStaff");

            migrationBuilder.DropTable(
                name: "MenuCategories");

            migrationBuilder.DropTable(
                name: "RestaurantGuests");

            migrationBuilder.DropTable(
                name: "RestaurantTables");
        }
    }
}
