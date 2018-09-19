using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Splitwise.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillCatagories",
                columns: table => new
                {
                    BillCatagoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BillCatagoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillCatagories", x => x.BillCatagoryId);
                });

            migrationBuilder.CreateTable(
                name: "catagoryOptions",
                columns: table => new
                {
                    CatagoryOptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CatagoryOptionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catagoryOptions", x => x.CatagoryOptionId);
                });

            migrationBuilder.CreateTable(
                name: "friends",
                columns: table => new
                {
                    FriendsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FriendName = table.Column<string>(nullable: true),
                    FriendEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_friends", x => x.FriendsId);
                });

            migrationBuilder.CreateTable(
                name: "paymentModes",
                columns: table => new
                {
                    PaymentModeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PayMode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentModes", x => x.PaymentModeId);
                });

            migrationBuilder.CreateTable(
                name: "reminders",
                columns: table => new
                {
                    ReminderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReminderName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reminders", x => x.ReminderId);
                });

            migrationBuilder.CreateTable(
                name: "repeats",
                columns: table => new
                {
                    RepeatsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RepeatsName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repeats", x => x.RepeatsId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "owes",
                columns: table => new
                {
                    OwesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OwesAmmount = table.Column<int>(nullable: false),
                    FriendsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owes", x => x.OwesId);
                    table.ForeignKey(
                        name: "FK_owes_friends_FriendsId",
                        column: x => x.FriendsId,
                        principalTable: "friends",
                        principalColumn: "FriendsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityName = table.Column<string>(nullable: true),
                    FriendsId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activities", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_activities_friends_FriendsId",
                        column: x => x.FriendsId,
                        principalTable: "friends",
                        principalColumn: "FriendsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_activities_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "balances",
                columns: table => new
                {
                    BalanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BalanceAmount = table.Column<int>(nullable: false),
                    FriendsId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_balances", x => x.BalanceId);
                    table.ForeignKey(
                        name: "FK_balances_friends_FriendsId",
                        column: x => x.FriendsId,
                        principalTable: "friends",
                        principalColumn: "FriendsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_balances_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bills",
                columns: table => new
                {
                    BillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BillName = table.Column<string>(nullable: true),
                    BillAmount = table.Column<int>(nullable: false),
                    BillDate = table.Column<DateTime>(nullable: false),
                    BillImage = table.Column<string>(nullable: true),
                    BillNote = table.Column<string>(nullable: true),
                    Catagory = table.Column<string>(nullable: true),
                    BillCatagoryName = table.Column<string>(nullable: true),
                    CatagoryOptionName = table.Column<string>(nullable: true),
                    BillReminder = table.Column<string>(nullable: true),
                    BillRepeats = table.Column<string>(nullable: true),
                    ReminderName = table.Column<int>(nullable: false),
                    RepeatsName = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CatagoryOptionId = table.Column<int>(nullable: true),
                    BillCatagoryId = table.Column<int>(nullable: true),
                    ReminderId = table.Column<int>(nullable: true),
                    RepeatsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bills", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_bills_BillCatagories_BillCatagoryId",
                        column: x => x.BillCatagoryId,
                        principalTable: "BillCatagories",
                        principalColumn: "BillCatagoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bills_catagoryOptions_CatagoryOptionId",
                        column: x => x.CatagoryOptionId,
                        principalTable: "catagoryOptions",
                        principalColumn: "CatagoryOptionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bills_reminders_ReminderId",
                        column: x => x.ReminderId,
                        principalTable: "reminders",
                        principalColumn: "ReminderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bills_repeats_RepeatsId",
                        column: x => x.RepeatsId,
                        principalTable: "repeats",
                        principalColumn: "RepeatsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bills_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true),
                    FriendsId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_groups_friends_FriendsId",
                        column: x => x.FriendsId,
                        principalTable: "friends",
                        principalColumn: "FriendsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_groups_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Paymentmade = table.Column<int>(nullable: false),
                    PaymentReceive = table.Column<int>(nullable: false),
                    FriendsId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_payments_friends_FriendsId",
                        column: x => x.FriendsId,
                        principalTable: "friends",
                        principalColumn: "FriendsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_payments_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sattleUps",
                columns: table => new
                {
                    SattleupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SattleAmount = table.Column<int>(nullable: false),
                    PaymentModeId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    FriendsId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sattleUps", x => x.SattleupId);
                    table.ForeignKey(
                        name: "FK_sattleUps_friends_FriendsId",
                        column: x => x.FriendsId,
                        principalTable: "friends",
                        principalColumn: "FriendsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sattleUps_paymentModes_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalTable: "paymentModes",
                        principalColumn: "PaymentModeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sattleUps_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "shareds",
                columns: table => new
                {
                    SharedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SharedAmmount = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shareds", x => x.SharedId);
                    table.ForeignKey(
                        name: "FK_shareds_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_activities_FriendsId",
                table: "activities",
                column: "FriendsId");

            migrationBuilder.CreateIndex(
                name: "IX_activities_UserId",
                table: "activities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_balances_FriendsId",
                table: "balances",
                column: "FriendsId");

            migrationBuilder.CreateIndex(
                name: "IX_balances_UserId",
                table: "balances",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_bills_BillCatagoryId",
                table: "bills",
                column: "BillCatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_bills_CatagoryOptionId",
                table: "bills",
                column: "CatagoryOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_bills_ReminderId",
                table: "bills",
                column: "ReminderId");

            migrationBuilder.CreateIndex(
                name: "IX_bills_RepeatsId",
                table: "bills",
                column: "RepeatsId");

            migrationBuilder.CreateIndex(
                name: "IX_bills_UserId",
                table: "bills",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_groups_FriendsId",
                table: "groups",
                column: "FriendsId");

            migrationBuilder.CreateIndex(
                name: "IX_groups_UserId",
                table: "groups",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_owes_FriendsId",
                table: "owes",
                column: "FriendsId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_FriendsId",
                table: "payments",
                column: "FriendsId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_UserId",
                table: "payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_sattleUps_FriendsId",
                table: "sattleUps",
                column: "FriendsId");

            migrationBuilder.CreateIndex(
                name: "IX_sattleUps_PaymentModeId",
                table: "sattleUps",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_sattleUps_UserId",
                table: "sattleUps",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_shareds_UserId",
                table: "shareds",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "activities");

            migrationBuilder.DropTable(
                name: "balances");

            migrationBuilder.DropTable(
                name: "bills");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "owes");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "sattleUps");

            migrationBuilder.DropTable(
                name: "shareds");

            migrationBuilder.DropTable(
                name: "BillCatagories");

            migrationBuilder.DropTable(
                name: "catagoryOptions");

            migrationBuilder.DropTable(
                name: "reminders");

            migrationBuilder.DropTable(
                name: "repeats");

            migrationBuilder.DropTable(
                name: "friends");

            migrationBuilder.DropTable(
                name: "paymentModes");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
