using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HumanitarianAssistance.Persistence.Migrations
{
    public partial class fileManagementEntitiesTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntitySourceDocumentDetails",
                columns: table => new
                {
                    EntitySourceDocumentId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    CreatedById = table.Column<string>(nullable: true),
                    ModifiedById = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    EntityId = table.Column<long>(nullable: false),
                    DocumentFileId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntitySourceDocumentDetails", x => x.EntitySourceDocumentId);
                    table.ForeignKey(
                        name: "FK_EntitySourceDocumentDetails_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntitySourceDocumentDetails_DocumentFileDetail_DocumentFile~",
                        column: x => x.DocumentFileId,
                        principalTable: "DocumentFileDetail",
                        principalColumn: "DocumentFileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntitySourceDocumentDetails_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChatDetail",
                columns: table => new
                {
                    ChatId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    CreatedById = table.Column<string>(nullable: true),
                    ModifiedById = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    ChatSourceEntityId = table.Column<int>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    EntitySourceDocumentId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatDetail", x => x.ChatId);
                    table.ForeignKey(
                        name: "FK_ChatDetail_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatDetail_EntitySourceDocumentDetails_EntitySourceDocument~",
                        column: x => x.EntitySourceDocumentId,
                        principalTable: "EntitySourceDocumentDetails",
                        principalColumn: "EntitySourceDocumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatDetail_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatDetail_CreatedById",
                table: "ChatDetail",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ChatDetail_EntitySourceDocumentId",
                table: "ChatDetail",
                column: "EntitySourceDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatDetail_ModifiedById",
                table: "ChatDetail",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_EntitySourceDocumentDetails_CreatedById",
                table: "EntitySourceDocumentDetails",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EntitySourceDocumentDetails_DocumentFileId",
                table: "EntitySourceDocumentDetails",
                column: "DocumentFileId");

            migrationBuilder.CreateIndex(
                name: "IX_EntitySourceDocumentDetails_ModifiedById",
                table: "EntitySourceDocumentDetails",
                column: "ModifiedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatDetail");

            migrationBuilder.DropTable(
                name: "EntitySourceDocumentDetails");
        }
    }
}
