using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PucPocVS.Migrations
{
    /// <inheritdoc />
    public partial class M3PopulandoTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Nota",
                table: "AvaliacoesMentoria",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Nota",
                table: "AvaliacoesMentor",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Nota",
                table: "AvaliacoesMaterial",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "AtivoArea", "DataCriacao", "DataNasc", "Email", "Escolaridade", "IdNivelAcesso", "Nome", "PerfilAtivo", "Senha" },
                values: new object[,]
                {
                    { 21, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "joao.pedro@email.com", "MC", 3, "João Pedro Silva", true, "SenhaPadrao123" },
                    { 22, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "carlos.alves@email.com", "SI", 3, "Carlos Alves", true, "SenhaPadrao123" },
                    { 23, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "paulo.henrique@email.com", "MC", 3, "Paulo Henrique", true, "SenhaPadrao123" },
                    { 24, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "camila.soares@email.com", "MC", 3, "Camila Soares", true, "SenhaPadrao123" },
                    { 25, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "jasmin.souza@email.com", "SI", 3, "Jasmin Souza", true, "SenhaPadrao123" },
                    { 26, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "gabriel.martins@email.com", "ES", 3, "Gabriel Martins", true, "SenhaPadrao123" },
                    { 27, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "laura.fernandes@email.com", "MC", 3, "Laura Fernandes", true, "SenhaPadrao123" },
                    { 28, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "matheus.rocha@email.com", "PG", 3, "Matheus Rocha", true, "SenhaPadrao123" },
                    { 29, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "isabela.costa@email.com", "ES", 3, "Isabela Costa", true, "SenhaPadrao123" },
                    { 30, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "pedro.augusto@email.com", "SI", 3, "Pedro Augusto", true, "SenhaPadrao123" },
                    { 31, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "marina.lopes@email.com", "MC", 3, "Marina Lopes", true, "SenhaPadrao123" },
                    { 32, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "andre.luiz@email.com", "PG", 3, "André Luiz", true, "SenhaPadrao123" },
                    { 33, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "beatriz.martins@email.com", "ES", 3, "Beatriz Martins", true, "SenhaPadrao123" },
                    { 34, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel.oliveira@email.com", "SI", 3, "Daniel Oliveira", true, "SenhaPadrao123" },
                    { 35, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "sofia.almeida@email.com", "MC", 3, "Sofia Almeida", true, "SenhaPadrao123" },
                    { 36, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "rafael.moreira@email.com", "PG", 3, "Rafael Moreira", true, "SenhaPadrao123" },
                    { 37, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "clara.mendes@email.com", "ES", 3, "Clara Mendes", true, "SenhaPadrao123" },
                    { 38, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "henrique.castro@email.com", "SI", 3, "Henrique Castro", true, "SenhaPadrao123" },
                    { 39, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice.barbosa@email.com", "MC", 3, "Alice Barbosa", true, "SenhaPadrao123" },
                    { 40, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "bruno.nascimento@email.com", "PG", 3, "Bruno Nascimento", true, "SenhaPadrao123" },
                    { 41, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "manuela.dias@email.com", "ES", 3, "Manuela Dias", true, "SenhaPadrao123" },
                    { 42, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "eduardo.ramos@email.com", "SI", 3, "Eduardo Ramos", true, "SenhaPadrao123" },
                    { 43, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "helena.carvalho@email.com", "MC", 3, "Helena Carvalho", true, "SenhaPadrao123" },
                    { 44, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "felipe.santos@email.com", "PG", 3, "Felipe Santos", true, "SenhaPadrao123" },
                    { 45, "Sim", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "luiza.ferreira@email.com", "ES", 3, "Luiza Ferreira", true, "SenhaPadrao123" }
                });

            migrationBuilder.InsertData(
                table: "Disponibilidades",
                columns: new[] { "IdDisponibilidade", "Disponivel", "HoraInicio", "IdDuracao", "IdMentor" },
                values: new object[,]
                {
                    { 4, true, new DateTime(2025, 1, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 5, true, new DateTime(2025, 2, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 6, false, new DateTime(2025, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 7, true, new DateTime(2025, 1, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 8, true, new DateTime(2025, 2, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 9, false, new DateTime(2025, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 10, true, new DateTime(2025, 1, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 11, true, new DateTime(2025, 2, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 12, false, new DateTime(2025, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 13, true, new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 14, true, new DateTime(2025, 2, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 4 },
                    { 15, false, new DateTime(2025, 3, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 16, true, new DateTime(2025, 1, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 },
                    { 17, true, new DateTime(2025, 2, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 5 },
                    { 18, false, new DateTime(2025, 3, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 19, true, new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 6 },
                    { 20, true, new DateTime(2025, 2, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 6 },
                    { 21, false, new DateTime(2025, 3, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 6 },
                    { 22, true, new DateTime(2025, 1, 17, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 7 },
                    { 23, true, new DateTime(2025, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 7 },
                    { 24, false, new DateTime(2025, 3, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 7 },
                    { 25, true, new DateTime(2025, 1, 18, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 8 },
                    { 26, true, new DateTime(2025, 2, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 8 },
                    { 27, false, new DateTime(2025, 3, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 8 },
                    { 28, true, new DateTime(2025, 1, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 9 },
                    { 29, true, new DateTime(2025, 2, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 9 },
                    { 30, false, new DateTime(2025, 3, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 9 },
                    { 31, true, new DateTime(2025, 1, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 10 },
                    { 32, true, new DateTime(2025, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 10 },
                    { 33, false, new DateTime(2025, 3, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 10 },
                    { 34, true, new DateTime(2025, 1, 21, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 11 },
                    { 35, true, new DateTime(2025, 2, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 11 },
                    { 36, false, new DateTime(2025, 3, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 11 },
                    { 37, true, new DateTime(2025, 1, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 12 },
                    { 38, true, new DateTime(2025, 2, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 12 },
                    { 39, false, new DateTime(2025, 3, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 12 },
                    { 40, true, new DateTime(2025, 1, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 13 },
                    { 41, true, new DateTime(2025, 2, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 13 },
                    { 42, false, new DateTime(2025, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 13 },
                    { 43, true, new DateTime(2025, 1, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 14 },
                    { 44, true, new DateTime(2025, 2, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 14 },
                    { 45, false, new DateTime(2025, 3, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 14 },
                    { 46, true, new DateTime(2025, 1, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 15 },
                    { 47, true, new DateTime(2025, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 15 },
                    { 48, false, new DateTime(2025, 3, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 15 },
                    { 49, true, new DateTime(2025, 1, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 16 },
                    { 50, true, new DateTime(2025, 2, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 16 },
                    { 51, false, new DateTime(2025, 3, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 16 },
                    { 52, true, new DateTime(2025, 1, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 17 },
                    { 53, true, new DateTime(2025, 2, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 17 },
                    { 54, false, new DateTime(2025, 3, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 17 },
                    { 55, true, new DateTime(2025, 1, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 18 },
                    { 56, true, new DateTime(2025, 2, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 18 },
                    { 57, false, new DateTime(2025, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 18 },
                    { 58, true, new DateTime(2025, 1, 29, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 19 },
                    { 59, true, new DateTime(2025, 2, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 19 },
                    { 60, false, new DateTime(2025, 3, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 19 },
                    { 61, true, new DateTime(2025, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 20 },
                    { 62, true, new DateTime(2025, 2, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 20 },
                    { 63, false, new DateTime(2025, 3, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 20 }
                });

            migrationBuilder.InsertData(
                table: "Mentorados",
                columns: new[] { "IdUsuario", "AreaInteresse" },
                values: new object[,]
                {
                    { 21, "Backend" },
                    { 22, "Frontend" },
                    { 23, "Data Science" },
                    { 24, "Mobile" },
                    { 25, "Cyber Security" },
                    { 26, "Backend" },
                    { 27, "Frontend" },
                    { 28, "Fullstack" },
                    { 29, "Data Science" },
                    { 30, "Backend" },
                    { 31, "Mobile" },
                    { 32, "Cyber Security" },
                    { 33, "Frontend" },
                    { 34, "Fullstack" },
                    { 35, "Data Science" },
                    { 36, "Backend" },
                    { 37, "UX/UI Design" },
                    { 38, "Cyber Security" },
                    { 39, "Frontend" },
                    { 40, "Backend" },
                    { 41, "Mobile" },
                    { 42, "Fullstack" },
                    { 43, "Data Science" },
                    { 44, "Backend" },
                    { 45, "Frontend" }
                });

            migrationBuilder.InsertData(
                table: "Mentorias",
                columns: new[] { "IdMentoria", "Descricao", "HoraInicio", "IdMentor", "IdMentorado", "Link", "Status" },
                values: new object[,]
                {
                    { 1, "Introdução e objetivos da mentoria", new DateTime(2025, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, 21, "https://meet.mock.com/mentoria-1", "Concluída" },
                    { 2, "Revisão de fundamentos", new DateTime(2025, 2, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 22, "https://meet.mock.com/mentoria-2", "Concluída" },
                    { 3, "Resolução de exercícios práticos", new DateTime(2025, 3, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, 23, "https://meet.mock.com/mentoria-3", "Concluída" },
                    { 4, "Análise de projeto", new DateTime(2025, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 24, "https://meet.mock.com/mentoria-4", "Concluída" },
                    { 5, "Planejamento dos próximos passos", new DateTime(2025, 5, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, 25, "https://meet.mock.com/mentoria-5", "Concluída" },
                    { 6, "Introdução e objetivos da mentoria", new DateTime(2025, 6, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 26, "https://meet.mock.com/mentoria-6", "Concluída" },
                    { 7, "Revisão de fundamentos", new DateTime(2025, 7, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, 27, "https://meet.mock.com/mentoria-7", "Concluída" },
                    { 8, "Resolução de exercícios práticos", new DateTime(2025, 8, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, 28, "https://meet.mock.com/mentoria-8", "Concluída" },
                    { 9, "Análise de projeto", new DateTime(2025, 9, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, 29, "https://meet.mock.com/mentoria-9", "Concluída" },
                    { 10, "Planejamento dos próximos passos", new DateTime(2025, 10, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, 30, "https://meet.mock.com/mentoria-10", "Concluída" },
                    { 11, "Introdução e objetivos da mentoria", new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), 3, 31, "https://meet.mock.com/mentoria-11", "Concluída" },
                    { 12, "Revisão de fundamentos", new DateTime(2025, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, 32, "https://meet.mock.com/mentoria-12", "Concluída" },
                    { 13, "Resolução de exercícios práticos", new DateTime(2025, 1, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, 33, "https://meet.mock.com/mentoria-13", "Concluída" },
                    { 14, "Análise de projeto", new DateTime(2025, 2, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), 3, 34, "https://meet.mock.com/mentoria-14", "Concluída" },
                    { 15, "Planejamento dos próximos passos", new DateTime(2025, 3, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, 35, "https://meet.mock.com/mentoria-15", "Concluída" },
                    { 16, "Introdução e objetivos da mentoria", new DateTime(2025, 4, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), 4, 36, "https://meet.mock.com/mentoria-16", "Concluída" },
                    { 17, "Revisão de fundamentos", new DateTime(2025, 5, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, 37, "https://meet.mock.com/mentoria-17", "Concluída" },
                    { 18, "Resolução de exercícios práticos", new DateTime(2025, 6, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), 4, 38, "https://meet.mock.com/mentoria-18", "Concluída" },
                    { 19, "Análise de projeto", new DateTime(2025, 7, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, 39, "https://meet.mock.com/mentoria-19", "Concluída" },
                    { 20, "Planejamento dos próximos passos", new DateTime(2025, 8, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 4, 40, "https://meet.mock.com/mentoria-20", "Concluída" },
                    { 21, "Introdução e objetivos da mentoria", new DateTime(2025, 9, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 5, 41, "https://meet.mock.com/mentoria-21", "Concluída" },
                    { 22, "Revisão de fundamentos", new DateTime(2025, 10, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, 42, "https://meet.mock.com/mentoria-22", "Concluída" },
                    { 23, "Resolução de exercícios práticos", new DateTime(2025, 11, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 5, 43, "https://meet.mock.com/mentoria-23", "Concluída" },
                    { 24, "Análise de projeto", new DateTime(2025, 12, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 5, 44, "https://meet.mock.com/mentoria-24", "Concluída" },
                    { 25, "Planejamento dos próximos passos", new DateTime(2025, 1, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 5, 45, "https://meet.mock.com/mentoria-25", "Concluída" },
                    { 26, "Introdução e objetivos da mentoria", new DateTime(2025, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), 6, 21, "https://meet.mock.com/mentoria-26", "Concluída" },
                    { 27, "Revisão de fundamentos", new DateTime(2025, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, 22, "https://meet.mock.com/mentoria-27", "Concluída" },
                    { 28, "Resolução de exercícios práticos", new DateTime(2025, 4, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), 6, 23, "https://meet.mock.com/mentoria-28", "Concluída" },
                    { 29, "Análise de projeto", new DateTime(2025, 5, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 6, 24, "https://meet.mock.com/mentoria-29", "Concluída" },
                    { 30, "Planejamento dos próximos passos", new DateTime(2025, 6, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 6, 25, "https://meet.mock.com/mentoria-30", "Concluída" },
                    { 31, "Introdução e objetivos da mentoria", new DateTime(2025, 7, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), 7, 26, "https://meet.mock.com/mentoria-31", "Concluída" },
                    { 32, "Revisão de fundamentos", new DateTime(2025, 8, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 7, 27, "https://meet.mock.com/mentoria-32", "Concluída" },
                    { 33, "Resolução de exercícios práticos", new DateTime(2025, 9, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 7, 28, "https://meet.mock.com/mentoria-33", "Concluída" },
                    { 34, "Análise de projeto", new DateTime(2025, 10, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), 7, 29, "https://meet.mock.com/mentoria-34", "Concluída" },
                    { 35, "Planejamento dos próximos passos", new DateTime(2025, 11, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), 7, 30, "https://meet.mock.com/mentoria-35", "Concluída" },
                    { 36, "Introdução e objetivos da mentoria", new DateTime(2025, 12, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), 8, 31, "https://meet.mock.com/mentoria-36", "Concluída" },
                    { 37, "Revisão de fundamentos", new DateTime(2025, 1, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 8, 32, "https://meet.mock.com/mentoria-37", "Concluída" },
                    { 38, "Resolução de exercícios práticos", new DateTime(2025, 2, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), 8, 33, "https://meet.mock.com/mentoria-38", "Concluída" },
                    { 39, "Análise de projeto", new DateTime(2025, 3, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 8, 34, "https://meet.mock.com/mentoria-39", "Concluída" },
                    { 40, "Planejamento dos próximos passos", new DateTime(2025, 4, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 8, 35, "https://meet.mock.com/mentoria-40", "Concluída" },
                    { 41, "Introdução e objetivos da mentoria", new DateTime(2025, 5, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 9, 36, "https://meet.mock.com/mentoria-41", "Concluída" },
                    { 42, "Revisão de fundamentos", new DateTime(2025, 6, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 9, 37, "https://meet.mock.com/mentoria-42", "Concluída" },
                    { 43, "Resolução de exercícios práticos", new DateTime(2025, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 9, 38, "https://meet.mock.com/mentoria-43", "Concluída" },
                    { 44, "Análise de projeto", new DateTime(2025, 8, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 9, 39, "https://meet.mock.com/mentoria-44", "Concluída" },
                    { 45, "Planejamento dos próximos passos", new DateTime(2025, 9, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 9, 40, "https://meet.mock.com/mentoria-45", "Concluída" },
                    { 46, "Introdução e objetivos da mentoria", new DateTime(2025, 10, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), 10, 41, "https://meet.mock.com/mentoria-46", "Concluída" },
                    { 47, "Revisão de fundamentos", new DateTime(2025, 11, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 10, 42, "https://meet.mock.com/mentoria-47", "Concluída" },
                    { 48, "Resolução de exercícios práticos", new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), 10, 43, "https://meet.mock.com/mentoria-48", "Concluída" },
                    { 49, "Análise de projeto", new DateTime(2025, 1, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 10, 44, "https://meet.mock.com/mentoria-49", "Concluída" },
                    { 50, "Planejamento dos próximos passos", new DateTime(2025, 2, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 10, 45, "https://meet.mock.com/mentoria-50", "Concluída" },
                    { 51, "Introdução e objetivos da mentoria", new DateTime(2025, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), 11, 21, "https://meet.mock.com/mentoria-51", "Concluída" },
                    { 52, "Revisão de fundamentos", new DateTime(2025, 4, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 11, 22, "https://meet.mock.com/mentoria-52", "Concluída" },
                    { 53, "Resolução de exercícios práticos", new DateTime(2025, 5, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 11, 23, "https://meet.mock.com/mentoria-53", "Concluída" },
                    { 54, "Análise de projeto", new DateTime(2025, 6, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, 24, "https://meet.mock.com/mentoria-54", "Concluída" },
                    { 55, "Planejamento dos próximos passos", new DateTime(2025, 7, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), 11, 25, "https://meet.mock.com/mentoria-55", "Concluída" },
                    { 56, "Introdução e objetivos da mentoria", new DateTime(2025, 8, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), 12, 26, "https://meet.mock.com/mentoria-56", "Concluída" },
                    { 57, "Revisão de fundamentos", new DateTime(2025, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 12, 27, "https://meet.mock.com/mentoria-57", "Concluída" },
                    { 58, "Resolução de exercícios práticos", new DateTime(2025, 10, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), 12, 28, "https://meet.mock.com/mentoria-58", "Concluída" },
                    { 59, "Análise de projeto", new DateTime(2025, 11, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 12, 29, "https://meet.mock.com/mentoria-59", "Concluída" },
                    { 60, "Planejamento dos próximos passos", new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 12, 30, "https://meet.mock.com/mentoria-60", "Concluída" },
                    { 61, "Introdução e objetivos da mentoria", new DateTime(2025, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 13, 31, "https://meet.mock.com/mentoria-61", "Concluída" },
                    { 62, "Revisão de fundamentos", new DateTime(2025, 2, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 13, 32, "https://meet.mock.com/mentoria-62", "Concluída" },
                    { 63, "Resolução de exercícios práticos", new DateTime(2025, 3, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 13, 33, "https://meet.mock.com/mentoria-63", "Concluída" },
                    { 64, "Análise de projeto", new DateTime(2025, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 13, 34, "https://meet.mock.com/mentoria-64", "Concluída" },
                    { 65, "Planejamento dos próximos passos", new DateTime(2025, 5, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 13, 35, "https://meet.mock.com/mentoria-65", "Concluída" },
                    { 66, "Introdução e objetivos da mentoria", new DateTime(2025, 6, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), 14, 36, "https://meet.mock.com/mentoria-66", "Concluída" },
                    { 67, "Revisão de fundamentos", new DateTime(2025, 7, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 14, 37, "https://meet.mock.com/mentoria-67", "Concluída" },
                    { 68, "Resolução de exercícios práticos", new DateTime(2025, 8, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), 14, 38, "https://meet.mock.com/mentoria-68", "Concluída" },
                    { 69, "Análise de projeto", new DateTime(2025, 9, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 14, 39, "https://meet.mock.com/mentoria-69", "Concluída" },
                    { 70, "Planejamento dos próximos passos", new DateTime(2025, 10, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 14, 40, "https://meet.mock.com/mentoria-70", "Concluída" },
                    { 71, "Introdução e objetivos da mentoria", new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), 15, 41, "https://meet.mock.com/mentoria-71", "Concluída" },
                    { 72, "Revisão de fundamentos", new DateTime(2025, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 15, 42, "https://meet.mock.com/mentoria-72", "Concluída" },
                    { 73, "Resolução de exercícios práticos", new DateTime(2025, 1, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 15, 43, "https://meet.mock.com/mentoria-73", "Concluída" },
                    { 74, "Análise de projeto", new DateTime(2025, 2, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), 15, 44, "https://meet.mock.com/mentoria-74", "Concluída" },
                    { 75, "Planejamento dos próximos passos", new DateTime(2025, 3, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), 15, 45, "https://meet.mock.com/mentoria-75", "Concluída" },
                    { 76, "Introdução e objetivos da mentoria", new DateTime(2025, 4, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), 16, 21, "https://meet.mock.com/mentoria-76", "Concluída" },
                    { 77, "Revisão de fundamentos", new DateTime(2025, 5, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 16, 22, "https://meet.mock.com/mentoria-77", "Concluída" },
                    { 78, "Resolução de exercícios práticos", new DateTime(2025, 6, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), 16, 23, "https://meet.mock.com/mentoria-78", "Concluída" },
                    { 79, "Análise de projeto", new DateTime(2025, 7, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 16, 24, "https://meet.mock.com/mentoria-79", "Concluída" },
                    { 80, "Planejamento dos próximos passos", new DateTime(2025, 8, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 16, 25, "https://meet.mock.com/mentoria-80", "Concluída" },
                    { 81, "Introdução e objetivos da mentoria", new DateTime(2025, 9, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 17, 26, "https://meet.mock.com/mentoria-81", "Concluída" },
                    { 82, "Revisão de fundamentos", new DateTime(2025, 10, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 17, 27, "https://meet.mock.com/mentoria-82", "Concluída" },
                    { 83, "Resolução de exercícios práticos", new DateTime(2025, 11, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 17, 28, "https://meet.mock.com/mentoria-83", "Concluída" },
                    { 84, "Análise de projeto", new DateTime(2025, 12, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), 17, 29, "https://meet.mock.com/mentoria-84", "Concluída" },
                    { 85, "Planejamento dos próximos passos", new DateTime(2025, 1, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 17, 30, "https://meet.mock.com/mentoria-85", "Concluída" },
                    { 86, "Introdução e objetivos da mentoria", new DateTime(2025, 2, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), 18, 31, "https://meet.mock.com/mentoria-86", "Concluída" },
                    { 87, "Revisão de fundamentos", new DateTime(2025, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 18, 32, "https://meet.mock.com/mentoria-87", "Concluída" },
                    { 88, "Resolução de exercícios práticos", new DateTime(2025, 4, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, "https://meet.mock.com/mentoria-88", "Concluída" },
                    { 89, "Análise de projeto", new DateTime(2025, 5, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 18, 34, "https://meet.mock.com/mentoria-89", "Concluída" },
                    { 90, "Planejamento dos próximos passos", new DateTime(2025, 6, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 18, 35, "https://meet.mock.com/mentoria-90", "Concluída" },
                    { 91, "Introdução e objetivos da mentoria", new DateTime(2025, 7, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), 19, 36, "https://meet.mock.com/mentoria-91", "Concluída" },
                    { 92, "Revisão de fundamentos", new DateTime(2025, 8, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 19, 37, "https://meet.mock.com/mentoria-92", "Concluída" },
                    { 93, "Resolução de exercícios práticos", new DateTime(2025, 9, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 19, 38, "https://meet.mock.com/mentoria-93", "Concluída" },
                    { 94, "Análise de projeto", new DateTime(2025, 10, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), 19, 39, "https://meet.mock.com/mentoria-94", "Concluída" },
                    { 95, "Planejamento dos próximos passos", new DateTime(2025, 11, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), 19, 40, "https://meet.mock.com/mentoria-95", "Concluída" },
                    { 96, "Introdução e objetivos da mentoria", new DateTime(2025, 12, 16, 9, 0, 0, 0, DateTimeKind.Unspecified), 20, 41, "https://meet.mock.com/mentoria-96", "Concluída" },
                    { 97, "Revisão de fundamentos", new DateTime(2025, 1, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 20, 42, "https://meet.mock.com/mentoria-97", "Concluída" },
                    { 98, "Resolução de exercícios práticos", new DateTime(2025, 2, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), 20, 43, "https://meet.mock.com/mentoria-98", "Concluída" },
                    { 99, "Análise de projeto", new DateTime(2025, 3, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), 20, 44, "https://meet.mock.com/mentoria-99", "Concluída" },
                    { 100, "Planejamento dos próximos passos", new DateTime(2025, 4, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 20, 45, "https://meet.mock.com/mentoria-100", "Concluída" }
                });

            migrationBuilder.InsertData(
                table: "Anotacoes",
                columns: new[] { "IdAnotacao", "AnotacaoMentorado", "IdMentorado", "IdMentoria" },
                values: new object[,]
                {
                    { 1, "Anotação do mentorado referente à mentoria 1.", 21, 1 },
                    { 2, "Anotação do mentorado referente à mentoria 2.", 22, 2 },
                    { 3, "Anotação do mentorado referente à mentoria 3.", 23, 3 },
                    { 4, "Anotação do mentorado referente à mentoria 4.", 24, 4 },
                    { 5, "Anotação do mentorado referente à mentoria 5.", 25, 5 },
                    { 6, "Anotação do mentorado referente à mentoria 6.", 26, 6 },
                    { 7, "Anotação do mentorado referente à mentoria 7.", 27, 7 },
                    { 8, "Anotação do mentorado referente à mentoria 8.", 28, 8 },
                    { 9, "Anotação do mentorado referente à mentoria 9.", 29, 9 },
                    { 10, "Anotação do mentorado referente à mentoria 10.", 30, 10 },
                    { 11, "Anotação do mentorado referente à mentoria 11.", 31, 11 },
                    { 12, "Anotação do mentorado referente à mentoria 12.", 32, 12 },
                    { 13, "Anotação do mentorado referente à mentoria 13.", 33, 13 },
                    { 14, "Anotação do mentorado referente à mentoria 14.", 34, 14 },
                    { 15, "Anotação do mentorado referente à mentoria 15.", 35, 15 },
                    { 16, "Anotação do mentorado referente à mentoria 16.", 36, 16 },
                    { 17, "Anotação do mentorado referente à mentoria 17.", 37, 17 },
                    { 18, "Anotação do mentorado referente à mentoria 18.", 38, 18 },
                    { 19, "Anotação do mentorado referente à mentoria 19.", 39, 19 },
                    { 20, "Anotação do mentorado referente à mentoria 20.", 40, 20 },
                    { 21, "Anotação do mentorado referente à mentoria 21.", 41, 21 },
                    { 22, "Anotação do mentorado referente à mentoria 22.", 42, 22 },
                    { 23, "Anotação do mentorado referente à mentoria 23.", 43, 23 },
                    { 24, "Anotação do mentorado referente à mentoria 24.", 44, 24 },
                    { 25, "Anotação do mentorado referente à mentoria 25.", 45, 25 },
                    { 26, "Anotação do mentorado referente à mentoria 26.", 21, 26 },
                    { 27, "Anotação do mentorado referente à mentoria 27.", 22, 27 },
                    { 28, "Anotação do mentorado referente à mentoria 28.", 23, 28 },
                    { 29, "Anotação do mentorado referente à mentoria 29.", 24, 29 },
                    { 30, "Anotação do mentorado referente à mentoria 30.", 25, 30 },
                    { 31, "Anotação do mentorado referente à mentoria 31.", 26, 31 },
                    { 32, "Anotação do mentorado referente à mentoria 32.", 27, 32 },
                    { 33, "Anotação do mentorado referente à mentoria 33.", 28, 33 },
                    { 34, "Anotação do mentorado referente à mentoria 34.", 29, 34 },
                    { 35, "Anotação do mentorado referente à mentoria 35.", 30, 35 },
                    { 36, "Anotação do mentorado referente à mentoria 36.", 31, 36 },
                    { 37, "Anotação do mentorado referente à mentoria 37.", 32, 37 },
                    { 38, "Anotação do mentorado referente à mentoria 38.", 33, 38 },
                    { 39, "Anotação do mentorado referente à mentoria 39.", 34, 39 },
                    { 40, "Anotação do mentorado referente à mentoria 40.", 35, 40 },
                    { 41, "Anotação do mentorado referente à mentoria 41.", 36, 41 },
                    { 42, "Anotação do mentorado referente à mentoria 42.", 37, 42 },
                    { 43, "Anotação do mentorado referente à mentoria 43.", 38, 43 },
                    { 44, "Anotação do mentorado referente à mentoria 44.", 39, 44 },
                    { 45, "Anotação do mentorado referente à mentoria 45.", 40, 45 },
                    { 46, "Anotação do mentorado referente à mentoria 46.", 41, 46 },
                    { 47, "Anotação do mentorado referente à mentoria 47.", 42, 47 },
                    { 48, "Anotação do mentorado referente à mentoria 48.", 43, 48 },
                    { 49, "Anotação do mentorado referente à mentoria 49.", 44, 49 },
                    { 50, "Anotação do mentorado referente à mentoria 50.", 45, 50 },
                    { 51, "Anotação do mentorado referente à mentoria 51.", 21, 51 },
                    { 52, "Anotação do mentorado referente à mentoria 52.", 22, 52 },
                    { 53, "Anotação do mentorado referente à mentoria 53.", 23, 53 },
                    { 54, "Anotação do mentorado referente à mentoria 54.", 24, 54 },
                    { 55, "Anotação do mentorado referente à mentoria 55.", 25, 55 },
                    { 56, "Anotação do mentorado referente à mentoria 56.", 26, 56 },
                    { 57, "Anotação do mentorado referente à mentoria 57.", 27, 57 },
                    { 58, "Anotação do mentorado referente à mentoria 58.", 28, 58 },
                    { 59, "Anotação do mentorado referente à mentoria 59.", 29, 59 },
                    { 60, "Anotação do mentorado referente à mentoria 60.", 30, 60 },
                    { 61, "Anotação do mentorado referente à mentoria 61.", 31, 61 },
                    { 62, "Anotação do mentorado referente à mentoria 62.", 32, 62 },
                    { 63, "Anotação do mentorado referente à mentoria 63.", 33, 63 },
                    { 64, "Anotação do mentorado referente à mentoria 64.", 34, 64 },
                    { 65, "Anotação do mentorado referente à mentoria 65.", 35, 65 },
                    { 66, "Anotação do mentorado referente à mentoria 66.", 36, 66 },
                    { 67, "Anotação do mentorado referente à mentoria 67.", 37, 67 },
                    { 68, "Anotação do mentorado referente à mentoria 68.", 38, 68 },
                    { 69, "Anotação do mentorado referente à mentoria 69.", 39, 69 },
                    { 70, "Anotação do mentorado referente à mentoria 70.", 40, 70 },
                    { 71, "Anotação do mentorado referente à mentoria 71.", 41, 71 },
                    { 72, "Anotação do mentorado referente à mentoria 72.", 42, 72 },
                    { 73, "Anotação do mentorado referente à mentoria 73.", 43, 73 },
                    { 74, "Anotação do mentorado referente à mentoria 74.", 44, 74 },
                    { 75, "Anotação do mentorado referente à mentoria 75.", 45, 75 },
                    { 76, "Anotação do mentorado referente à mentoria 76.", 21, 76 },
                    { 77, "Anotação do mentorado referente à mentoria 77.", 22, 77 },
                    { 78, "Anotação do mentorado referente à mentoria 78.", 23, 78 },
                    { 79, "Anotação do mentorado referente à mentoria 79.", 24, 79 },
                    { 80, "Anotação do mentorado referente à mentoria 80.", 25, 80 },
                    { 81, "Anotação do mentorado referente à mentoria 81.", 26, 81 },
                    { 82, "Anotação do mentorado referente à mentoria 82.", 27, 82 },
                    { 83, "Anotação do mentorado referente à mentoria 83.", 28, 83 },
                    { 84, "Anotação do mentorado referente à mentoria 84.", 29, 84 },
                    { 85, "Anotação do mentorado referente à mentoria 85.", 30, 85 },
                    { 86, "Anotação do mentorado referente à mentoria 86.", 31, 86 },
                    { 87, "Anotação do mentorado referente à mentoria 87.", 32, 87 },
                    { 88, "Anotação do mentorado referente à mentoria 88.", 33, 88 },
                    { 89, "Anotação do mentorado referente à mentoria 89.", 34, 89 },
                    { 90, "Anotação do mentorado referente à mentoria 90.", 35, 90 },
                    { 91, "Anotação do mentorado referente à mentoria 91.", 36, 91 },
                    { 92, "Anotação do mentorado referente à mentoria 92.", 37, 92 },
                    { 93, "Anotação do mentorado referente à mentoria 93.", 38, 93 },
                    { 94, "Anotação do mentorado referente à mentoria 94.", 39, 94 },
                    { 95, "Anotação do mentorado referente à mentoria 95.", 40, 95 },
                    { 96, "Anotação do mentorado referente à mentoria 96.", 41, 96 },
                    { 97, "Anotação do mentorado referente à mentoria 97.", 42, 97 },
                    { 98, "Anotação do mentorado referente à mentoria 98.", 43, 98 },
                    { 99, "Anotação do mentorado referente à mentoria 99.", 44, 99 },
                    { 100, "Anotação do mentorado referente à mentoria 100.", 45, 100 }
                });

            migrationBuilder.InsertData(
                table: "AvaliacoesMentor",
                columns: new[] { "IdAvaliacaoMentor", "Comentario", "IdMentor", "IdMentorado", "IdMentoria", "Nota" },
                values: new object[,]
                {
                    { 1, "Avaliação do mentor 1.", 1, 21, 1, 3.0m },
                    { 2, "Avaliação do mentor 1.", 1, 22, 2, 3.5m },
                    { 3, "Avaliação do mentor 1.", 1, 23, 3, 4.0m },
                    { 4, "Avaliação do mentor 1.", 1, 24, 4, 4.5m },
                    { 5, "Avaliação do mentor 1.", 1, 25, 5, 5.0m },
                    { 6, "Avaliação do mentor 2.", 2, 26, 6, 3.0m },
                    { 7, "Avaliação do mentor 2.", 2, 27, 7, 3.5m },
                    { 8, "Avaliação do mentor 2.", 2, 28, 8, 4.0m },
                    { 9, "Avaliação do mentor 2.", 2, 29, 9, 4.5m },
                    { 10, "Avaliação do mentor 2.", 2, 30, 10, 5.0m },
                    { 11, "Avaliação do mentor 3.", 3, 31, 11, 3.0m },
                    { 12, "Avaliação do mentor 3.", 3, 32, 12, 3.5m },
                    { 13, "Avaliação do mentor 3.", 3, 33, 13, 4.0m },
                    { 14, "Avaliação do mentor 3.", 3, 34, 14, 4.5m },
                    { 15, "Avaliação do mentor 3.", 3, 35, 15, 5.0m },
                    { 16, "Avaliação do mentor 4.", 4, 36, 16, 3.0m },
                    { 17, "Avaliação do mentor 4.", 4, 37, 17, 3.5m },
                    { 18, "Avaliação do mentor 4.", 4, 38, 18, 4.0m },
                    { 19, "Avaliação do mentor 4.", 4, 39, 19, 4.5m },
                    { 20, "Avaliação do mentor 4.", 4, 40, 20, 5.0m },
                    { 21, "Avaliação do mentor 5.", 5, 41, 21, 3.0m },
                    { 22, "Avaliação do mentor 5.", 5, 42, 22, 3.5m },
                    { 23, "Avaliação do mentor 5.", 5, 43, 23, 4.0m },
                    { 24, "Avaliação do mentor 5.", 5, 44, 24, 4.5m },
                    { 25, "Avaliação do mentor 5.", 5, 45, 25, 5.0m },
                    { 26, "Avaliação do mentor 6.", 6, 21, 26, 3.0m },
                    { 27, "Avaliação do mentor 6.", 6, 22, 27, 3.5m },
                    { 28, "Avaliação do mentor 6.", 6, 23, 28, 4.0m },
                    { 29, "Avaliação do mentor 6.", 6, 24, 29, 4.5m },
                    { 30, "Avaliação do mentor 6.", 6, 25, 30, 5.0m },
                    { 31, "Avaliação do mentor 7.", 7, 26, 31, 3.0m },
                    { 32, "Avaliação do mentor 7.", 7, 27, 32, 3.5m },
                    { 33, "Avaliação do mentor 7.", 7, 28, 33, 4.0m },
                    { 34, "Avaliação do mentor 7.", 7, 29, 34, 4.5m },
                    { 35, "Avaliação do mentor 7.", 7, 30, 35, 5.0m },
                    { 36, "Avaliação do mentor 8.", 8, 31, 36, 3.0m },
                    { 37, "Avaliação do mentor 8.", 8, 32, 37, 3.5m },
                    { 38, "Avaliação do mentor 8.", 8, 33, 38, 4.0m },
                    { 39, "Avaliação do mentor 8.", 8, 34, 39, 4.5m },
                    { 40, "Avaliação do mentor 8.", 8, 35, 40, 5.0m },
                    { 41, "Avaliação do mentor 9.", 9, 36, 41, 3.0m },
                    { 42, "Avaliação do mentor 9.", 9, 37, 42, 3.5m },
                    { 43, "Avaliação do mentor 9.", 9, 38, 43, 4.0m },
                    { 44, "Avaliação do mentor 9.", 9, 39, 44, 4.5m },
                    { 45, "Avaliação do mentor 9.", 9, 40, 45, 5.0m },
                    { 46, "Avaliação do mentor 10.", 10, 41, 46, 3.0m },
                    { 47, "Avaliação do mentor 10.", 10, 42, 47, 3.5m },
                    { 48, "Avaliação do mentor 10.", 10, 43, 48, 4.0m },
                    { 49, "Avaliação do mentor 10.", 10, 44, 49, 4.5m },
                    { 50, "Avaliação do mentor 10.", 10, 45, 50, 5.0m },
                    { 51, "Avaliação do mentor 11.", 11, 21, 51, 3.0m },
                    { 52, "Avaliação do mentor 11.", 11, 22, 52, 3.5m },
                    { 53, "Avaliação do mentor 11.", 11, 23, 53, 4.0m },
                    { 54, "Avaliação do mentor 11.", 11, 24, 54, 4.5m },
                    { 55, "Avaliação do mentor 11.", 11, 25, 55, 5.0m },
                    { 56, "Avaliação do mentor 12.", 12, 26, 56, 3.0m },
                    { 57, "Avaliação do mentor 12.", 12, 27, 57, 3.5m },
                    { 58, "Avaliação do mentor 12.", 12, 28, 58, 4.0m },
                    { 59, "Avaliação do mentor 12.", 12, 29, 59, 4.5m },
                    { 60, "Avaliação do mentor 12.", 12, 30, 60, 5.0m },
                    { 61, "Avaliação do mentor 13.", 13, 31, 61, 3.0m },
                    { 62, "Avaliação do mentor 13.", 13, 32, 62, 3.5m },
                    { 63, "Avaliação do mentor 13.", 13, 33, 63, 4.0m },
                    { 64, "Avaliação do mentor 13.", 13, 34, 64, 4.5m },
                    { 65, "Avaliação do mentor 13.", 13, 35, 65, 5.0m },
                    { 66, "Avaliação do mentor 14.", 14, 36, 66, 3.0m },
                    { 67, "Avaliação do mentor 14.", 14, 37, 67, 3.5m },
                    { 68, "Avaliação do mentor 14.", 14, 38, 68, 4.0m },
                    { 69, "Avaliação do mentor 14.", 14, 39, 69, 4.5m },
                    { 70, "Avaliação do mentor 14.", 14, 40, 70, 5.0m },
                    { 71, "Avaliação do mentor 15.", 15, 41, 71, 3.0m },
                    { 72, "Avaliação do mentor 15.", 15, 42, 72, 3.5m },
                    { 73, "Avaliação do mentor 15.", 15, 43, 73, 4.0m },
                    { 74, "Avaliação do mentor 15.", 15, 44, 74, 4.5m },
                    { 75, "Avaliação do mentor 15.", 15, 45, 75, 5.0m },
                    { 76, "Avaliação do mentor 16.", 16, 21, 76, 3.0m },
                    { 77, "Avaliação do mentor 16.", 16, 22, 77, 3.5m },
                    { 78, "Avaliação do mentor 16.", 16, 23, 78, 4.0m },
                    { 79, "Avaliação do mentor 16.", 16, 24, 79, 4.5m },
                    { 80, "Avaliação do mentor 16.", 16, 25, 80, 5.0m },
                    { 81, "Avaliação do mentor 17.", 17, 26, 81, 3.0m },
                    { 82, "Avaliação do mentor 17.", 17, 27, 82, 3.5m },
                    { 83, "Avaliação do mentor 17.", 17, 28, 83, 4.0m },
                    { 84, "Avaliação do mentor 17.", 17, 29, 84, 4.5m },
                    { 85, "Avaliação do mentor 17.", 17, 30, 85, 5.0m },
                    { 86, "Avaliação do mentor 18.", 18, 31, 86, 3.0m },
                    { 87, "Avaliação do mentor 18.", 18, 32, 87, 3.5m },
                    { 88, "Avaliação do mentor 18.", 18, 33, 88, 4.0m },
                    { 89, "Avaliação do mentor 18.", 18, 34, 89, 4.5m },
                    { 90, "Avaliação do mentor 18.", 18, 35, 90, 5.0m },
                    { 91, "Avaliação do mentor 19.", 19, 36, 91, 3.0m },
                    { 92, "Avaliação do mentor 19.", 19, 37, 92, 3.5m },
                    { 93, "Avaliação do mentor 19.", 19, 38, 93, 4.0m },
                    { 94, "Avaliação do mentor 19.", 19, 39, 94, 4.5m },
                    { 95, "Avaliação do mentor 19.", 19, 40, 95, 5.0m },
                    { 96, "Avaliação do mentor 20.", 20, 41, 96, 3.0m },
                    { 97, "Avaliação do mentor 20.", 20, 42, 97, 3.5m },
                    { 98, "Avaliação do mentor 20.", 20, 43, 98, 4.0m },
                    { 99, "Avaliação do mentor 20.", 20, 44, 99, 4.5m },
                    { 100, "Avaliação do mentor 20.", 20, 45, 100, 5.0m }
                });

            migrationBuilder.InsertData(
                table: "AvaliacoesMentoria",
                columns: new[] { "IdAvaliacaoMentoria", "Comentario", "IdMentorado", "IdMentoria", "Nota" },
                values: new object[,]
                {
                    { 1, "Avaliação da mentoria 1.", 21, 1, 3.0m },
                    { 2, "Avaliação da mentoria 2.", 22, 2, 3.5m },
                    { 3, "Avaliação da mentoria 3.", 23, 3, 4.0m },
                    { 4, "Avaliação da mentoria 4.", 24, 4, 4.5m },
                    { 5, "Avaliação da mentoria 5.", 25, 5, 5.0m },
                    { 6, "Avaliação da mentoria 6.", 26, 6, 3.0m },
                    { 7, "Avaliação da mentoria 7.", 27, 7, 3.5m },
                    { 8, "Avaliação da mentoria 8.", 28, 8, 4.0m },
                    { 9, "Avaliação da mentoria 9.", 29, 9, 4.5m },
                    { 10, "Avaliação da mentoria 10.", 30, 10, 5.0m },
                    { 11, "Avaliação da mentoria 11.", 31, 11, 3.0m },
                    { 12, "Avaliação da mentoria 12.", 32, 12, 3.5m },
                    { 13, "Avaliação da mentoria 13.", 33, 13, 4.0m },
                    { 14, "Avaliação da mentoria 14.", 34, 14, 4.5m },
                    { 15, "Avaliação da mentoria 15.", 35, 15, 5.0m },
                    { 16, "Avaliação da mentoria 16.", 36, 16, 3.0m },
                    { 17, "Avaliação da mentoria 17.", 37, 17, 3.5m },
                    { 18, "Avaliação da mentoria 18.", 38, 18, 4.0m },
                    { 19, "Avaliação da mentoria 19.", 39, 19, 4.5m },
                    { 20, "Avaliação da mentoria 20.", 40, 20, 5.0m },
                    { 21, "Avaliação da mentoria 21.", 41, 21, 3.0m },
                    { 22, "Avaliação da mentoria 22.", 42, 22, 3.5m },
                    { 23, "Avaliação da mentoria 23.", 43, 23, 4.0m },
                    { 24, "Avaliação da mentoria 24.", 44, 24, 4.5m },
                    { 25, "Avaliação da mentoria 25.", 45, 25, 5.0m },
                    { 26, "Avaliação da mentoria 26.", 21, 26, 3.0m },
                    { 27, "Avaliação da mentoria 27.", 22, 27, 3.5m },
                    { 28, "Avaliação da mentoria 28.", 23, 28, 4.0m },
                    { 29, "Avaliação da mentoria 29.", 24, 29, 4.5m },
                    { 30, "Avaliação da mentoria 30.", 25, 30, 5.0m },
                    { 31, "Avaliação da mentoria 31.", 26, 31, 3.0m },
                    { 32, "Avaliação da mentoria 32.", 27, 32, 3.5m },
                    { 33, "Avaliação da mentoria 33.", 28, 33, 4.0m },
                    { 34, "Avaliação da mentoria 34.", 29, 34, 4.5m },
                    { 35, "Avaliação da mentoria 35.", 30, 35, 5.0m },
                    { 36, "Avaliação da mentoria 36.", 31, 36, 3.0m },
                    { 37, "Avaliação da mentoria 37.", 32, 37, 3.5m },
                    { 38, "Avaliação da mentoria 38.", 33, 38, 4.0m },
                    { 39, "Avaliação da mentoria 39.", 34, 39, 4.5m },
                    { 40, "Avaliação da mentoria 40.", 35, 40, 5.0m },
                    { 41, "Avaliação da mentoria 41.", 36, 41, 3.0m },
                    { 42, "Avaliação da mentoria 42.", 37, 42, 3.5m },
                    { 43, "Avaliação da mentoria 43.", 38, 43, 4.0m },
                    { 44, "Avaliação da mentoria 44.", 39, 44, 4.5m },
                    { 45, "Avaliação da mentoria 45.", 40, 45, 5.0m },
                    { 46, "Avaliação da mentoria 46.", 41, 46, 3.0m },
                    { 47, "Avaliação da mentoria 47.", 42, 47, 3.5m },
                    { 48, "Avaliação da mentoria 48.", 43, 48, 4.0m },
                    { 49, "Avaliação da mentoria 49.", 44, 49, 4.5m },
                    { 50, "Avaliação da mentoria 50.", 45, 50, 5.0m },
                    { 51, "Avaliação da mentoria 51.", 21, 51, 3.0m },
                    { 52, "Avaliação da mentoria 52.", 22, 52, 3.5m },
                    { 53, "Avaliação da mentoria 53.", 23, 53, 4.0m },
                    { 54, "Avaliação da mentoria 54.", 24, 54, 4.5m },
                    { 55, "Avaliação da mentoria 55.", 25, 55, 5.0m },
                    { 56, "Avaliação da mentoria 56.", 26, 56, 3.0m },
                    { 57, "Avaliação da mentoria 57.", 27, 57, 3.5m },
                    { 58, "Avaliação da mentoria 58.", 28, 58, 4.0m },
                    { 59, "Avaliação da mentoria 59.", 29, 59, 4.5m },
                    { 60, "Avaliação da mentoria 60.", 30, 60, 5.0m },
                    { 61, "Avaliação da mentoria 61.", 31, 61, 3.0m },
                    { 62, "Avaliação da mentoria 62.", 32, 62, 3.5m },
                    { 63, "Avaliação da mentoria 63.", 33, 63, 4.0m },
                    { 64, "Avaliação da mentoria 64.", 34, 64, 4.5m },
                    { 65, "Avaliação da mentoria 65.", 35, 65, 5.0m },
                    { 66, "Avaliação da mentoria 66.", 36, 66, 3.0m },
                    { 67, "Avaliação da mentoria 67.", 37, 67, 3.5m },
                    { 68, "Avaliação da mentoria 68.", 38, 68, 4.0m },
                    { 69, "Avaliação da mentoria 69.", 39, 69, 4.5m },
                    { 70, "Avaliação da mentoria 70.", 40, 70, 5.0m },
                    { 71, "Avaliação da mentoria 71.", 41, 71, 3.0m },
                    { 72, "Avaliação da mentoria 72.", 42, 72, 3.5m },
                    { 73, "Avaliação da mentoria 73.", 43, 73, 4.0m },
                    { 74, "Avaliação da mentoria 74.", 44, 74, 4.5m },
                    { 75, "Avaliação da mentoria 75.", 45, 75, 5.0m },
                    { 76, "Avaliação da mentoria 76.", 21, 76, 3.0m },
                    { 77, "Avaliação da mentoria 77.", 22, 77, 3.5m },
                    { 78, "Avaliação da mentoria 78.", 23, 78, 4.0m },
                    { 79, "Avaliação da mentoria 79.", 24, 79, 4.5m },
                    { 80, "Avaliação da mentoria 80.", 25, 80, 5.0m },
                    { 81, "Avaliação da mentoria 81.", 26, 81, 3.0m },
                    { 82, "Avaliação da mentoria 82.", 27, 82, 3.5m },
                    { 83, "Avaliação da mentoria 83.", 28, 83, 4.0m },
                    { 84, "Avaliação da mentoria 84.", 29, 84, 4.5m },
                    { 85, "Avaliação da mentoria 85.", 30, 85, 5.0m },
                    { 86, "Avaliação da mentoria 86.", 31, 86, 3.0m },
                    { 87, "Avaliação da mentoria 87.", 32, 87, 3.5m },
                    { 88, "Avaliação da mentoria 88.", 33, 88, 4.0m },
                    { 89, "Avaliação da mentoria 89.", 34, 89, 4.5m },
                    { 90, "Avaliação da mentoria 90.", 35, 90, 5.0m },
                    { 91, "Avaliação da mentoria 91.", 36, 91, 3.0m },
                    { 92, "Avaliação da mentoria 92.", 37, 92, 3.5m },
                    { 93, "Avaliação da mentoria 93.", 38, 93, 4.0m },
                    { 94, "Avaliação da mentoria 94.", 39, 94, 4.5m },
                    { 95, "Avaliação da mentoria 95.", 40, 95, 5.0m },
                    { 96, "Avaliação da mentoria 96.", 41, 96, 3.0m },
                    { 97, "Avaliação da mentoria 97.", 42, 97, 3.5m },
                    { 98, "Avaliação da mentoria 98.", 43, 98, 4.0m },
                    { 99, "Avaliação da mentoria 99.", 44, 99, 4.5m },
                    { 100, "Avaliação da mentoria 100.", 45, 100, 5.0m }
                });

            migrationBuilder.InsertData(
                table: "MateriaisDeApoio",
                columns: new[] { "IdMaterialApoio", "IdMentor", "IdMentoria", "Material", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, 1, "https://materiais.mock.com/material-1", "Material de Apoio 1" },
                    { 2, 1, 2, "https://materiais.mock.com/material-2", "Material de Apoio 2" },
                    { 3, 1, 3, "https://materiais.mock.com/material-3", "Material de Apoio 3" },
                    { 4, 1, 4, "https://materiais.mock.com/material-4", "Material de Apoio 4" },
                    { 5, 1, 5, "https://materiais.mock.com/material-5", "Material de Apoio 5" },
                    { 6, 2, 6, "https://materiais.mock.com/material-6", "Material de Apoio 6" },
                    { 7, 2, 7, "https://materiais.mock.com/material-7", "Material de Apoio 7" },
                    { 8, 2, 8, "https://materiais.mock.com/material-8", "Material de Apoio 8" },
                    { 9, 2, 9, "https://materiais.mock.com/material-9", "Material de Apoio 9" },
                    { 10, 2, 10, "https://materiais.mock.com/material-10", "Material de Apoio 10" },
                    { 11, 3, 11, "https://materiais.mock.com/material-11", "Material de Apoio 11" },
                    { 12, 3, 12, "https://materiais.mock.com/material-12", "Material de Apoio 12" },
                    { 13, 3, 13, "https://materiais.mock.com/material-13", "Material de Apoio 13" },
                    { 14, 3, 14, "https://materiais.mock.com/material-14", "Material de Apoio 14" },
                    { 15, 3, 15, "https://materiais.mock.com/material-15", "Material de Apoio 15" },
                    { 16, 4, 16, "https://materiais.mock.com/material-16", "Material de Apoio 16" },
                    { 17, 4, 17, "https://materiais.mock.com/material-17", "Material de Apoio 17" },
                    { 18, 4, 18, "https://materiais.mock.com/material-18", "Material de Apoio 18" },
                    { 19, 4, 19, "https://materiais.mock.com/material-19", "Material de Apoio 19" },
                    { 20, 4, 20, "https://materiais.mock.com/material-20", "Material de Apoio 20" },
                    { 21, 5, 21, "https://materiais.mock.com/material-21", "Material de Apoio 21" },
                    { 22, 5, 22, "https://materiais.mock.com/material-22", "Material de Apoio 22" },
                    { 23, 5, 23, "https://materiais.mock.com/material-23", "Material de Apoio 23" },
                    { 24, 5, 24, "https://materiais.mock.com/material-24", "Material de Apoio 24" },
                    { 25, 5, 25, "https://materiais.mock.com/material-25", "Material de Apoio 25" },
                    { 26, 6, 26, "https://materiais.mock.com/material-26", "Material de Apoio 26" },
                    { 27, 6, 27, "https://materiais.mock.com/material-27", "Material de Apoio 27" },
                    { 28, 6, 28, "https://materiais.mock.com/material-28", "Material de Apoio 28" },
                    { 29, 6, 29, "https://materiais.mock.com/material-29", "Material de Apoio 29" },
                    { 30, 6, 30, "https://materiais.mock.com/material-30", "Material de Apoio 30" },
                    { 31, 7, 31, "https://materiais.mock.com/material-31", "Material de Apoio 31" },
                    { 32, 7, 32, "https://materiais.mock.com/material-32", "Material de Apoio 32" },
                    { 33, 7, 33, "https://materiais.mock.com/material-33", "Material de Apoio 33" },
                    { 34, 7, 34, "https://materiais.mock.com/material-34", "Material de Apoio 34" },
                    { 35, 7, 35, "https://materiais.mock.com/material-35", "Material de Apoio 35" },
                    { 36, 8, 36, "https://materiais.mock.com/material-36", "Material de Apoio 36" },
                    { 37, 8, 37, "https://materiais.mock.com/material-37", "Material de Apoio 37" },
                    { 38, 8, 38, "https://materiais.mock.com/material-38", "Material de Apoio 38" },
                    { 39, 8, 39, "https://materiais.mock.com/material-39", "Material de Apoio 39" },
                    { 40, 8, 40, "https://materiais.mock.com/material-40", "Material de Apoio 40" },
                    { 41, 9, 41, "https://materiais.mock.com/material-41", "Material de Apoio 41" },
                    { 42, 9, 42, "https://materiais.mock.com/material-42", "Material de Apoio 42" },
                    { 43, 9, 43, "https://materiais.mock.com/material-43", "Material de Apoio 43" },
                    { 44, 9, 44, "https://materiais.mock.com/material-44", "Material de Apoio 44" },
                    { 45, 9, 45, "https://materiais.mock.com/material-45", "Material de Apoio 45" },
                    { 46, 10, 46, "https://materiais.mock.com/material-46", "Material de Apoio 46" },
                    { 47, 10, 47, "https://materiais.mock.com/material-47", "Material de Apoio 47" },
                    { 48, 10, 48, "https://materiais.mock.com/material-48", "Material de Apoio 48" },
                    { 49, 10, 49, "https://materiais.mock.com/material-49", "Material de Apoio 49" },
                    { 50, 10, 50, "https://materiais.mock.com/material-50", "Material de Apoio 50" },
                    { 51, 11, 51, "https://materiais.mock.com/material-51", "Material de Apoio 51" },
                    { 52, 11, 52, "https://materiais.mock.com/material-52", "Material de Apoio 52" },
                    { 53, 11, 53, "https://materiais.mock.com/material-53", "Material de Apoio 53" },
                    { 54, 11, 54, "https://materiais.mock.com/material-54", "Material de Apoio 54" },
                    { 55, 11, 55, "https://materiais.mock.com/material-55", "Material de Apoio 55" },
                    { 56, 12, 56, "https://materiais.mock.com/material-56", "Material de Apoio 56" },
                    { 57, 12, 57, "https://materiais.mock.com/material-57", "Material de Apoio 57" },
                    { 58, 12, 58, "https://materiais.mock.com/material-58", "Material de Apoio 58" },
                    { 59, 12, 59, "https://materiais.mock.com/material-59", "Material de Apoio 59" },
                    { 60, 12, 60, "https://materiais.mock.com/material-60", "Material de Apoio 60" },
                    { 61, 13, 61, "https://materiais.mock.com/material-61", "Material de Apoio 61" },
                    { 62, 13, 62, "https://materiais.mock.com/material-62", "Material de Apoio 62" },
                    { 63, 13, 63, "https://materiais.mock.com/material-63", "Material de Apoio 63" },
                    { 64, 13, 64, "https://materiais.mock.com/material-64", "Material de Apoio 64" },
                    { 65, 13, 65, "https://materiais.mock.com/material-65", "Material de Apoio 65" },
                    { 66, 14, 66, "https://materiais.mock.com/material-66", "Material de Apoio 66" },
                    { 67, 14, 67, "https://materiais.mock.com/material-67", "Material de Apoio 67" },
                    { 68, 14, 68, "https://materiais.mock.com/material-68", "Material de Apoio 68" },
                    { 69, 14, 69, "https://materiais.mock.com/material-69", "Material de Apoio 69" },
                    { 70, 14, 70, "https://materiais.mock.com/material-70", "Material de Apoio 70" },
                    { 71, 15, 71, "https://materiais.mock.com/material-71", "Material de Apoio 71" },
                    { 72, 15, 72, "https://materiais.mock.com/material-72", "Material de Apoio 72" },
                    { 73, 15, 73, "https://materiais.mock.com/material-73", "Material de Apoio 73" },
                    { 74, 15, 74, "https://materiais.mock.com/material-74", "Material de Apoio 74" },
                    { 75, 15, 75, "https://materiais.mock.com/material-75", "Material de Apoio 75" },
                    { 76, 16, 76, "https://materiais.mock.com/material-76", "Material de Apoio 76" },
                    { 77, 16, 77, "https://materiais.mock.com/material-77", "Material de Apoio 77" },
                    { 78, 16, 78, "https://materiais.mock.com/material-78", "Material de Apoio 78" },
                    { 79, 16, 79, "https://materiais.mock.com/material-79", "Material de Apoio 79" },
                    { 80, 16, 80, "https://materiais.mock.com/material-80", "Material de Apoio 80" },
                    { 81, 17, 81, "https://materiais.mock.com/material-81", "Material de Apoio 81" },
                    { 82, 17, 82, "https://materiais.mock.com/material-82", "Material de Apoio 82" },
                    { 83, 17, 83, "https://materiais.mock.com/material-83", "Material de Apoio 83" },
                    { 84, 17, 84, "https://materiais.mock.com/material-84", "Material de Apoio 84" },
                    { 85, 17, 85, "https://materiais.mock.com/material-85", "Material de Apoio 85" },
                    { 86, 18, 86, "https://materiais.mock.com/material-86", "Material de Apoio 86" },
                    { 87, 18, 87, "https://materiais.mock.com/material-87", "Material de Apoio 87" },
                    { 88, 18, 88, "https://materiais.mock.com/material-88", "Material de Apoio 88" },
                    { 89, 18, 89, "https://materiais.mock.com/material-89", "Material de Apoio 89" },
                    { 90, 18, 90, "https://materiais.mock.com/material-90", "Material de Apoio 90" },
                    { 91, 19, 91, "https://materiais.mock.com/material-91", "Material de Apoio 91" },
                    { 92, 19, 92, "https://materiais.mock.com/material-92", "Material de Apoio 92" },
                    { 93, 19, 93, "https://materiais.mock.com/material-93", "Material de Apoio 93" },
                    { 94, 19, 94, "https://materiais.mock.com/material-94", "Material de Apoio 94" },
                    { 95, 19, 95, "https://materiais.mock.com/material-95", "Material de Apoio 95" },
                    { 96, 20, 96, "https://materiais.mock.com/material-96", "Material de Apoio 96" },
                    { 97, 20, 97, "https://materiais.mock.com/material-97", "Material de Apoio 97" },
                    { 98, 20, 98, "https://materiais.mock.com/material-98", "Material de Apoio 98" },
                    { 99, 20, 99, "https://materiais.mock.com/material-99", "Material de Apoio 99" },
                    { 100, 20, 100, "https://materiais.mock.com/material-100", "Material de Apoio 100" }
                });

            migrationBuilder.InsertData(
                table: "AvaliacoesMaterial",
                columns: new[] { "IdAvaliacaoMaterial", "Comentario", "IdMaterialApoio", "IdMentorado", "Nota" },
                values: new object[,]
                {
                    { 1, "Avaliação do material 1.", 1, 21, 3.0m },
                    { 2, "Avaliação do material 2.", 2, 22, 3.5m },
                    { 3, "Avaliação do material 3.", 3, 23, 4.0m },
                    { 4, "Avaliação do material 4.", 4, 24, 4.5m },
                    { 5, "Avaliação do material 5.", 5, 25, 5.0m },
                    { 6, "Avaliação do material 6.", 6, 26, 3.0m },
                    { 7, "Avaliação do material 7.", 7, 27, 3.5m },
                    { 8, "Avaliação do material 8.", 8, 28, 4.0m },
                    { 9, "Avaliação do material 9.", 9, 29, 4.5m },
                    { 10, "Avaliação do material 10.", 10, 30, 5.0m },
                    { 11, "Avaliação do material 11.", 11, 31, 3.0m },
                    { 12, "Avaliação do material 12.", 12, 32, 3.5m },
                    { 13, "Avaliação do material 13.", 13, 33, 4.0m },
                    { 14, "Avaliação do material 14.", 14, 34, 4.5m },
                    { 15, "Avaliação do material 15.", 15, 35, 5.0m },
                    { 16, "Avaliação do material 16.", 16, 36, 3.0m },
                    { 17, "Avaliação do material 17.", 17, 37, 3.5m },
                    { 18, "Avaliação do material 18.", 18, 38, 4.0m },
                    { 19, "Avaliação do material 19.", 19, 39, 4.5m },
                    { 20, "Avaliação do material 20.", 20, 40, 5.0m },
                    { 21, "Avaliação do material 21.", 21, 41, 3.0m },
                    { 22, "Avaliação do material 22.", 22, 42, 3.5m },
                    { 23, "Avaliação do material 23.", 23, 43, 4.0m },
                    { 24, "Avaliação do material 24.", 24, 44, 4.5m },
                    { 25, "Avaliação do material 25.", 25, 45, 5.0m },
                    { 26, "Avaliação do material 26.", 26, 21, 3.0m },
                    { 27, "Avaliação do material 27.", 27, 22, 3.5m },
                    { 28, "Avaliação do material 28.", 28, 23, 4.0m },
                    { 29, "Avaliação do material 29.", 29, 24, 4.5m },
                    { 30, "Avaliação do material 30.", 30, 25, 5.0m },
                    { 31, "Avaliação do material 31.", 31, 26, 3.0m },
                    { 33, "Avaliação do material 33.", 33, 28, 4.0m },
                    { 34, "Avaliação do material 34.", 34, 29, 4.5m },
                    { 35, "Avaliação do material 35.", 35, 30, 5.0m },
                    { 36, "Avaliação do material 36.", 36, 31, 3.0m },
                    { 37, "Avaliação do material 37.", 37, 32, 3.5m },
                    { 38, "Avaliação do material 38.", 38, 33, 4.0m },
                    { 39, "Avaliação do material 39.", 39, 34, 4.5m },
                    { 40, "Avaliação do material 40.", 40, 35, 5.0m },
                    { 41, "Avaliação do material 41.", 41, 36, 3.0m },
                    { 42, "Avaliação do material 42.", 42, 37, 3.5m },
                    { 43, "Avaliação do material 43.", 43, 38, 4.0m },
                    { 44, "Avaliação do material 44.", 44, 39, 4.5m },
                    { 45, "Avaliação do material 45.", 45, 40, 5.0m },
                    { 46, "Avaliação do material 46.", 46, 41, 3.0m },
                    { 47, "Avaliação do material 47.", 47, 42, 3.5m },
                    { 48, "Avaliação do material 48.", 48, 43, 4.0m },
                    { 49, "Avaliação do material 49.", 49, 44, 4.5m },
                    { 50, "Avaliação do material 50.", 50, 45, 5.0m },
                    { 51, "Avaliação do material 51.", 51, 21, 3.0m },
                    { 52, "Avaliação do material 52.", 52, 22, 3.5m },
                    { 53, "Avaliação do material 53.", 53, 23, 4.0m },
                    { 54, "Avaliação do material 54.", 54, 24, 4.5m },
                    { 55, "Avaliação do material 55.", 55, 25, 5.0m },
                    { 56, "Avaliação do material 56.", 56, 26, 3.0m },
                    { 57, "Avaliação do material 57.", 57, 27, 3.5m },
                    { 58, "Avaliação do material 58.", 58, 28, 4.0m },
                    { 59, "Avaliação do material 59.", 59, 29, 4.5m },
                    { 60, "Avaliação do material 60.", 60, 30, 5.0m },
                    { 61, "Avaliação do material 61.", 61, 31, 3.0m },
                    { 62, "Avaliação do material 62.", 62, 32, 3.5m },
                    { 63, "Avaliação do material 63.", 63, 33, 4.0m },
                    { 64, "Avaliação do material 64.", 64, 34, 4.5m },
                    { 65, "Avaliação do material 65.", 65, 35, 5.0m },
                    { 66, "Avaliação do material 66.", 66, 36, 3.0m },
                    { 67, "Avaliação do material 67.", 67, 37, 3.5m },
                    { 68, "Avaliação do material 68.", 68, 38, 4.0m },
                    { 69, "Avaliação do material 69.", 69, 39, 4.5m },
                    { 70, "Avaliação do material 70.", 70, 40, 5.0m },
                    { 71, "Avaliação do material 71.", 71, 41, 3.0m },
                    { 72, "Avaliação do material 72.", 72, 42, 3.5m },
                    { 73, "Avaliação do material 73.", 73, 43, 4.0m },
                    { 74, "Avaliação do material 74.", 74, 44, 4.5m },
                    { 75, "Avaliação do material 75.", 75, 45, 5.0m },
                    { 76, "Avaliação do material 76.", 76, 21, 3.0m },
                    { 77, "Avaliação do material 77.", 77, 22, 3.5m },
                    { 78, "Avaliação do material 78.", 78, 23, 4.0m },
                    { 79, "Avaliação do material 79.", 79, 24, 4.5m },
                    { 80, "Avaliação do material 80.", 80, 25, 5.0m },
                    { 81, "Avaliação do material 81.", 81, 26, 3.0m },
                    { 82, "Avaliação do material 82.", 82, 27, 3.5m },
                    { 83, "Avaliação do material 83.", 83, 28, 4.0m },
                    { 84, "Avaliação do material 84.", 84, 29, 4.5m },
                    { 85, "Avaliação do material 85.", 85, 30, 5.0m },
                    { 86, "Avaliação do material 86.", 86, 31, 3.0m },
                    { 87, "Avaliação do material 87.", 87, 32, 3.5m },
                    { 88, "Avaliação do material 88.", 88, 33, 4.0m },
                    { 89, "Avaliação do material 89.", 89, 34, 4.5m },
                    { 90, "Avaliação do material 90.", 90, 35, 5.0m },
                    { 91, "Avaliação do material 91.", 91, 36, 3.0m },
                    { 92, "Avaliação do material 92.", 92, 37, 3.5m },
                    { 93, "Avaliação do material 93.", 93, 38, 4.0m },
                    { 94, "Avaliação do material 94.", 94, 39, 4.5m },
                    { 95, "Avaliação do material 95.", 95, 40, 5.0m },
                    { 96, "Avaliação do material 96.", 96, 41, 3.0m },
                    { 97, "Avaliação do material 97.", 97, 42, 3.5m },
                    { 98, "Avaliação do material 98.", 98, 43, 4.0m },
                    { 99, "Avaliação do material 99.", 99, 44, 4.5m },
                    { 100, "Avaliação do material 100.", 100, 45, 5.0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Anotacoes",
                keyColumn: "IdAnotacao",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMaterial",
                keyColumn: "IdAvaliacaoMaterial",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentor",
                keyColumn: "IdAvaliacaoMentor",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "AvaliacoesMentoria",
                keyColumn: "IdAvaliacaoMentoria",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Disponibilidades",
                keyColumn: "IdDisponibilidade",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Duracoes",
                keyColumn: "IdDuracao",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Duracoes",
                keyColumn: "IdDuracao",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Duracoes",
                keyColumn: "IdDuracao",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Duracoes",
                keyColumn: "IdDuracao",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Duracoes",
                keyColumn: "IdDuracao",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Duracoes",
                keyColumn: "IdDuracao",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Duracoes",
                keyColumn: "IdDuracao",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Duracoes",
                keyColumn: "IdDuracao",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "MateriaisDeApoio",
                keyColumn: "IdMaterialApoio",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Mentorias",
                keyColumn: "IdMentoria",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Mentorados",
                keyColumn: "IdUsuario",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 45);

            migrationBuilder.AlterColumn<float>(
                name: "Nota",
                table: "AvaliacoesMentoria",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "Nota",
                table: "AvaliacoesMentor",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "Nota",
                table: "AvaliacoesMaterial",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
