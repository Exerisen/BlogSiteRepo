using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSite.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblArticle",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    ArticleContent = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    PublisherID = table.Column<Guid>(nullable: false),
                    CoverImageID = table.Column<int>(nullable: false),
                    Views = table.Column<int>(nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblArticle", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tblCategory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tblMedia",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    SmallPath = table.Column<string>(nullable: true),
                    MediumPath = table.Column<string>(nullable: true),
                    LargePath = table.Column<string>(nullable: true),
                    VideoPath = table.Column<string>(nullable: true),
                    UploadDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMedia", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tblTag",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTag", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tblVisitor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IPAdress = table.Column<string>(nullable: true),
                    VisitDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblVisitor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tblComment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    CommentContent = table.Column<string>(nullable: true),
                    ArticleID = table.Column<int>(nullable: false),
                    SubmitDate = table.Column<DateTime>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    tblArticleID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblComment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tblComment_tblArticle_tblArticleID",
                        column: x => x.tblArticleID,
                        principalTable: "tblArticle",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblArticleImage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArticleID = table.Column<int>(nullable: false),
                    ImageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblArticleImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tblArticleImage_tblArticle_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "tblArticle",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblArticleImage_tblMedia_ImageID",
                        column: x => x.ImageID,
                        principalTable: "tblMedia",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblAuthor",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Nickname = table.Column<string>(nullable: true),
                    MailAdress = table.Column<string>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    ImageID = table.Column<int>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    tblMediaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAuthor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tblAuthor_tblMedia_tblMediaID",
                        column: x => x.tblMediaID,
                        principalTable: "tblMedia",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblArticleTag",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArticleID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblArticleTag", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tblArticleTag_tblArticle_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "tblArticle",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblArticleTag_tblTag_TagID",
                        column: x => x.TagID,
                        principalTable: "tblTag",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblArticleImage_ArticleID",
                table: "tblArticleImage",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_tblArticleImage_ImageID",
                table: "tblArticleImage",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_tblArticleTag_ArticleID",
                table: "tblArticleTag",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_tblArticleTag_TagID",
                table: "tblArticleTag",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_tblAuthor_tblMediaID",
                table: "tblAuthor",
                column: "tblMediaID");

            migrationBuilder.CreateIndex(
                name: "IX_tblComment_tblArticleID",
                table: "tblComment",
                column: "tblArticleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblArticleImage");

            migrationBuilder.DropTable(
                name: "tblArticleTag");

            migrationBuilder.DropTable(
                name: "tblAuthor");

            migrationBuilder.DropTable(
                name: "tblCategory");

            migrationBuilder.DropTable(
                name: "tblComment");

            migrationBuilder.DropTable(
                name: "tblVisitor");

            migrationBuilder.DropTable(
                name: "tblTag");

            migrationBuilder.DropTable(
                name: "tblMedia");

            migrationBuilder.DropTable(
                name: "tblArticle");
        }
    }
}
