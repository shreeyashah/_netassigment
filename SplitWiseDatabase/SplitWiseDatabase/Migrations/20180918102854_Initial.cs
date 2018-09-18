using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SplitWiseDatabase.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activities", x => x.ActivityId);
                });

            migrationBuilder.CreateTable(
                name: "balances",
                columns: table => new
                {
                    BalanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BalanceAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_balances", x => x.BalanceId);
                });

            migrationBuilder.CreateTable(
                name: "BillCatagories",
                columns: table => new
                {
                    BillCatagoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CatagoryName = table.Column<string>(nullable: true)
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
                name: "owes",
                columns: table => new
                {
                    OwesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OwesAmmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owes", x => x.OwesId);
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
                name: "sattleUps",
                columns: table => new
                {
                    SattleupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SattleAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sattleUps", x => x.SattleupId);
                });

            migrationBuilder.CreateTable(
                name: "shareds",
                columns: table => new
                {
                    SharedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SharedAmmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shareds", x => x.SharedId);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Paymentmade = table.Column<int>(nullable: false),
                    PaymentReceive = table.Column<int>(nullable: false),
                    PayMode = table.Column<string>(nullable: true),
                    PaymentModeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_payments_paymentModes_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalTable: "paymentModes",
                        principalColumn: "PaymentModeId",
                        onDelete: ReferentialAction.Restrict);
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
                    catagoryOption = table.Column<string>(nullable: true),
                    BillReminder = table.Column<string>(nullable: true),
                    BillRepeats = table.Column<string>(nullable: true),
                    CatagoryOptionId = table.Column<int>(nullable: true),
                    BillCatagoryId = table.Column<int>(nullable: true),
                    PaymentId = table.Column<int>(nullable: true),
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
                        name: "FK_bills_payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "payments",
                        principalColumn: "PaymentId",
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
                });

            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true),
                    BillId = table.Column<int>(nullable: true),
                    OwesId = table.Column<int>(nullable: true),
                    SharedId = table.Column<int>(nullable: true),
                    BalanceId = table.Column<int>(nullable: true),
                    SattleupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_groups_balances_BalanceId",
                        column: x => x.BalanceId,
                        principalTable: "balances",
                        principalColumn: "BalanceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_groups_bills_BillId",
                        column: x => x.BillId,
                        principalTable: "bills",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_groups_owes_OwesId",
                        column: x => x.OwesId,
                        principalTable: "owes",
                        principalColumn: "OwesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_groups_sattleUps_SattleupId",
                        column: x => x.SattleupId,
                        principalTable: "sattleUps",
                        principalColumn: "SattleupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_groups_shareds_SharedId",
                        column: x => x.SharedId,
                        principalTable: "shareds",
                        principalColumn: "SharedId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "friends",
                columns: table => new
                {
                    FriendsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FriendName = table.Column<string>(nullable: true),
                    FriendEmail = table.Column<string>(nullable: true),
                    ActivityId = table.Column<int>(nullable: true),
                    PaymentId = table.Column<int>(nullable: true),
                    SharedId = table.Column<int>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    OwesId = table.Column<int>(nullable: true),
                    SattleupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_friends", x => x.FriendsId);
                    table.ForeignKey(
                        name: "FK_friends_activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_friends_groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_friends_owes_OwesId",
                        column: x => x.OwesId,
                        principalTable: "owes",
                        principalColumn: "OwesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_friends_payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "payments",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_friends_sattleUps_SattleupId",
                        column: x => x.SattleupId,
                        principalTable: "sattleUps",
                        principalColumn: "SattleupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_friends_shareds_SharedId",
                        column: x => x.SharedId,
                        principalTable: "shareds",
                        principalColumn: "SharedId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true),
                    FriendsId = table.Column<int>(nullable: true),
                    BillId = table.Column<int>(nullable: true),
                    PaymentId = table.Column<int>(nullable: true),
                    SattleupId = table.Column<int>(nullable: true),
                    SharedId = table.Column<int>(nullable: true),
                    OwesId = table.Column<int>(nullable: true),
                    ActivityId = table.Column<int>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    BalanceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_users_activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_users_balances_BalanceId",
                        column: x => x.BalanceId,
                        principalTable: "balances",
                        principalColumn: "BalanceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_users_bills_BillId",
                        column: x => x.BillId,
                        principalTable: "bills",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_users_friends_FriendsId",
                        column: x => x.FriendsId,
                        principalTable: "friends",
                        principalColumn: "FriendsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_users_groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_users_owes_OwesId",
                        column: x => x.OwesId,
                        principalTable: "owes",
                        principalColumn: "OwesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_users_payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "payments",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_users_sattleUps_SattleupId",
                        column: x => x.SattleupId,
                        principalTable: "sattleUps",
                        principalColumn: "SattleupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_users_shareds_SharedId",
                        column: x => x.SharedId,
                        principalTable: "shareds",
                        principalColumn: "SharedId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bills_BillCatagoryId",
                table: "bills",
                column: "BillCatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_bills_CatagoryOptionId",
                table: "bills",
                column: "CatagoryOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_bills_PaymentId",
                table: "bills",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_bills_ReminderId",
                table: "bills",
                column: "ReminderId");

            migrationBuilder.CreateIndex(
                name: "IX_bills_RepeatsId",
                table: "bills",
                column: "RepeatsId");

            migrationBuilder.CreateIndex(
                name: "IX_friends_ActivityId",
                table: "friends",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_friends_GroupId",
                table: "friends",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_friends_OwesId",
                table: "friends",
                column: "OwesId");

            migrationBuilder.CreateIndex(
                name: "IX_friends_PaymentId",
                table: "friends",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_friends_SattleupId",
                table: "friends",
                column: "SattleupId");

            migrationBuilder.CreateIndex(
                name: "IX_friends_SharedId",
                table: "friends",
                column: "SharedId");

            migrationBuilder.CreateIndex(
                name: "IX_groups_BalanceId",
                table: "groups",
                column: "BalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_groups_BillId",
                table: "groups",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_groups_OwesId",
                table: "groups",
                column: "OwesId");

            migrationBuilder.CreateIndex(
                name: "IX_groups_SattleupId",
                table: "groups",
                column: "SattleupId");

            migrationBuilder.CreateIndex(
                name: "IX_groups_SharedId",
                table: "groups",
                column: "SharedId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_PaymentModeId",
                table: "payments",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_users_ActivityId",
                table: "users",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_users_BalanceId",
                table: "users",
                column: "BalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_users_BillId",
                table: "users",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_users_FriendsId",
                table: "users",
                column: "FriendsId");

            migrationBuilder.CreateIndex(
                name: "IX_users_GroupId",
                table: "users",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_users_OwesId",
                table: "users",
                column: "OwesId");

            migrationBuilder.CreateIndex(
                name: "IX_users_PaymentId",
                table: "users",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_users_SattleupId",
                table: "users",
                column: "SattleupId");

            migrationBuilder.CreateIndex(
                name: "IX_users_SharedId",
                table: "users",
                column: "SharedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "friends");

            migrationBuilder.DropTable(
                name: "activities");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "balances");

            migrationBuilder.DropTable(
                name: "bills");

            migrationBuilder.DropTable(
                name: "owes");

            migrationBuilder.DropTable(
                name: "sattleUps");

            migrationBuilder.DropTable(
                name: "shareds");

            migrationBuilder.DropTable(
                name: "BillCatagories");

            migrationBuilder.DropTable(
                name: "catagoryOptions");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "reminders");

            migrationBuilder.DropTable(
                name: "repeats");

            migrationBuilder.DropTable(
                name: "paymentModes");
        }
    }
}
