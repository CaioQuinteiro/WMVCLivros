using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMVCLivros.Migrations
{
    /// <inheritdoc />
    public partial class Livros : Migration
    {
        public object AutoresID { get; internal set; }
        public object EditoraID { get; internal set; }
        public int Id { get; internal set; }

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    Qtde = table.Column<int>(type: "int", nullable: false),
                    AnoDePublicacao = table.Column<int>(type: "int", nullable: false),
                    AutoresID = table.Column<int>(type: "int", nullable: false),
                    EditoraID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livros_Autores_AutoresID",
                        column: x => x.AutoresID,
                        principalTable: "Autores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Livros_Editoras_EditoraID",
                        column: x => x.EditoraID,
                        principalTable: "Editoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livros_AutoresID",
                table: "Livros",
                column: "AutoresID");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_EditoraID",
                table: "Livros",
                column: "EditoraID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
