using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatApi.Migrations
{
    public partial class FirstChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Messages",
            //    columns: table => new
            //    {
            //        MessageID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SentAt = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ReadAt = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Messages", x => x.MessageID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        UserID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.UserID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserMessages",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MessageID = table.Column<int>(type: "int", nullable: false),
            //        SenderID = table.Column<int>(type: "int", nullable: false),
            //        ReceiverID = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserMessages", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_UserMessages_Messages_MessageID",
            //            column: x => x.MessageID,
            //            principalTable: "Messages",
            //            principalColumn: "MessageID");
            //        table.ForeignKey(
            //            name: "FK_UserMessages_Users_ReceiverID",
            //            column: x => x.ReceiverID,
            //            principalTable: "Users",
            //            principalColumn: "UserID");
            //        table.ForeignKey(
            //            name: "FK_UserMessages_Users_SenderID",
            //            column: x => x.SenderID,
            //            principalTable: "Users",
            //            principalColumn: "UserID");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserMessages_MessageID",
            //    table: "UserMessages",
            //    column: "MessageID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserMessages_ReceiverID",
            //    table: "UserMessages",
            //    column: "ReceiverID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserMessages_SenderID",
            //    table: "UserMessages",
            //    column: "SenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserMessages");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
