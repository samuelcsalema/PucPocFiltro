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
    public async Task<IActionResult> Index()    
    {
        var usuarios = await _context.Usuarios
            .Include(u => u.NivelAcesso)
            .Include(u => u.Mentorado)
            .Include(u => u.Mentor)
                .ThenInclude(m => m.MentorTecnologias)
                    .ThenInclude(mt => mt.Tecnologia)
            .Include(u => u.Mentor)
                .ThenInclude(a => a.MentorAreas)
                    .ThenInclude(ma => ma.AreaConhecimento)
            .ToListAsync();

        return View(usuarios);
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
