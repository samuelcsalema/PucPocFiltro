using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PucPocVS.Migrations
{
    /// <inheritdoc />
    public partial class M2AdicionandoTabelasErrata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentorados_Usuarios_IdUsuario",
                table: "Mentorados");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentores_Usuarios_IdUsuario",
                table: "Mentores");

            migrationBuilder.DropForeignKey(
                name: "FK_MentoresAreas_AreasConhecimento_IdArea",
                table: "MentoresAreas");

            migrationBuilder.DropForeignKey(
                name: "FK_MentoresAreas_Mentores_IdMentor",
                table: "MentoresAreas");

            migrationBuilder.DropForeignKey(
                name: "FK_MentoresTecnologias_Mentores_IdMentor",
                table: "MentoresTecnologias");

            migrationBuilder.DropForeignKey(
                name: "FK_MentoresTecnologias_Tecnologias_IdTecnologia",
                table: "MentoresTecnologias");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_NiveisAcesso_IdNivelAcesso",
                table: "Usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tecnologias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "NiveisAcesso",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "AreasConhecimento",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Duracoes",
                columns: table => new
                {
                    IdDuracao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tempo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duracoes", x => x.IdDuracao);
                });

            migrationBuilder.CreateTable(
                name: "Mentorias",
                columns: table => new
                {
                    IdMentoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMentorado = table.Column<int>(type: "int", nullable: false),
                    IdMentor = table.Column<int>(type: "int", nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentorias", x => x.IdMentoria);
                    table.ForeignKey(
                        name: "FK_Mentorias_Mentorados_IdMentorado",
                        column: x => x.IdMentorado,
                        principalTable: "Mentorados",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mentorias_Mentores_IdMentor",
                        column: x => x.IdMentor,
                        principalTable: "Mentores",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Disponibilidades",
                columns: table => new
                {
                    IdDisponibilidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMentor = table.Column<int>(type: "int", nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdDuracao = table.Column<int>(type: "int", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disponibilidades", x => x.IdDisponibilidade);
                    table.ForeignKey(
                        name: "FK_Disponibilidades_Duracoes_IdDuracao",
                        column: x => x.IdDuracao,
                        principalTable: "Duracoes",
                        principalColumn: "IdDuracao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Disponibilidades_Mentores_IdMentor",
                        column: x => x.IdMentor,
                        principalTable: "Mentores",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Anotacoes",
                columns: table => new
                {
                    IdAnotacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnotacaoMentorado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMentorado = table.Column<int>(type: "int", nullable: false),
                    IdMentoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anotacoes", x => x.IdAnotacao);
                    table.ForeignKey(
                        name: "FK_Anotacoes_Mentorados_IdMentorado",
                        column: x => x.IdMentorado,
                        principalTable: "Mentorados",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anotacoes_Mentorias_IdMentoria",
                        column: x => x.IdMentoria,
                        principalTable: "Mentorias",
                        principalColumn: "IdMentoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacoesMentor",
                columns: table => new
                {
                    IdAvaliacaoMentor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMentor = table.Column<int>(type: "int", nullable: false),
                    IdMentorado = table.Column<int>(type: "int", nullable: false),
                    IdMentoria = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<float>(type: "real", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacoesMentor", x => x.IdAvaliacaoMentor);
                    table.ForeignKey(
                        name: "FK_AvaliacoesMentor_Mentorados_IdMentorado",
                        column: x => x.IdMentorado,
                        principalTable: "Mentorados",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AvaliacoesMentor_Mentores_IdMentor",
                        column: x => x.IdMentor,
                        principalTable: "Mentores",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AvaliacoesMentor_Mentorias_IdMentoria",
                        column: x => x.IdMentoria,
                        principalTable: "Mentorias",
                        principalColumn: "IdMentoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacoesMentoria",
                columns: table => new
                {
                    IdAvaliacaoMentoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMentoria = table.Column<int>(type: "int", nullable: false),
                    IdMentorado = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<float>(type: "real", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacoesMentoria", x => x.IdAvaliacaoMentoria);
                    table.ForeignKey(
                        name: "FK_AvaliacoesMentoria_Mentorados_IdMentorado",
                        column: x => x.IdMentorado,
                        principalTable: "Mentorados",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AvaliacoesMentoria_Mentorias_IdMentoria",
                        column: x => x.IdMentoria,
                        principalTable: "Mentorias",
                        principalColumn: "IdMentoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MateriaisDeApoio",
                columns: table => new
                {
                    IdMaterialApoio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdMentor = table.Column<int>(type: "int", nullable: false),
                    IdMentoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaisDeApoio", x => x.IdMaterialApoio);
                    table.ForeignKey(
                        name: "FK_MateriaisDeApoio_Mentores_IdMentor",
                        column: x => x.IdMentor,
                        principalTable: "Mentores",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MateriaisDeApoio_Mentorias_IdMentoria",
                        column: x => x.IdMentoria,
                        principalTable: "Mentorias",
                        principalColumn: "IdMentoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AvaliacoesMaterial",
                columns: table => new
                {
                    IdAvaliacaoMaterial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMaterialApoio = table.Column<int>(type: "int", nullable: false),
                    IdMentorado = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<float>(type: "real", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacoesMaterial", x => x.IdAvaliacaoMaterial);
                    table.ForeignKey(
                        name: "FK_AvaliacoesMaterial_MateriaisDeApoio_IdMaterialApoio",
                        column: x => x.IdMaterialApoio,
                        principalTable: "MateriaisDeApoio",
                        principalColumn: "IdMaterialApoio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AvaliacoesMaterial_Mentorados_IdMentorado",
                        column: x => x.IdMentorado,
                        principalTable: "Mentorados",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anotacoes_IdMentorado",
                table: "Anotacoes",
                column: "IdMentorado");

            migrationBuilder.CreateIndex(
                name: "IX_Anotacoes_IdMentoria",
                table: "Anotacoes",
                column: "IdMentoria");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacoesMaterial_IdMaterialApoio",
                table: "AvaliacoesMaterial",
                column: "IdMaterialApoio");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacoesMaterial_IdMentorado",
                table: "AvaliacoesMaterial",
                column: "IdMentorado");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacoesMentor_IdMentor",
                table: "AvaliacoesMentor",
                column: "IdMentor");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacoesMentor_IdMentorado",
                table: "AvaliacoesMentor",
                column: "IdMentorado");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacoesMentor_IdMentoria",
                table: "AvaliacoesMentor",
                column: "IdMentoria");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacoesMentoria_IdMentorado",
                table: "AvaliacoesMentoria",
                column: "IdMentorado");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacoesMentoria_IdMentoria",
                table: "AvaliacoesMentoria",
                column: "IdMentoria");

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilidades_IdDuracao",
                table: "Disponibilidades",
                column: "IdDuracao");

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilidades_IdMentor",
                table: "Disponibilidades",
                column: "IdMentor");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaisDeApoio_IdMentor",
                table: "MateriaisDeApoio",
                column: "IdMentor");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaisDeApoio_IdMentoria",
                table: "MateriaisDeApoio",
                column: "IdMentoria");

            migrationBuilder.CreateIndex(
                name: "IX_Mentorias_IdMentor",
                table: "Mentorias",
                column: "IdMentor");

            migrationBuilder.CreateIndex(
                name: "IX_Mentorias_IdMentorado",
                table: "Mentorias",
                column: "IdMentorado");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentorados_Usuarios_IdUsuario",
                table: "Mentorados",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentores_Usuarios_IdUsuario",
                table: "Mentores",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MentoresAreas_AreasConhecimento_IdArea",
                table: "MentoresAreas",
                column: "IdArea",
                principalTable: "AreasConhecimento",
                principalColumn: "IdArea",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MentoresAreas_Mentores_IdMentor",
                table: "MentoresAreas",
                column: "IdMentor",
                principalTable: "Mentores",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MentoresTecnologias_Mentores_IdMentor",
                table: "MentoresTecnologias",
                column: "IdMentor",
                principalTable: "Mentores",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MentoresTecnologias_Tecnologias_IdTecnologia",
                table: "MentoresTecnologias",
                column: "IdTecnologia",
                principalTable: "Tecnologias",
                principalColumn: "IdTecnologia",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_NiveisAcesso_IdNivelAcesso",
                table: "Usuarios",
                column: "IdNivelAcesso",
                principalTable: "NiveisAcesso",
                principalColumn: "IdNivelAcesso",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentorados_Usuarios_IdUsuario",
                table: "Mentorados");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentores_Usuarios_IdUsuario",
                table: "Mentores");

            migrationBuilder.DropForeignKey(
                name: "FK_MentoresAreas_AreasConhecimento_IdArea",
                table: "MentoresAreas");

            migrationBuilder.DropForeignKey(
                name: "FK_MentoresAreas_Mentores_IdMentor",
                table: "MentoresAreas");

            migrationBuilder.DropForeignKey(
                name: "FK_MentoresTecnologias_Mentores_IdMentor",
                table: "MentoresTecnologias");

            migrationBuilder.DropForeignKey(
                name: "FK_MentoresTecnologias_Tecnologias_IdTecnologia",
                table: "MentoresTecnologias");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_NiveisAcesso_IdNivelAcesso",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Anotacoes");

            migrationBuilder.DropTable(
                name: "AvaliacoesMaterial");

            migrationBuilder.DropTable(
                name: "AvaliacoesMentor");

            migrationBuilder.DropTable(
                name: "AvaliacoesMentoria");

            migrationBuilder.DropTable(
                name: "Disponibilidades");

            migrationBuilder.DropTable(
                name: "MateriaisDeApoio");

            migrationBuilder.DropTable(
                name: "Duracoes");

            migrationBuilder.DropTable(
                name: "Mentorias");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Tecnologias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "NiveisAcesso",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "AreasConhecimento",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentorados_Usuarios_IdUsuario",
                table: "Mentorados",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentores_Usuarios_IdUsuario",
                table: "Mentores",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MentoresAreas_AreasConhecimento_IdArea",
                table: "MentoresAreas",
                column: "IdArea",
                principalTable: "AreasConhecimento",
                principalColumn: "IdArea",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MentoresAreas_Mentores_IdMentor",
                table: "MentoresAreas",
                column: "IdMentor",
                principalTable: "Mentores",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MentoresTecnologias_Mentores_IdMentor",
                table: "MentoresTecnologias",
                column: "IdMentor",
                principalTable: "Mentores",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MentoresTecnologias_Tecnologias_IdTecnologia",
                table: "MentoresTecnologias",
                column: "IdTecnologia",
                principalTable: "Tecnologias",
                principalColumn: "IdTecnologia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_NiveisAcesso_IdNivelAcesso",
                table: "Usuarios",
                column: "IdNivelAcesso",
                principalTable: "NiveisAcesso",
                principalColumn: "IdNivelAcesso",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
