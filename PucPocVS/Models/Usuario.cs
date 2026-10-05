using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PucPocVS.Models
{
    // Tabela Nível de Acesso
    [Table("NiveisAcesso")]
    public class NivelAcesso
    {
        // ID do Nível de Acesso (Primary Key)
        [Key]
        public int IdNivelAcesso { get; set; }
        // Descrição do Nível de Acesso
        public string Descricao { get; set; }
    }
    // Tabela Usuários
    [Table("Usuarios")]
    public class Usuario
    {
        // ID do Usuário (Primary Key)
        [Key]
        public int IdUsuario { get; set; }
        // ID do Nível de Acesso (Foreign Key)
        public int IdNivelAcesso { get; set; }
        // Nome do Usuário
        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Nome { get; set; }
        // Senha do Usuário //
        [Required(ErrorMessage = "Senha é obrigatória.")]
        public string Senha { get; set; }
        // Data de Nascimento do Usuário //
        [Required(ErrorMessage = "Data de Nascimento é obrigatória.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNasc { get; set; }
        // Escolaridade do Usuário
        [Required(ErrorMessage = "Escolaridade é obrigatória.")]
        [StringLength(2)]
        [Column(TypeName = "char(2)")]
        public string Escolaridade { get; set; }
        // Email do Usuário
        [Required(ErrorMessage = "Email é obrigatório.")]
        public string Email { get; set; }
        // Perfil Ativo no Sistema
        public bool PerfilAtivo { get; set; }
        [Required(ErrorMessage = "Ativo na Área é obrigatório.")]
        // Indica se o usuário está ativo na área de interesse
        public string AtivoArea { get; set; }
        // Data de Criação do Usuário
        public DateTime DataCriacao { get; set; }
        // Foreign Key para a tabela "NivelAcesso", "Mentorado" e "Mentor"
        [ForeignKey("IdNivelAcesso")]
        public NivelAcesso NivelAcesso { get; set; }
        public Mentorado Mentorado { get; set; }
        public Mentor Mentor { get; set; }
    }
    // Tabela Mentorado
    [Table("Mentorados")]
    public class Mentorado
    {
        // ID do Mentorado (Primary Key)
        [Key]
        public int IdUsuario { get; set; }
        // Área de Interesse do Mentorado
        [Required(ErrorMessage = "Área de Interesse é obrigatória.")]
        public string AreaInteresse { get; set; }
        // Foreign Key para a tabela Usuario
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
    }
    // Tabela Mentor
    [Table("Mentores")]
    public class Mentor
    {
        // ID do Mentor (Primary Key)
        [Key]
        public int IdUsuario { get; set; }
        // Foreign Key para a tabela Usuario
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
        public ICollection<MentorAreas> MentorAreas { get; set; }
        public ICollection<MentorTecnologia> MentorTecnologias { get; set; }
    }
    // Tabela Das Áreas de Conhecimento
    [Table("AreasConhecimento")]
    public class AreaConhecimento
    {
        // ID da Área de Conhecimento (Primary Key)
        [Key]
        public int IdArea { get; set; }
        // Nome da Área de Conhecimento
        public string Nome { get; set; }
        // Foreign Key para a tabela MentorAreas
        public ICollection<MentorAreas> MentorAreas { get; set; }
    }
    // Tabela Áreas de Conhecimento dos Mentores
    [Table("MentoresAreas")]
    public class MentorAreas
    {
        // ID da Área de Conhecimento (Primary Key)
        [Key]
        public int IdMentorArea { get; set; }
        public int IdArea { get; set; }
        // ID do Mentor (Foreign Key)
        public int IdMentor { get; set; }
        // Foreign Key para a tabela "Mentor" e "AreaConhecimento"
        [ForeignKey("IdMentor")]
        public Mentor Mentor { get; set; }
        [ForeignKey("IdArea")]
        public AreaConhecimento AreaConhecimento { get; set; }
    }
    // Tabela Das Tecnologias
    [Table("Tecnologias")]
    public class Tecnologia
    {
        // ID da Tecnologia (Primary Key)
        [Key]
        public int IdTecnologia { get; set; }
        // Nome da Tecnologia
        public string Nome { get; set; }
        // Foreign Key para a tabela MentorTecnologia
        public ICollection<MentorTecnologia> MentorTecnologias { get; set; }
    }
    // Tabela das Tecnologias dos Mentores
    [Table("MentoresTecnologias")]
    public class MentorTecnologia
    {
        // ID da Tecnologia do Mentor (Primary Key)
        [Key]
        public int IdMentorTecnologia { get; set; }
        // ID da Tecnologia (Foreign Key)
        public int IdTecnologia { get; set; }
        // ID do Mentor (Foreign Key)
        public int IdMentor { get; set; }
        // Foreign Key para a tabela "Mentor" e "Tecnologia"
        [ForeignKey("IdMentor")]
        public Mentor Mentor { get; set; }
        [ForeignKey("IdTecnologia")]
        public Tecnologia Tecnologia { get; set; }
    }

}