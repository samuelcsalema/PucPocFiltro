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

    // GET: USUARIOS
    public async Task<IActionResult> Index(string buscaNome, int? idArea, int? idTecnologia, DateTime? horaDisponibilidade)    
    {
        ViewBag.BuscaNomeAtual = buscaNome;
        ViewBag.AreaAtual = idArea;
        ViewBag.TecnologiaAtual = idTecnologia;
        ViewBag.DisponibilidadeAtual = horaDisponibilidade;

        ViewBag.Areas = await _context.AreasConhecimento.ToListAsync();

        ViewBag.Tecnologias = await _context.Tecnologias.ToListAsync();

        ViewBag.Disponibilidades = await _context.Disponibilidades
            .Where(d => d.Disponivel == true && d.HoraInicio >= DateTime.Now)
            .Select(d => d.HoraInicio)
            .Distinct()
            .OrderBy(h => h)
            .ToListAsync();

        IQueryable<Usuario> query = _context.Usuarios
            .Where(u => u.PerfilAtivo == true)
            .Where(u => u.Mentor != null)
            .Include(u => u.NivelAcesso)
            .Include(u => u.Mentorado)
            .Include(u => u.Mentor)
                .ThenInclude(t => t.MentorTecnologias)
                    .ThenInclude(mt => mt.Tecnologia)
            .Include(u => u.Mentor)
                .ThenInclude(a => a.MentorAreas)
                    .ThenInclude(ma => ma.AreaConhecimento)
            .Include(u => u.Mentor)
                .ThenInclude(d => d.Disponibilidades);

        if (!string.IsNullOrEmpty(buscaNome))
        {
            query = query.Where(u => u.Nome.Contains(buscaNome));
        }
        if (idArea.HasValue)
        {
            query = query.Where(u => u.Mentor.MentorAreas.Any(a => a.IdArea == idArea.Value));
        }
        if (idTecnologia.HasValue)
        {
            query = query.Where(u => u.Mentor.MentorTecnologias.Any(t => t.IdTecnologia == idTecnologia.Value));
        }
        if (horaDisponibilidade.HasValue)
        {
            var h = horaDisponibilidade.Value;
            query = query.Where(u => u.Mentor.Disponibilidades.Any(d =>
                d.Disponivel == true &&
                d.HoraInicio.Year == h.Year &&
                d.HoraInicio.Month == h.Month &&
                d.HoraInicio.Day == h.Day &&
                d.HoraInicio.Hour == h.Hour &&
                d.HoraInicio.Minute == h.Minute
            ));
        }

        var usuariosFiltrados = await query.ToArrayAsync();

        ViewBag.Contador = usuariosFiltrados.Length;

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
