using Microsoft.EntityFrameworkCore.Migrations;

namespace adstra_task.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into AspNetUserRoles(UserId,RoleId) select '8b793c95-c8c9-426d-a53e-284042669a27' ,Id  from AspNetRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM AspNetUserRoles WHERE UserId ='8b793c95-c8c9-426d-a53e-284042669a27' ");
        }
    }
}
