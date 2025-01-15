using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace u20649232_HW01_API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseListings",
                columns: table => new
                {
                    courseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseName = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    courseDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    courseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseListings", x => x.courseId);
                });

            migrationBuilder.InsertData(
                table: "courseListings",
                columns: new[] { "courseId", "courseDescription", "courseDuration", "courseName" },
                values: new object[,]
                {
                    { 1, "Project teams and project managment", "Semester 1", "INF315" },
                    { 2, "Fundamentals of prgramming in C# webforms", "Semester 1", "INF154" },
                    { 3, "Fundamentals of html,css and javascript", "Semester 2", "INF164" },
                    { 4, "Advanced programming in MVC & databases", "Year", "INF272" },
                    { 5, "Advanced programming in sql, angular and api", "Semester 1", "INF354" },
                    { 6, "Fundamentals into systems architecture", "Year", "INF171" },
                    { 7, "Advanced system moddelling and sysetsms analysis", "Year", "INF271" },
                    { 8, "Full systems development life cycle project", "Year", "INF370" },
                    { 9, "Tends in IT", "Semester 2", "INF324" },
                    { 10, "Knowledge managment in organisation at coprate strategic level", "Semester 2", "INL320" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseListings");
        }
    }
}
