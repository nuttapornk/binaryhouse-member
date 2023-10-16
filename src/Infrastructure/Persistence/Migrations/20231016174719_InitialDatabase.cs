using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Info",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateUser = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TelType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    InfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    AddressTypeId = table.Column<int>(type: "integer", nullable: false),
                    Line1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Line2 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DistrictId = table.Column<int>(type: "integer", nullable: false),
                    DistrictName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SubDistrictId = table.Column<int>(type: "integer", nullable: false),
                    SubDistrictName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ProvinceId = table.Column<int>(type: "integer", nullable: false),
                    ProvinceName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(type: "character(5)", maxLength: 5, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateUser = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_Info_InfoId",
                        column: x => x.InfoId,
                        principalTable: "Info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    InfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateUser = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Member_Info_InfoId",
                        column: x => x.InfoId,
                        principalTable: "Info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Member_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    InfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    TelTypeId = table.Column<int>(type: "integer", nullable: false),
                    Number = table.Column<string>(type: "character(10)", maxLength: 10, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateUser = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tel_Info_InfoId",
                        column: x => x.InfoId,
                        principalTable: "Info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tel_TelType_TelTypeId",
                        column: x => x.TelTypeId,
                        principalTable: "TelType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_InfoId",
                table: "Address",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_InfoId",
                table: "Member",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_RoleId",
                table: "Member",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tel_InfoId",
                table: "Tel",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tel_TelTypeId",
                table: "Tel",
                column: "TelTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Tel");

            migrationBuilder.DropTable(
                name: "AddressType");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Info");

            migrationBuilder.DropTable(
                name: "TelType");
        }
    }
}
