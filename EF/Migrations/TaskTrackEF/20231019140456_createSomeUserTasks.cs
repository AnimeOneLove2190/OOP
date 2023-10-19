using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFVaiaa.Migrations.TaskTrackEF
{
    public partial class createSomeUserTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SomeUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SomeUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleSomeUserTasks",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    SomeUsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleSomeUserTasks", x => new { x.RolesId, x.SomeUsersId });
                    table.ForeignKey(
                        name: "FK_RoleSomeUserTasks_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleSomeUserTasks_SomeUsers_SomeUsersId",
                        column: x => x.SomeUsersId,
                        principalTable: "SomeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SomeUserTasksTask",
                columns: table => new
                {
                    SomeUsersId = table.Column<int>(type: "int", nullable: false),
                    TasksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SomeUserTasksTask", x => new { x.SomeUsersId, x.TasksId });
                    table.ForeignKey(
                        name: "FK_SomeUserTasksTask_SomeUsers_SomeUsersId",
                        column: x => x.SomeUsersId,
                        principalTable: "SomeUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SomeUserTasksTask_Tasks_TasksId",
                        column: x => x.TasksId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleSomeUserTasks_SomeUsersId",
                table: "RoleSomeUserTasks",
                column: "SomeUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_SomeUserTasksTask_TasksId",
                table: "SomeUserTasksTask",
                column: "TasksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleSomeUserTasks");

            migrationBuilder.DropTable(
                name: "SomeUserTasksTask");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SomeUsers");

            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
