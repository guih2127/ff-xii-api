using Microsoft.EntityFrameworkCore.Migrations;

namespace FF_XII_API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterGender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterGender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Level = table.Column<int>(nullable: true),
                    XP = table.Column<int>(nullable: true),
                    LP = table.Column<int>(nullable: true),
                    AP = table.Column<int>(nullable: true),
                    Money = table.Column<int>(nullable: true),
                    GenderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Character_CharacterGender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "CharacterGender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterTypeCharacter",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false),
                    CharacterTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTypeCharacter", x => new { x.CharacterId, x.CharacterTypeId });
                    table.ForeignKey(
                        name: "FK_CharacterTypeCharacter_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterTypeCharacter_CharacterType_CharacterTypeId",
                        column: x => x.CharacterTypeId,
                        principalTable: "CharacterType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CharacterGender",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Gênero 1" },
                    { 2, "Gênero 2" }
                });

            migrationBuilder.InsertData(
                table: "CharacterType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tipo 1" },
                    { 2, "Tipo 2" }
                });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "Id", "AP", "Age", "Description", "GenderId", "LP", "Level", "Money", "Name", "Picture", "XP" },
                values: new object[] { 1, null, null, null, 1, null, null, null, "Personagem 1", null, null });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "Id", "AP", "Age", "Description", "GenderId", "LP", "Level", "Money", "Name", "Picture", "XP" },
                values: new object[] { 2, null, null, null, 2, null, null, null, "Personagem 2", null, null });

            migrationBuilder.InsertData(
                table: "CharacterTypeCharacter",
                columns: new[] { "CharacterId", "CharacterTypeId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "CharacterTypeCharacter",
                columns: new[] { "CharacterId", "CharacterTypeId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CharacterTypeCharacter",
                columns: new[] { "CharacterId", "CharacterTypeId" },
                values: new object[] { 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Character_GenderId",
                table: "Character",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTypeCharacter_CharacterTypeId",
                table: "CharacterTypeCharacter",
                column: "CharacterTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterTypeCharacter");

            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropTable(
                name: "CharacterType");

            migrationBuilder.DropTable(
                name: "CharacterGender");
        }
    }
}
