using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PucPocVS.Models;

public class UsuariosController : Controller
{
    private readonly AppDbContext _context;

    public UsuariosController(AppDbContext context)
    {
        _context = context;
    }

    // GET: USUARIOS - Utilizando filtros de busca por nome (nome), área(id), tecnologia(id) e disponibilidade(hora de início)
    public async Task<IActionResult> Index(string buscaNome, int? idArea, int? idTecnologia, DateTime? horaDisponibilidade)
    {
        // Guardar os valores atuais dos filtros para exibir na view após a filtragem
        ViewBag.BuscaNomeAtual = buscaNome;
        ViewBag.AreaAtual = idArea;
        ViewBag.TecnologiaAtual = idTecnologia;
        ViewBag.DisponibilidadeAtual = horaDisponibilidade;
        // Carregar os dados para o dropdown dos filtros de busca
        ViewBag.Areas = await _context.AreasConhecimento.ToListAsync();
        ViewBag.Tecnologias = await _context.Tecnologias.ToListAsync();
        // Carregar os horários de disponibilidade distintos para o dropdown de filtro além de filtrar apenas os horários disponíveis, futuros e ordenados
        ViewBag.Disponibilidades = await _context.Disponibilidades
            .Where(d => d.Disponivel == true && d.HoraInicio >= DateTime.Now)
            .Select(d => d.HoraInicio)
            .Distinct()
            .OrderBy(h => h)
            .ToListAsync();
        // Query inicial para buscar os usuários com perfil ativo e que sejam mentores, incluindo os relacionamentos necessários
        IQueryable<Usuario> query = _context.Usuarios
            .Where(u => u.PerfilAtivo == true)
            .Where(u => u.Mentor != null)
            .Include(u => u.NivelAcesso)
            .Include(u => u.Mentorado)
            // Ligações permitidas devido aos ICollection(s) de Mentor
            .Include(u => u.Mentor)
                // Incluindo as tecnologias do mentor e suas avaliações
                .ThenInclude(t => t.MentorTecnologias)
                    .ThenInclude(mt => mt.Tecnologia)
            .Include(u => u.Mentor)
                // Incluindo as áreas de conhecimento do mentor e suas avaliações
                .ThenInclude(a => a.MentorAreas)
                    .ThenInclude(ma => ma.AreaConhecimento)
            .Include(u => u.Mentor)
                // Incluindo as disponibilidades do mentor
                .ThenInclude(d => d.Disponibilidades)
            .Include(u => u.Mentor)
                // Incluindo as mentorias do mentor e suas avaliações
                .ThenInclude(m => m.Mentorias)
                    .ThenInclude(nm => nm.AvaliacoesMentoria)
            .Include(u => u.Mentor)
                // Incluindo os materiais de apoio do mentor e suas avaliações
                .ThenInclude(m => m.MateriaisDeApoio)
                    .ThenInclude(nm => nm.AvaliacoesMateriais)
            .Include(u => u.Mentor)
                // Incluindo as avaliações do mentor
                .ThenInclude(m => m.AvaliacoesMentores);
        // Executar a query para obter a lista de usuários
        List<Usuario> listaUsarios = await query.ToListAsync();
        // Calcular a média de notas e total de sessões para cada mentor
        foreach (var usuario in listaUsarios)
        {
            // Média da pessoal do Mentor
            var mentor = usuario.Mentor;
            decimal mediaMentor = mentor.AvaliacoesMentores.Any() // Verifica se há avaliações do mentor
                ? mentor.AvaliacoesMentores.Average(m => (decimal)m.Nota) // Calcula a média das notas das avaliações do mentor
                : 0; // Se não houver avaliações, a média é 0
            // Média dos Materiais de Apoio do Mentor
            var avaliacoesMateriais = mentor.MateriaisDeApoio.SelectMany(m => m.AvaliacoesMateriais); // Facilitando minha digitação
            decimal mediaMaterias = avaliacoesMateriais.Any()
                ? avaliacoesMateriais.Average(m => (decimal)m.Nota)
                : 0;
            // Média das Mentorias do Mentor
            var avaliacoesMentorias = mentor.Mentorias.SelectMany(m => m.AvaliacoesMentoria);
            decimal mediaMentoria = avaliacoesMentorias.Any()
                ? avaliacoesMentorias.Average(m => (decimal)m.Nota)
                : 0;
            // Calcular a média geral do mentor considerando apenas as médias válidas (maiores que 0)
            var mediasValidas = new List<decimal>();
            if (mediaMentor > 0) mediasValidas.Add(mediaMentor); // Adiciona a média do mentor se for maior que 0
            if (mediaMaterias > 0) mediasValidas.Add(mediaMaterias);
            if (mediaMentoria > 0) mediasValidas.Add(mediaMentoria);
            // Calcula a média geral do mentor com base nas médias válidas
            decimal mediaGeralMentor = mediasValidas.Any()
                ? mediasValidas.Average()
                : 0;
            // Atribuir a média geral do mentor ao campo NotaMedia do mentor, arredondando para uma casa decimal
            string estrelaCard = $"{Math.Round(mediaGeralMentor, 1)}";
            usuario.Mentor.NotaMedia = estrelaCard;
            // Atribuir o total de sessões concluídas do mentor ao campo TotalSessoes
            mentor.TotalSessoes = mentor.Mentorias
                .Count(s => s.Status == "Concluída");
        }
        // Aplicar os filtros de busca, se fornecidos
        if (!string.IsNullOrEmpty(buscaNome)) // Filtrar por nome do usuário (contendo a string de busca)
        {
            query = query.Where(u => u.Nome.Contains(buscaNome)); // Filtrar por nome do usuário (contendo a string de busca)
        }
        if (idArea.HasValue) // Filtrar por área de conhecimento do mentor (verificando se o mentor possui a área especificada)
        {
            query = query.Where(u => u.Mentor.MentorAreas.Any(a => a.IdArea == idArea.Value));
        }
        if (idTecnologia.HasValue) // Filtrar por tecnologia do mentor (verificando se o mentor possui a tecnologia especificada)
        {
            query = query.Where(u => u.Mentor.MentorTecnologias.Any(t => t.IdTecnologia == idTecnologia.Value));
        }
        if (horaDisponibilidade.HasValue) // Filtrar por disponibilidade do mentor (verificando se o mentor possui uma disponibilidade na hora especificada)
        {
            var h = horaDisponibilidade.Value; // Armazenar a hora de disponibilidade fornecida para facilitar a leitura do código
            query = query.Where(u => u.Mentor.Disponibilidades.Any(d => // Verificar se o mentor possui uma disponibilidade que atenda aos critérios especificados
                d.Disponivel == true && // Verificar se a disponibilidade está marcada como disponível
                d.HoraInicio.Year == h.Year && // Verificar se o ano da disponibilidade é igual ao ano da hora fornecida
                d.HoraInicio.Month == h.Month && // Verificar se o mês da disponibilidade é igual ao mês da hora fornecida
                d.HoraInicio.Day == h.Day && // Verificar se o dia da disponibilidade é igual ao dia da hora fornecida
                d.HoraInicio.Hour == h.Hour && // Verificar se a hora da disponibilidade é igual à hora da hora fornecida
                d.HoraInicio.Minute == h.Minute // Verificar se os minutos da disponibilidade são iguais aos minutos da hora fornecida
            ));
        }
        // Executar a query final para obter os usuários filtrados
        var usuariosFiltrados = await query.ToArrayAsync();
        // Armazenar a quantidade de usuários filtrados na ViewBag para exibição na view
        ViewBag.Contador = usuariosFiltrados.Length;
        // Retornar a view com os usuários filtrados
        return View(usuariosFiltrados);
    }

    // GET: USUARIOS/Details/5
    public async Task<IActionResult> Details(int? idusuario)
    {
        if (idusuario == null)
        {
            return NotFound();
        }

        var usuario = await _context.Usuarios
            .FirstOrDefaultAsync(m => m.IdUsuario == idusuario);
        if (usuario == null)
        {
            return NotFound();
        }

        return View(usuario);
    }

    // GET: USUARIOS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: USUARIOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("IdUsuario,IdNivelAcesso,Nome,Senha,DataNasc,Escolaridade,Email,PerfilAtivo,AtivoArea,DataCriacao,NivelAcesso,Mentorado,Mentor")] Usuario usuario)
    {
        if (ModelState.IsValid)
        {
            _context.Add(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(usuario);
    }

    // GET: USUARIOS/Edit/5
    public async Task<IActionResult> Edit(int? idusuario)
    {
        if (idusuario == null)
        {
            return NotFound();
        }

        var usuario = await _context.Usuarios.FindAsync(idusuario);
        if (usuario == null)
        {
            return NotFound();
        }
        return View(usuario);
    }

    // POST: USUARIOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? idusuario, [Bind("IdUsuario,IdNivelAcesso,Nome,Senha,DataNasc,Escolaridade,Email,PerfilAtivo,AtivoArea,DataCriacao,NivelAcesso,Mentorado,Mentor")] Usuario usuario)
    {
        if (idusuario != usuario.IdUsuario)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(usuario);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(usuario.IdUsuario))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(usuario);
    }

    // GET: USUARIOS/Delete/5
    public async Task<IActionResult> Delete(int? idusuario)
    {
        if (idusuario == null)
        {
            return NotFound();
        }

        var usuario = await _context.Usuarios
            .FirstOrDefaultAsync(m => m.IdUsuario == idusuario);
        if (usuario == null)
        {
            return NotFound();
        }

        return View(usuario);
    }

    // POST: USUARIOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? idusuario)
    {
        var usuario = await _context.Usuarios.FindAsync(idusuario);
        if (usuario != null)
        {
            _context.Usuarios.Remove(usuario);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool UsuarioExists(int? idusuario)
    {
        return _context.Usuarios.Any(e => e.IdUsuario == idusuario);
    }
}
