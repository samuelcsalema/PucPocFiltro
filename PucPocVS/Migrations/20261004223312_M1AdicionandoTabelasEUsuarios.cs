using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PucPocVS.Migrations
{
    /// <inheritdoc />
    public partial class M1AdicionandoTabelasEUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreasConhecimento",
                columns: table => new
                {
                    IdArea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreasConhecimento", x => x.IdArea);
                });

            migrationBuilder.CreateTable(
                name: "NiveisAcesso",
                columns: table => new
                {
                    IdNivelAcesso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NiveisAcesso", x => x.IdNivelAcesso);
                });

            migrationBuilder.CreateTable(
                name: "Tecnologias",
                columns: table => new
                {
                    IdTecnologia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnologias", x => x.IdTecnologia);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdNivelAcesso = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Escolaridade = table.Column<string>(type: "char(2)", maxLength: 2, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerfilAtivo = table.Column<bool>(type: "bit", nullable: false),
                    AtivoArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_NiveisAcesso_IdNivelAcesso",
                        column: x => x.IdNivelAcesso,
                        principalTable: "NiveisAcesso",
                        principalColumn: "IdNivelAcesso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mentorados",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    AreaInteresse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentorados", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Mentorados_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mentores",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentores", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Mentores_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MentoresAreas",
                columns: table => new
                {
                    IdMentorArea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdArea = table.Column<int>(type: "int", nullable: false),
                    IdMentor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentoresAreas", x => x.IdMentorArea);
                    table.ForeignKey(
                        name: "FK_MentoresAreas_AreasConhecimento_IdArea",
                        column: x => x.IdArea,
                        principalTable: "AreasConhecimento",
                        principalColumn: "IdArea",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MentoresAreas_Mentores_IdMentor",
                        column: x => x.IdMentor,
                        principalTable: "Mentores",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MentoresTecnologias",
                columns: table => new
                {
                    IdMentorTecnologia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTecnologia = table.Column<int>(type: "int", nullable: false),
                    IdMentor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentoresTecnologias", x => x.IdMentorTecnologia);
                    table.ForeignKey(
                        name: "FK_MentoresTecnologias_Mentores_IdMentor",
                        column: x => x.IdMentor,
                        principalTable: "Mentores",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MentoresTecnologias_Tecnologias_IdTecnologia",
                        column: x => x.IdTecnologia,
                        principalTable: "Tecnologias",
                        principalColumn: "IdTecnologia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AreasConhecimento",
                columns: new[] { "IdArea", "Nome" },
                values: new object[,]
                {
                    { 1, "Backend" },
                    { 2, "Frontend" },
                    { 3, "Data Science" },
                    { 4, "Mobile" },
                    { 5, "Fullstack" },
                    { 6, "Cyber Security" }
                });

            migrationBuilder.InsertData(
                table: "NiveisAcesso",
                columns: new[] { "IdNivelAcesso", "Descricao" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Mentor" },
                    { 3, "Mentorado" }
                });

            migrationBuilder.InsertData(
                table: "Tecnologias",
                columns: new[] { "IdTecnologia", "Nome" },
                values: new object[,]
                {
                    { 1, "Python" },
                    { 2, "SQL" },
                    { 3, "HTML" },
                    { 4, "CSS" },
                    { 5, "JavaScript" },
                    { 6, "C#" },
                    { 7, "Java" },
                    { 8, "C++" },
                    { 9, "Go" },
                    { 10, "Rust" },
                    { 11, "Swift" },
                    { 12, "R" },
                    { 13, "PHP" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "AtivoArea", "DataCriacao", "DataNasc", "Email", "Escolaridade", "IdNivelAcesso", "Nome", "PerfilAtivo", "Senha" },
                values: new object[,]
                {
                    { 1, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "carlos@email.com", "PG", 2, "Carlos Silva", true, "SenhaPadrao123" },
                    { 2, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "mariana@email.com", "ES", 2, "Mariana Souza", true, "SenhaPadrao123" },
                    { 3, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "roberto@email.com", "ME", 2, "Roberto Alves", true, "SenhaPadrao123" },
                    { 4, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ana@email.com", "ES", 2, "Ana Clara", true, "SenhaPadrao123" },
                    { 5, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucas@email.com", "DO", 2, "Lucas Mendes", true, "SenhaPadrao123" },
                    { 6, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "beatriz@email.com", "PG", 2, "Beatriz Costa", true, "SenhaPadrao123" },
                    { 7, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "fernando@email.com", "ES", 2, "Fernando Gomes", true, "SenhaPadrao123" },
                    { 8, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "camila@email.com", "ME", 2, "Camila Rocha", true, "SenhaPadrao123" },
                    { 9, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "rafael@email.com", "ES", 2, "Rafael Lima", true, "SenhaPadrao123" },
                    { 10, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "juliana@email.com", "PG", 2, "Juliana Pinto", true, "SenhaPadrao123" },
                    { 11, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "diego@email.com", "ES", 2, "Diego Martins", true, "SenhaPadrao123" },
                    { 12, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "patricia@email.com", "ME", 2, "Patricia Dias", true, "SenhaPadrao123" },
                    { 13, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "gustavo@email.com", "DO", 2, "Gustavo Reis", true, "SenhaPadrao123" },
                    { 14, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "leticia@email.com", "ES", 2, "Leticia Oliveira", true, "SenhaPadrao123" },
                    { 15, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "thiago@email.com", "PG", 2, "Thiago Carvalho", true, "SenhaPadrao123" },
                    { 16, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "amanda@email.com", "ES", 2, "Amanda Farias", true, "SenhaPadrao123" },
                    { 17, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "rodrigo@email.com", "ME", 2, "Rodrigo Nunes", true, "SenhaPadrao123" },
                    { 18, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "fernanda@email.com", "ES", 2, "Fernanda Barros", true, "SenhaPadrao123" },
                    { 19, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "marcelo@email.com", "PG", 2, "Marcelo Moraes", true, "SenhaPadrao123" },
                    { 20, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "carolina@email.com", "ES", 2, "Carolina Azevedo", true, "SenhaPadrao123" }
                });

            migrationBuilder.InsertData(
                table: "Mentorados",
                columns: new[] { "IdUsuario", "AreaInteresse" },
                values: new object[,]
                {
                    { 1, "Backend" },
                    { 2, "Frontend" },
                    { 3, "DevOps" },
                    { 4, "UX/UI Design" },
                    { 5, "Data Science" },
                    { 6, "Mobile iOS" },
                    { 7, "Mobile Android" },
                    { 8, "Gestão de Projetos" },
                    { 9, "Backend" },
                    { 10, "Cloud Computing" },
                    { 11, "Frontend" },
                    { 12, "Engenharia de Dados" },
                    { 13, "Arquitetura de Software" },
                    { 14, "UX/UI Design" },
                    { 15, "Segurança da Informação" },
                    { 16, "QA e Testes" },
                    { 17, "Inteligência Artificial" },
                    { 18, "Marketing Digital" },
                    { 19, "DevOps" },
                    { 20, "Product Management" }
                });

            migrationBuilder.InsertData(
                table: "Mentores",
                column: "IdUsuario",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    11,
                    12,
                    13,
                    14,
                    15,
                    16,
                    17,
                    18,
                    19,
                    20
                });

            migrationBuilder.InsertData(
                table: "MentoresAreas",
                columns: new[] { "IdMentorArea", "IdArea", "IdMentor" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 5, 3 },
                    { 4, 2, 4 },
                    { 5, 3, 5 },
                    { 6, 1, 6 },
                    { 7, 4, 7 },
                    { 8, 5, 8 },
                    { 9, 1, 9 },
                    { 10, 6, 10 },
                    { 11, 4, 11 },
                    { 12, 2, 12 },
                    { 13, 1, 13 },
                    { 14, 3, 14 },
                    { 15, 6, 15 },
                    { 16, 5, 16 },
                    { 17, 3, 17 },
                    { 18, 4, 18 },
                    { 19, 1, 19 },
                    { 20, 2, 20 },
                    { 21, 1, 3 },
                    { 22, 2, 8 }
                });

            migrationBuilder.InsertData(
                table: "MentoresTecnologias",
                columns: new[] { "IdMentorTecnologia", "IdMentor", "IdTecnologia" },
                values: new object[,]
                {
                    { 1, 1, 6 },
                    { 2, 1, 2 },
                    { 3, 6, 1 },
                    { 4, 9, 6 },
                    { 5, 2, 3 },
                    { 6, 2, 4 },
                    { 7, 2, 5 },
                    { 8, 4, 5 },
                    { 9, 3, 6 },
                    { 10, 3, 5 },
                    { 11, 8, 1 },
                    { 12, 8, 5 },
                    { 13, 5, 1 },
                    { 14, 5, 2 },
                    { 15, 10, 1 },
                    { 16, 7, 11 },
                    { 17, 6, 9 },
                    { 18, 11, 11 },
                    { 19, 12, 3 },
                    { 20, 13, 6 },
                    { 21, 14, 1 },
                    { 22, 15, 10 },
                    { 23, 16, 5 },
                    { 24, 17, 12 },
                    { 25, 18, 7 },
                    { 26, 19, 8 },
                    { 27, 20, 3 },
                    { 28, 11, 7 },
                    { 29, 7, 7 },
                    { 30, 9, 13 },
                    { 31, 10, 12 },
                    { 32, 12, 4 },
                    { 33, 13, 8 },
                    { 34, 14, 2 },
                    { 35, 15, 9 },
                    { 36, 16, 13 },
                    { 37, 17, 2 },
                    { 38, 18, 5 },
                    { 39, 19, 13 },
                    { 40, 20, 4 },
                    { 41, 4, 3 },
                    { 42, 20, 5 },
                    { 43, 12, 5 },
                    { 44, 14, 12 },
                    { 45, 10, 2 },
                    { 46, 8, 13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MentoresAreas_IdArea",
                table: "MentoresAreas",
                column: "IdArea");

            migrationBuilder.CreateIndex(
                name: "IX_MentoresAreas_IdMentor",
                table: "MentoresAreas",
                column: "IdMentor");

            migrationBuilder.CreateIndex(
                name: "IX_MentoresTecnologias_IdMentor",
                table: "MentoresTecnologias",
                column: "IdMentor");

            migrationBuilder.CreateIndex(
                name: "IX_MentoresTecnologias_IdTecnologia",
                table: "MentoresTecnologias",
                column: "IdTecnologia");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdNivelAcesso",
                table: "Usuarios",
                column: "IdNivelAcesso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentorados");

            migrationBuilder.DropTable(
                name: "MentoresAreas");

            migrationBuilder.DropTable(
                name: "MentoresTecnologias");

            migrationBuilder.DropTable(
                name: "AreasConhecimento");

            migrationBuilder.DropTable(
                name: "Mentores");

            migrationBuilder.DropTable(
                name: "Tecnologias");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "NiveisAcesso");
        }
    }
}
