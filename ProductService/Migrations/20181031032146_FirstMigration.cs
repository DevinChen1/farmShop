using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductService.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryInfos",
                columns: table => new
                {
                    CateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DisplayOrder = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PriceRange = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    Layer = table.Column<int>(nullable: false),
                    HasChild = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryInfos", x => x.CateId);
                });

            migrationBuilder.CreateTable(
                name: "ProductImageInfos",
                columns: table => new
                {
                    PImgId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pid = table.Column<int>(nullable: false),
                    ShowImg = table.Column<string>(nullable: true),
                    IsMain = table.Column<int>(nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImageInfos", x => x.PImgId);
                });

            migrationBuilder.CreateTable(
                name: "ProductInfos",
                columns: table => new
                {
                    Pid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Psn = table.Column<string>(nullable: true),
                    Cateid = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Shopprice = table.Column<decimal>(nullable: false),
                    Marketprice = table.Column<decimal>(nullable: false),
                    Costprice = table.Column<decimal>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    Isbest = table.Column<bool>(nullable: false),
                    Ishot = table.Column<bool>(nullable: false),
                    Isnew = table.Column<bool>(nullable: false),
                    Displayorder = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Showimg = table.Column<string>(nullable: true),
                    Salecount = table.Column<int>(nullable: false),
                    Visitcount = table.Column<int>(nullable: false),
                    Reviewcount = table.Column<int>(nullable: false),
                    Star = table.Column<int>(nullable: false),
                    _addtime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Limit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInfos", x => x.Pid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryInfos");

            migrationBuilder.DropTable(
                name: "ProductImageInfos");

            migrationBuilder.DropTable(
                name: "ProductInfos");
        }
    }
}
