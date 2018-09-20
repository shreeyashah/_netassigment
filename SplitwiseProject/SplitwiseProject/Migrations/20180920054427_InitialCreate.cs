using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SplitwiseProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatagoryOptions",
                columns: table => new
                {
                    CatagoryOptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CatagoryOptionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatagoryOptions", x => x.CatagoryOptionId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentModes",
                columns: table => new
                {
                    PaymentModeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PayMode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentModes", x => x.PaymentModeId);
                });

            migrationBuilder.CreateTable(
                name: "Reminders",
                columns: table => new
                {
                    ReminderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReminderName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminders", x => x.ReminderId);
                });

            migrationBuilder.CreateTable(
                name: "Repeats",
                columns: table => new
                {
                    RepeatsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RepeatsName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repeats", x => x.RepeatsId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "BillCatagories",
                columns: table => new
                {
                    BillCatagoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BillCatagoryName = table.Column<string>(nullable: true),
                    CatagoryOptionName = table.Column<string>(nullable: true),
                    CatagoryOptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillCatagories", x => x.BillCatagoryId);
                    table.ForeignKey(
                        name: "FK_BillCatagories_CatagoryOptions_CatagoryOptionId",
                        column: x => x.CatagoryOptionId,
                        principalTable: "CatagoryOptions",
                        principalColumn: "CatagoryOptionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false),
                    ActivityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activities_User_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SattleUps",
                columns: table => new
                {
                    SattleUpId = table.Column<int>(nullable: false),
                    SattleAmount = table.Column<int>(nullable: false),
                    PaymentModeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SattleUps", x => x.SattleUpId);
                    table.ForeignKey(
                        name: "FK_SattleUps_PaymentModes_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalTable: "PaymentModes",
                        principalColumn: "PaymentModeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SattleUps_User_SattleUpId",
                        column: x => x.SattleUpId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shareds",
                columns: table => new
                {
                    SharedId = table.Column<int>(nullable: false),
                    SharedAmmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shareds", x => x.SharedId);
                    table.ForeignKey(
                        name: "FK_Shareds_User_SharedId",
                        column: x => x.SharedId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true),
                    SharedId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Groups_Shareds_SharedId",
                        column: x => x.SharedId,
                        principalTable: "Shareds",
                        principalColumn: "SharedId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<int>(nullable: false),
                    BillName = table.Column<string>(nullable: true),
                    BillAmount = table.Column<int>(nullable: false),
                    BillDate = table.Column<DateTime>(nullable: false),
                    BillImage = table.Column<string>(nullable: true),
                    BillNote = table.Column<string>(nullable: true),
                    BillCatagoryName = table.Column<string>(nullable: true),
                    ReminderNmae = table.Column<string>(nullable: true),
                    RepeatsName = table.Column<string>(nullable: true),
                    BillCatagoryId = table.Column<int>(nullable: true),
                    ReminderId = table.Column<int>(nullable: true),
                    RepeatsId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_Bills_BillCatagories_BillCatagoryId",
                        column: x => x.BillCatagoryId,
                        principalTable: "BillCatagories",
                        principalColumn: "BillCatagoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_Groups_BillId",
                        column: x => x.BillId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Reminders_ReminderId",
                        column: x => x.ReminderId,
                        principalTable: "Reminders",
                        principalColumn: "ReminderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_Repeats_RepeatsId",
                        column: x => x.RepeatsId,
                        principalTable: "Repeats",
                        principalColumn: "RepeatsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    FriendsId = table.Column<int>(nullable: false),
                    FriendName = table.Column<string>(nullable: true),
                    FriendEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.FriendsId);
                    table.ForeignKey(
                        name: "FK_Friends_Groups_FriendsId",
                        column: x => x.FriendsId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Balances",
                columns: table => new
                {
                    BalanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BalanceAmount = table.Column<int>(nullable: false),
                    FriendsId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balances", x => x.BalanceId);
                    table.ForeignKey(
                        name: "FK_Balances_Friends_FriendsId",
                        column: x => x.FriendsId,
                        principalTable: "Friends",
                        principalColumn: "FriendsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Balances_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Owes",
                columns: table => new
                {
                    OwesId = table.Column<int>(nullable: false),
                    OwesAmmount = table.Column<int>(nullable: false),
                    FriendsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owes", x => x.OwesId);
                    table.ForeignKey(
                        name: "FK_Owes_Friends_FriendsId",
                        column: x => x.FriendsId,
                        principalTable: "Friends",
                        principalColumn: "FriendsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Owes_Bills_OwesId",
                        column: x => x.OwesId,
                        principalTable: "Bills",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Owes_User_OwesId",
                        column: x => x.OwesId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(nullable: false),
                    Paymentmade = table.Column<int>(nullable: false),
                    PaymentReceive = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Friends_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Friends",
                        principalColumn: "FriendsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_User_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Balances_FriendsId",
                table: "Balances",
                column: "FriendsId");

            migrationBuilder.CreateIndex(
                name: "IX_Balances_UserId",
                table: "Balances",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BillCatagories_CatagoryOptionId",
                table: "BillCatagories",
                column: "CatagoryOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_BillCatagoryId",
                table: "Bills",
                column: "BillCatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_ReminderId",
                table: "Bills",
                column: "ReminderId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_RepeatsId",
                table: "Bills",
                column: "RepeatsId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserId",
                table: "Bills",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_SharedId",
                table: "Groups",
                column: "SharedId");

            migrationBuilder.CreateIndex(
                name: "IX_Owes_FriendsId",
                table: "Owes",
                column: "FriendsId");

            migrationBuilder.CreateIndex(
                name: "IX_SattleUps_PaymentModeId",
                table: "SattleUps",
                column: "PaymentModeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Balances");

            migrationBuilder.DropTable(
                name: "Owes");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "SattleUps");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "PaymentModes");

            migrationBuilder.DropTable(
                name: "BillCatagories");

            migrationBuilder.DropTable(
                name: "Reminders");

            migrationBuilder.DropTable(
                name: "Repeats");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "CatagoryOptions");

            migrationBuilder.DropTable(
                name: "Shareds");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
