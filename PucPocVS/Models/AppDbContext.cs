using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace PucPocVS.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<NivelAcesso> NiveisAcesso { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Mentorado> Mentorados { get; set; }
        public DbSet<Mentor> Mentores { get; set; }
        public DbSet<AreaConhecimento> AreasConhecimento { get; set; }
        public DbSet<MentorAreas> MentoresAreas { get; set; }
        public DbSet<Tecnologia> Tecnologias { get; set; }
        public DbSet<MentorTecnologia> MentoresTecnologia { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelBuilder.Entity<NivelAcesso>().HasData(
                new NivelAcesso { IdNivelAcesso = 1, Descricao = "Administrador" },
                new NivelAcesso { IdNivelAcesso = 2, Descricao = "Mentor" },
                new NivelAcesso { IdNivelAcesso = 3, Descricao = "Mentorado" }
            );
            modelBuilder.Entity<Tecnologia>().HasData(
                new Tecnologia { IdTecnologia = 1, Nome = "Python" },
                new Tecnologia { IdTecnologia = 2, Nome = "SQL" },
                new Tecnologia { IdTecnologia = 3, Nome = "HTML" },
                new Tecnologia { IdTecnologia = 4, Nome = "CSS" },
                new Tecnologia { IdTecnologia = 5, Nome = "JavaScript" },
                new Tecnologia { IdTecnologia = 6, Nome = "C#" },
                new Tecnologia { IdTecnologia = 7, Nome = "Java" },
                new Tecnologia { IdTecnologia = 8, Nome = "C++" },
                new Tecnologia { IdTecnologia = 9, Nome = "Go" },
                new Tecnologia { IdTecnologia = 10, Nome = "Rust" },
                new Tecnologia { IdTecnologia = 11, Nome = "Swift" },
                new Tecnologia { IdTecnologia = 12, Nome = "R" },
                new Tecnologia { IdTecnologia = 13, Nome = "PHP" }
            );
            modelBuilder.Entity<AreaConhecimento>().HasData(
                new AreaConhecimento { IdArea = 1, Nome = "Backend" },
                new AreaConhecimento { IdArea = 2, Nome = "Frontend" },
                new AreaConhecimento { IdArea = 3, Nome = "Data Science" },
                new AreaConhecimento { IdArea = 4, Nome = "Mobile" },
                new AreaConhecimento { IdArea = 5, Nome = "Fullstack" },
                new AreaConhecimento { IdArea = 6, Nome = "Cyber Security" }
            );
            modelBuilder.Entity<Usuario>().HasData(
                CriarUsuario(1, "Carlos Silva", "carlos@email.com", "PG"),
                CriarUsuario(2, "Mariana Souza", "mariana@email.com", "ES"),
                CriarUsuario(3, "Roberto Alves", "roberto@email.com", "ME"),
                CriarUsuario(4, "Ana Clara", "ana@email.com", "ES"),
                CriarUsuario(5, "Lucas Mendes", "lucas@email.com", "DO"),
                CriarUsuario(6, "Beatriz Costa", "beatriz@email.com", "PG"),
                CriarUsuario(7, "Fernando Gomes", "fernando@email.com", "ES"),
                CriarUsuario(8, "Camila Rocha", "camila@email.com", "ME"),
                CriarUsuario(9, "Rafael Lima", "rafael@email.com", "ES"),
                CriarUsuario(10, "Juliana Pinto", "juliana@email.com", "PG"),
                CriarUsuario(11, "Diego Martins", "diego@email.com", "ES"),
                CriarUsuario(12, "Patricia Dias", "patricia@email.com", "ME"),
                CriarUsuario(13, "Gustavo Reis", "gustavo@email.com", "DO"),
                CriarUsuario(14, "Leticia Oliveira", "leticia@email.com", "ES"),
                CriarUsuario(15, "Thiago Carvalho", "thiago@email.com", "PG"),
                CriarUsuario(16, "Amanda Farias", "amanda@email.com", "ES"),
                CriarUsuario(17, "Rodrigo Nunes", "rodrigo@email.com", "ME"),
                CriarUsuario(18, "Fernanda Barros", "fernanda@email.com", "ES"),
                CriarUsuario(19, "Marcelo Moraes", "marcelo@email.com", "PG"),
                CriarUsuario(20, "Carolina Azevedo", "carolina@email.com", "ES")
            );
            modelBuilder.Entity<Mentorado>().HasData(
                new Mentorado { IdUsuario = 1, AreaInteresse = "Backend" },
                new Mentorado { IdUsuario = 2, AreaInteresse = "Frontend" },
                new Mentorado { IdUsuario = 3, AreaInteresse = "DevOps" },
                new Mentorado { IdUsuario = 4, AreaInteresse = "UX/UI Design" },
                new Mentorado { IdUsuario = 5, AreaInteresse = "Data Science" },
                new Mentorado { IdUsuario = 6, AreaInteresse = "Mobile iOS" },
                new Mentorado { IdUsuario = 7, AreaInteresse = "Mobile Android" },
                new Mentorado { IdUsuario = 8, AreaInteresse = "Gestão de Projetos" },
                new Mentorado { IdUsuario = 9, AreaInteresse = "Backend" },
                new Mentorado { IdUsuario = 10, AreaInteresse = "Cloud Computing" },
                new Mentorado { IdUsuario = 11, AreaInteresse = "Frontend" },
                new Mentorado { IdUsuario = 12, AreaInteresse = "Engenharia de Dados" },
                new Mentorado { IdUsuario = 13, AreaInteresse = "Arquitetura de Software" },
                new Mentorado { IdUsuario = 14, AreaInteresse = "UX/UI Design" },
                new Mentorado { IdUsuario = 15, AreaInteresse = "Segurança da Informação" },
                new Mentorado { IdUsuario = 16, AreaInteresse = "QA e Testes" },
                new Mentorado { IdUsuario = 17, AreaInteresse = "Inteligência Artificial" },
                new Mentorado { IdUsuario = 18, AreaInteresse = "Marketing Digital" },
                new Mentorado { IdUsuario = 19, AreaInteresse = "DevOps" },
                new Mentorado { IdUsuario = 20, AreaInteresse = "Product Management" }
            );
            modelBuilder.Entity<Mentor>().HasData(
                new Mentor { IdUsuario = 1 }, new Mentor { IdUsuario = 2 }, new Mentor { IdUsuario = 3 },
                new Mentor { IdUsuario = 4 }, new Mentor { IdUsuario = 5 }, new Mentor { IdUsuario = 6 },
                new Mentor { IdUsuario = 7 }, new Mentor { IdUsuario = 8 }, new Mentor { IdUsuario = 9 },
                new Mentor { IdUsuario = 10 }, new Mentor { IdUsuario = 11 }, new Mentor { IdUsuario = 12 },
                new Mentor { IdUsuario = 13 }, new Mentor { IdUsuario = 14 }, new Mentor { IdUsuario = 15 },
                new Mentor { IdUsuario = 16 }, new Mentor { IdUsuario = 17 }, new Mentor { IdUsuario = 18 },
                new Mentor { IdUsuario = 19 }, new Mentor { IdUsuario = 20 }
            );
            modelBuilder.Entity<MentorAreas>().HasData(
                new MentorAreas { IdMentorArea = 1, IdMentor = 1, IdArea = 1 }, // Carlos (Backend)
                new MentorAreas { IdMentorArea = 2, IdMentor = 2, IdArea = 2 }, // Mariana (Frontend)
                new MentorAreas { IdMentorArea = 3, IdMentor = 3, IdArea = 5 }, // Roberto (Fullstack)
                new MentorAreas { IdMentorArea = 4, IdMentor = 4, IdArea = 2 }, // Ana (Frontend)
                new MentorAreas { IdMentorArea = 5, IdMentor = 5, IdArea = 3 }, // Lucas (Data Science)
                new MentorAreas { IdMentorArea = 6, IdMentor = 6, IdArea = 1 }, // Beatriz (Backend)
                new MentorAreas { IdMentorArea = 7, IdMentor = 7, IdArea = 4 }, // Fernando (Mobile)
                new MentorAreas { IdMentorArea = 8, IdMentor = 8, IdArea = 5 }, // Camila (Fullstack)
                new MentorAreas { IdMentorArea = 9, IdMentor = 9, IdArea = 1 }, // Rafael (Backend)
                new MentorAreas { IdMentorArea = 10, IdMentor = 10, IdArea = 6 }, // Juliana (Data Science)
                new MentorAreas { IdMentorArea = 11, IdMentor = 11, IdArea = 4 }, // Diego (Mobile)
                new MentorAreas { IdMentorArea = 12, IdMentor = 12, IdArea = 2 }, // Patricia (Frontend)
                new MentorAreas { IdMentorArea = 13, IdMentor = 13, IdArea = 1 }, // Gustavo (Backend)
                new MentorAreas { IdMentorArea = 14, IdMentor = 14, IdArea = 3 }, // Leticia (Data Science)
                new MentorAreas { IdMentorArea = 15, IdMentor = 15, IdArea = 6 }, // Thiago (Cyber Security)
                new MentorAreas { IdMentorArea = 16, IdMentor = 16, IdArea = 5 }, // Amanda (Fullstack)
                new MentorAreas { IdMentorArea = 17, IdMentor = 17, IdArea = 3 }, // Rodrigo (Data Science)
                new MentorAreas { IdMentorArea = 18, IdMentor = 18, IdArea = 4 }, // Fernanda (Mobile)
                new MentorAreas { IdMentorArea = 19, IdMentor = 19, IdArea = 1 }, // Marcelo (Backend)
                new MentorAreas { IdMentorArea = 20, IdMentor = 20, IdArea = 2 }, // Carolina (Frontend)
                new MentorAreas { IdMentorArea = 21, IdMentor = 3, IdArea = 1 }, // Roberto também ensina Backend
                new MentorAreas { IdMentorArea = 22, IdMentor = 8, IdArea = 2 }  // Camila também ensina Frontend
            );
            modelBuilder.Entity<MentorTecnologia>().HasData(
                new MentorTecnologia { IdMentorTecnologia = 1, IdMentor = 1, IdTecnologia = 6 }, // C#
                new MentorTecnologia { IdMentorTecnologia = 2, IdMentor = 1, IdTecnologia = 2 }, // SQL
                new MentorTecnologia { IdMentorTecnologia = 3, IdMentor = 6, IdTecnologia = 1 }, // Python
                new MentorTecnologia { IdMentorTecnologia = 4, IdMentor = 9, IdTecnologia = 6 }, // C#
                new MentorTecnologia { IdMentorTecnologia = 5, IdMentor = 2, IdTecnologia = 3 }, // HTML
                new MentorTecnologia { IdMentorTecnologia = 6, IdMentor = 2, IdTecnologia = 4 }, // CSS
                new MentorTecnologia { IdMentorTecnologia = 7, IdMentor = 2, IdTecnologia = 5 }, // Java Script
                new MentorTecnologia { IdMentorTecnologia = 8, IdMentor = 4, IdTecnologia = 5 }, // Java Script
                new MentorTecnologia { IdMentorTecnologia = 9, IdMentor = 3, IdTecnologia = 6 }, // C#
                new MentorTecnologia { IdMentorTecnologia = 10, IdMentor = 3, IdTecnologia = 5 }, // Java Script
                new MentorTecnologia { IdMentorTecnologia = 11, IdMentor = 8, IdTecnologia = 1 }, // Python
                new MentorTecnologia { IdMentorTecnologia = 12, IdMentor = 8, IdTecnologia = 5 }, // Java Script
                new MentorTecnologia { IdMentorTecnologia = 13, IdMentor = 5, IdTecnologia = 1 }, // Python
                new MentorTecnologia { IdMentorTecnologia = 14, IdMentor = 5, IdTecnologia = 2 }, // SQL
                new MentorTecnologia { IdMentorTecnologia = 15, IdMentor = 10, IdTecnologia = 1 }, // Python
                new MentorTecnologia { IdMentorTecnologia = 16, IdMentor = 7, IdTecnologia = 11 }, // Swift
                new MentorTecnologia { IdMentorTecnologia = 17, IdMentor = 6, IdTecnologia = 9 }, // GO
                new MentorTecnologia { IdMentorTecnologia = 18, IdMentor = 11, IdTecnologia = 11 }, // Swift 
                new MentorTecnologia { IdMentorTecnologia = 19, IdMentor = 12, IdTecnologia = 3 }, // HTML
                new MentorTecnologia { IdMentorTecnologia = 20, IdMentor = 13, IdTecnologia = 6 }, // C#
                new MentorTecnologia { IdMentorTecnologia = 21, IdMentor = 14, IdTecnologia = 1 }, // Python
                new MentorTecnologia { IdMentorTecnologia = 22, IdMentor = 15, IdTecnologia = 10 }, // Rust
                new MentorTecnologia { IdMentorTecnologia = 23, IdMentor = 16, IdTecnologia = 5 }, // Java Script
                new MentorTecnologia { IdMentorTecnologia = 24, IdMentor = 17, IdTecnologia = 12 }, // R
                new MentorTecnologia { IdMentorTecnologia = 25, IdMentor = 18, IdTecnologia = 7 }, // Java
                new MentorTecnologia { IdMentorTecnologia = 26, IdMentor = 19, IdTecnologia = 8 }, // C++
                new MentorTecnologia { IdMentorTecnologia = 27, IdMentor = 20, IdTecnologia = 3 }, // HTML
                new MentorTecnologia { IdMentorTecnologia = 28, IdMentor = 11, IdTecnologia = 7 }, // Java
                new MentorTecnologia { IdMentorTecnologia = 29, IdMentor = 7, IdTecnologia = 7 }, // Java
                new MentorTecnologia { IdMentorTecnologia = 30, IdMentor = 9, IdTecnologia = 13 }, // PHP
                new MentorTecnologia { IdMentorTecnologia = 31, IdMentor = 10, IdTecnologia = 12 }, // R
                new MentorTecnologia { IdMentorTecnologia = 32, IdMentor = 12, IdTecnologia = 4 }, // CSS
                new MentorTecnologia { IdMentorTecnologia = 33, IdMentor = 13, IdTecnologia = 8 }, // C++
                new MentorTecnologia { IdMentorTecnologia = 34, IdMentor = 14, IdTecnologia = 2 }, // SQL
                new MentorTecnologia { IdMentorTecnologia = 35, IdMentor = 15, IdTecnologia = 9 }, // Go
                new MentorTecnologia { IdMentorTecnologia = 36, IdMentor = 16, IdTecnologia = 13 }, // PHP
                new MentorTecnologia { IdMentorTecnologia = 37, IdMentor = 17, IdTecnologia = 2 }, // SQL
                new MentorTecnologia { IdMentorTecnologia = 38, IdMentor = 18, IdTecnologia = 5 }, // Java Script
                new MentorTecnologia { IdMentorTecnologia = 39, IdMentor = 19, IdTecnologia = 13 }, // PHP
                new MentorTecnologia { IdMentorTecnologia = 40, IdMentor = 20, IdTecnologia = 4 }, // CSS
                new MentorTecnologia { IdMentorTecnologia = 41, IdMentor = 4, IdTecnologia = 3 }, // HTML
                new MentorTecnologia { IdMentorTecnologia = 42, IdMentor = 20, IdTecnologia = 5 }, // JavaScript
                new MentorTecnologia { IdMentorTecnologia = 43, IdMentor = 12, IdTecnologia = 5 }, // JavaScript
                new MentorTecnologia { IdMentorTecnologia = 44, IdMentor = 14, IdTecnologia = 12 }, // R
                new MentorTecnologia { IdMentorTecnologia = 45, IdMentor = 10, IdTecnologia = 2 }, // SQL
                new MentorTecnologia { IdMentorTecnologia = 46, IdMentor = 8, IdTecnologia = 13 } // PHP
            );
        }
        private Usuario CriarUsuario(int id, string nome, string email, string escolaridade)
        {
            return new Usuario
            {
                IdUsuario = id,
                IdNivelAcesso = 2,
                Nome = nome,
                Email = email,
                Senha = "SenhaPadrao123",
                Escolaridade = escolaridade,
                DataNasc = new DateTime(1990, 5, 20),
                PerfilAtivo = true,
                AtivoArea = "Sim",
                DataCriacao = new DateTime(2024, 1, 1)
            };
        }
    }
}