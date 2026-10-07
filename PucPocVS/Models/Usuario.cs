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
        // Senha do Usuário
        [Required(ErrorMessage = "Senha é obrigatória.")]
        public string Senha { get; set; }
        // Data de Nascimento do Usuário
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
        // Relacionamentos de Navegação
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUsuario { get; set; }
        // Área de Interesse do Mentorado
        [Required(ErrorMessage = "Área de Interesse é obrigatória.")]
        public string AreaInteresse { get; set; }
        // Foreign Key para a tabela Usuario
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
        // Avaliações realizadas pelo Mentorado
        public ICollection<AvaliacaoMentoria> AvaliacoesMentoria { get; set; }
        public ICollection<AvaliacaoMentor> AvaliacoesMentor { get; set; }
        public ICollection<AvaliacaoMaterial> AvaliacoesMaterial { get; set; }
    }
    // Tabela Mentor
    [Table("Mentores")]
    public class Mentor
    {
        // ID do Mentor (Primary Key)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUsuario { get; set; }
        public string NotaMedia { get; set; }
        // Foreign Key para a tabela Usuario
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
        // Relacionamentos de Navegação
        public ICollection<MentorAreas> MentorAreas { get; set; }
        public ICollection<MentorTecnologia> MentorTecnologias { get; set; }
        public ICollection<Disponibilidade> Disponibilidades { get; set; }
        public ICollection<AvaliacaoMentor> AvaliacoesMentores { get; set; }
        public ICollection<Mentoria> Mentorias { get; set; }
        public ICollection<MaterialDeApoio> MateriaisDeApoio { get; set; }
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
        // Relacionamento com a tabela MentorAreas
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
        // Foreign Key para as tabelas "Mentor" e "AreaConhecimento"
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
        // Relacionamento com a tabela MentorTecnologia
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
        // Foreign Key para as tabelas "Mentor" e "Tecnologia"
        [ForeignKey("IdMentor")]
        public Mentor Mentor { get; set; }
        [ForeignKey("IdTecnologia")]
        public Tecnologia Tecnologia { get; set; }
    }
    // Tabela das Disponibilidades dos Mentores
    [Table("Disponibilidades")]
    public class Disponibilidade
    {
        // ID da Disponibilidade (Primary Key)
        [Key]
        public int IdDisponibilidade { get; set; }
        // ID do Mentor (Foreign Key)
        public int IdMentor { get; set; }
        // Hora de Início
        [Required(ErrorMessage = "A hora de início é obrigatória.")]
        public DateTime HoraInicio { get; set; }
        // Duração
        [Required(ErrorMessage = "A duração é obrigatória.")]
        public int IdDuracao { get; set; }
        // Ainda Disponível
        public bool Disponivel { get; set; }
        // Foreign Key para as tabelas "Mentor" e "Duracao"
        [ForeignKey("IdMentor")]
        public Mentor Mentor { get; set; }
        [ForeignKey("IdDuracao")]
        public Duracao Duracao { get; set; }
    }
    // Tabela das Durações das Disponibilidades dos Mentores
    [Table("Duracoes")]
    public class Duracao
    {
        // ID da Disponibilidade (Primary Key)
        [Key]
        public int IdDuracao { get; set; }
        // Tempo em minutos
        public int Tempo { get; set; }
    }
    // Tabela das Anotações dos Mentorados
    [Table("Anotacoes")]
    public class Anotacao
    {
        // ID da Anotação (Primary Key)
        [Key]
        public int IdAnotacao { get; set; }
        // Anotação do Mentorado
        [Required(ErrorMessage = "A anotação é obrigatória.")]
        public string AnotacaoMentorado { get; set; }
        // ID do Mentorado (Foreign Key)
        public int IdMentorado { get; set; }
        // ID da Mentoria (Foreign Key)
        public int IdMentoria { get; set; }
        // Relacionamentos de Navegação
        [ForeignKey("IdMentorado")]
        public Mentorado Mentorado { get; set; }
        [ForeignKey("IdMentoria")]
        public Mentoria Mentoria { get; set; }
    }
    // Tabela das Mentorias
    [Table("Mentorias")]
    public class Mentoria
    {
        // ID da Mentoria (Primary Key)
        [Key]
        public int IdMentoria { get; set; }
        // ID do Mentorado (Foreign Key)
        public int IdMentorado { get; set; }
        // ID do Mentor (Foreign Key)
        public int IdMentor { get; set; }
        // Data e Hora de Início da Mentoria
        [Required(ErrorMessage = "A data da mentoria é obrigatória.")]
        public DateTime HoraInicio { get; set; }
        // Link da Mentoria
        public string Link { get; set; }
        // Descrição da Necessidade
        public string Descricao { get; set; }
        // Status da Mentoria (Pendente, Concluída, Cancelada)
        public string Status { get; set; }
        // Relacionamentos de Navegação
        [ForeignKey("IdMentor")]
        public Mentor Mentor { get; set; }
        [ForeignKey("IdMentorado")]
        public Mentorado Mentorado { get; set; }
        // Relacionamentos com outras tabelas
        public ICollection<Anotacao> Anotacoes { get; set; }
        public ICollection<MaterialDeApoio> MateriaisApoio { get; set; }
        public ICollection<AvaliacaoMentoria> AvaliacoesMentoria { get; set; }
        public ICollection<AvaliacaoMentor> AvaliacoesMentor { get; set; }
    }
    // Tabela dos Materiais de Apoio das Mentorias
    [Table("MateriaisDeApoio")]
    public class MaterialDeApoio
    {
        // ID do Material de Apoio (Primary Key)
        [Key]
        public int IdMaterialApoio { get; set; }
        // Titulo do Material de Apoio
        public string Titulo { get; set; }
        // Material de Apoio do Mentor
        public string Material { get; set; }
        // ID do Mentor (Foreign Key)
        public int IdMentor { get; set; }
        // ID da Mentoria (Foreign Key)
        public int IdMentoria { get; set; }
        // Relacionamentos de Navegação
        [ForeignKey("IdMentor")]
        public Mentor Mentor { get; set; }
        [ForeignKey("IdMentoria")]
        public Mentoria Mentoria { get; set; }
        // Relacionamentos com outras tabelas
        public ICollection<AvaliacaoMaterial> AvaliacoesMateriais { get; set; }
    }
    // Tabela das Avaliações da Mentoria (Sessão)
    [Table("AvaliacoesMentoria")]
    public class AvaliacaoMentoria
    {
        // ID da Avaliação da Mentoria (Primary Key)
        [Key]
        public int IdAvaliacaoMentoria { get; set; }
        // ID da Mentoria (Foreign Key)
        public int IdMentoria { get; set; }
        // ID do Mentorado (Foreign Key)
        public int IdMentorado { get; set; }
        // Nota da Avaliação da Mentoria
        [Required(ErrorMessage = "A nota é obrigatória.")]
        public decimal Nota { get; set; }
        // Comentário da Avaliação da Mentoria
        public string Comentario { get; set; }
        // Relacionamentos de Navegação
        [ForeignKey("IdMentoria")]
        public Mentoria Mentoria { get; set; }
        [ForeignKey("IdMentorado")]
        public Mentorado Mentorado { get; set; }
    }
    // Tabela das Avaliações dos Mentores
    [Table("AvaliacoesMentor")]
    public class AvaliacaoMentor
    {
        // ID da Avaliação do Mentor (Primary Key)
        [Key]
        public int IdAvaliacaoMentor { get; set; }
        // ID do Mentor (Foreign Key)
        public int IdMentor { get; set; }
        // ID do Mentorado (Foreign Key)
        public int IdMentorado { get; set; }
        // ID da Mentoria (Foreign Key)
        public int IdMentoria { get; set; }
        // Nota da Avaliação do Mentor
        [Required(ErrorMessage = "A nota é obrigatória.")]
        public decimal Nota { get; set; }
        // Comentário da Avaliação do Mentor
        public string Comentario { get; set; }
        // Relacionamentos de Navegação
        [ForeignKey("IdMentor")]
        public Mentor Mentor { get; set; }
        [ForeignKey("IdMentorado")]
        public Mentorado Mentorado { get; set; }
        [ForeignKey("IdMentoria")]
        public Mentoria Mentoria { get; set; }
    }
    // Tabela das Avaliações dos Materiais de Apoio
    [Table("AvaliacoesMaterial")]
    public class AvaliacaoMaterial
    {
        // ID da Avaliação do Material de Apoio (Primary Key)
        [Key]
        public int IdAvaliacaoMaterial { get; set; }
        // ID do Material de Apoio (Foreign Key)
        public int IdMaterialApoio { get; set; }
        // ID do Mentorado (Foreign Key)
        public int IdMentorado { get; set; }
        // Nota da Avaliação do Material de Apoio
        [Required(ErrorMessage = "A nota é obrigatória.")]
        public decimal Nota { get; set; }
        // Comentário da Avaliação do Material de Apoio
        public string Comentario { get; set; }
        // Relacionamentos de Navegação
        [ForeignKey("IdMaterialApoio")]
        public MaterialDeApoio MaterialDeApoio { get; set; }
        [ForeignKey("IdMentorado")]
        public Mentorado Mentorado { get; set; }
    }
}