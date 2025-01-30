using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApp.Data.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6806), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6809), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6812), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6815), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6819), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6822), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6824), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6827), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6830), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6833), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6835), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedByUsername", "CreatedDate", "UpdatedByUsername", "UpdatedDate" },
                values: new object[] { "uricaryn", new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6838), "uricaryn", new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6866), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6869), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6872), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6874), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6877), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6980), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6983), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6985), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6988), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6990), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6994), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6996), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7037), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7042), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7045), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7048), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7051), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7053), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7056), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7059), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7062), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7064), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7079), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7088), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7090), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7092), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7095), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7097), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7102), new DateTime(2024, 9, 25, 13, 45, 48, 76, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedByUsername", "CreatedDate", "Email", "Firstname", "GitHubLink", "Lastname", "PasswordHash", "UpdatedByUsername", "UpdatedDate", "Username", "WebsiteLink" },
                values: new object[] { "uricaryn", new DateTime(2024, 9, 25, 13, 45, 48, 71, DateTimeKind.Local).AddTicks(3116), "onur@gmail.com", "Onur", "uricaryn_", "Anatca", "AQAAAAEAACcQAAAAEEx8n8JeMD6dZYpj6B+G3fIhnXNOHTvYJJ1u6wAqKOOGr+rM8xZhKWHYZIo0imjbjQ==", "uricaryn", new DateTime(2024, 9, 25, 13, 45, 48, 71, DateTimeKind.Local).AddTicks(3116), "uricaryn", "onuranatca.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 72, DateTimeKind.Local).AddTicks(6539), "AQAAAAEAACcQAAAAED04hyzZhUY1yyxcOX/7aSosuiYXPbv8eNah5Fz2ygfyN3abbKOpfb2Rt6BD5tuI+Q==", new DateTime(2024, 9, 25, 13, 45, 48, 72, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 74, DateTimeKind.Local).AddTicks(518), "AQAAAAEAACcQAAAAEHZWCFiCaHe2AVXIcnWtTvDlGms0cJSFYS6h8w8AMDABghddHo3zIk/o93eNvm8wpw==", new DateTime(2024, 9, 25, 13, 45, 48, 74, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 25, 13, 45, 48, 75, DateTimeKind.Local).AddTicks(3582), "AQAAAAEAACcQAAAAEHyzv1ds50ONlzFSTRl1qDyLz3WPNVfy4Y0PtLBn2Gyh+CtQY440R+jMkU0lSwNboQ==", new DateTime(2024, 9, 25, 13, 45, 48, 75, DateTimeKind.Local).AddTicks(3582) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2896), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2899), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2901), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2904), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2907), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2909), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2912), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2914), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2916), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2919), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2921), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedByUsername", "CreatedDate", "UpdatedByUsername", "UpdatedDate" },
                values: new object[] { "ozkky", new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2924), "ozkky", new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2942), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2944), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2946), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2951), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2953), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2955), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2957), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2959), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2962), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2964), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2966), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2968), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3037), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3041), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3043), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3046), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3049), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3051), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3053), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3056), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3058), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3061), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3075), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3077), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3079), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3082), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3084), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3086), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3088), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3091), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3093), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3095), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedByUsername", "CreatedDate", "Email", "Firstname", "GitHubLink", "Lastname", "PasswordHash", "UpdatedByUsername", "UpdatedDate", "Username", "WebsiteLink" },
                values: new object[] { "ozkky", new DateTime(2024, 8, 28, 14, 2, 47, 214, DateTimeKind.Local).AddTicks(9531), "ozkky@gmail.com", "Özkan", "ozkanakkaya", "Akkaya", "AQAAAAEAACcQAAAAEHBL/vs9xhAp044jgPszPxtpAdFEOHbuUEE6WWKlG2t5rJVPmqzvQu78cA8c/wtYrA==", "ozkky", new DateTime(2024, 8, 28, 14, 2, 47, 214, DateTimeKind.Local).AddTicks(9532), "ozkky", "ozkanakkaya.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 216, DateTimeKind.Local).AddTicks(1341), "AQAAAAEAACcQAAAAEACOSM2Hkn/DFx9DyDtFSoKGZ4+JihYb/6WpX4DXQp21/NiXrIIInROrncD+efZi9A==", new DateTime(2024, 8, 28, 14, 2, 47, 216, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 217, DateTimeKind.Local).AddTicks(3085), "AQAAAAEAACcQAAAAEBd9fPyEWSGAiRXwfG092WNXSbrzyxOqAHSYuEhk+/wtJ3Rrp+DvVhW4PWTGglzn8g==", new DateTime(2024, 8, 28, 14, 2, 47, 217, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 218, DateTimeKind.Local).AddTicks(3641), "AQAAAAEAACcQAAAAEKPsGhI4fHyXiOHYCk+bDGRmbCYh7deQS/cq95LEDIPzXNK/3M4zVA+/g/7cUHNZCA==", new DateTime(2024, 8, 28, 14, 2, 47, 218, DateTimeKind.Local).AddTicks(3641) });
        }
    }
}
