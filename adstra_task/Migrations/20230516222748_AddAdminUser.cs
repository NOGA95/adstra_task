using Microsoft.EntityFrameworkCore.Migrations;

namespace adstra_task.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'8b793c95-c8c9-426d-a53e-284042669a27', N'admin', N'ADMIN', N'admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAIAAYagAAAAEJVm7DhqmSxQV+STw9Mpa4VILiJQcu+h7H6ZPrn2lgryNQh4QoAEyQWEasl+nQ5ciQ==', N'VJULRD3CJTCCV4M7M4IB3EOM45RA4YGT', N'c4331d2a-4a55-4921-935d-e17b7f69855b', N'12457896', 0, 0, NULL, 1, 0, N'test', N'sth')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Id ='8b793c95-c8c9-426d-a53e-284042669a27'");
        }
    }
}
