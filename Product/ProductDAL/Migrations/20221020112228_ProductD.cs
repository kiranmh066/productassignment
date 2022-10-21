using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductDAL.Migrations
{
    public partial class ProductD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblColor",
                columns: table => new
                {
                    colorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    colorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    colorCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblColor", x => x.colorId);
                });

            migrationBuilder.CreateTable(
                name: "tblSizeScale",
                columns: table => new
                {
                    sizeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sizeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSizeScale", x => x.sizeId);
                });

            migrationBuilder.CreateTable(
                name: "tblProduct",
                columns: table => new
                {
                    productId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productYear = table.Column<int>(type: "int", nullable: false),
                    channelId = table.Column<int>(type: "int", nullable: false),
                    sizeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tblArticlearticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProduct", x => x.productId);
                    table.ForeignKey(
                        name: "FK_tblProduct_tblSizeScale_sizeId",
                        column: x => x.sizeId,
                        principalTable: "tblSizeScale",
                        principalColumn: "sizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblArticle",
                columns: table => new
                {
                    articleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    articleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    colorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tblArticle = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblArticle", x => x.articleId);
                    table.ForeignKey(
                        name: "FK_tblArticle_tblColor_colorId",
                        column: x => x.colorId,
                        principalTable: "tblColor",
                        principalColumn: "colorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblArticle_tblProduct_tblArticle",
                        column: x => x.tblArticle,
                        principalTable: "tblProduct",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblArticle_colorId",
                table: "tblArticle",
                column: "colorId");

            migrationBuilder.CreateIndex(
                name: "IX_tblArticle_tblArticle",
                table: "tblArticle",
                column: "tblArticle");

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_sizeId",
                table: "tblProduct",
                column: "sizeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProduct_tblArticlearticleId",
                table: "tblProduct",
                column: "tblArticlearticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblProduct_tblArticle_tblArticlearticleId",
                table: "tblProduct",
                column: "tblArticlearticleId",
                principalTable: "tblArticle",
                principalColumn: "articleId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblArticle_tblColor_colorId",
                table: "tblArticle");

            migrationBuilder.DropForeignKey(
                name: "FK_tblArticle_tblProduct_tblArticle",
                table: "tblArticle");

            migrationBuilder.DropTable(
                name: "tblColor");

            migrationBuilder.DropTable(
                name: "tblProduct");

            migrationBuilder.DropTable(
                name: "tblArticle");

            migrationBuilder.DropTable(
                name: "tblSizeScale");
        }
    }
}
