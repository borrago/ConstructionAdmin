using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConstructionAdmin.Data;
using ConstructionAdmin.Models;

namespace ConstructionAdmin.Controllers
{
    public class RequisicaoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RequisicaoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Requisicao
        public async Task<IActionResult> Index()
        {
            return _context.Requisicao != null ?
                        View(await _context.Requisicao.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Requisicao'  is null.");
        }

        // GET: Requisicao/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Requisicao == null)
            {
                return NotFound();
            }

            var requisicao = await _context.Requisicao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requisicao == null)
            {
                return NotFound();
            }

            return View(requisicao);
        }

        // GET: Requisicao/Create
        public IActionResult Create()
        {
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Nome");
            return View();
        }

        // POST: Requisicao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Data_Requesicao,Estado_Requesicao,Justificacao,Observacao,ItemId,Id")] Requisicao requisicao)
        {
            ModelState.Remove("Item");
            if (ModelState.IsValid)
            {
                requisicao.Id = Guid.NewGuid();
                _context.Add(requisicao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requisicao);
        }

        // GET: Requisicao/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Requisicao == null)
            {
                return NotFound();
            }

            var requisicao = await _context.Requisicao.FindAsync(id);
            if (requisicao == null)
            {
                return NotFound();
            }
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Nome");
            return View(requisicao);
        }

        // POST: Requisicao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Data_Requesicao,Estado_Requesicao,Justificacao,Observacao,ItemId,Id")] Requisicao requisicao)
        {
            if (id != requisicao.Id)
            {
                return NotFound();
            }

            ModelState.Remove("Item");
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requisicao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequisicaoExists(requisicao.Id))
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
            return View(requisicao);
        }

        // GET: Requisicao/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Requisicao == null)
            {
                return NotFound();
            }

            var requisicao = await _context.Requisicao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requisicao == null)
            {
                return NotFound();
            }

            return View(requisicao);
        }

        // POST: Requisicao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Requisicao == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Requisicao'  is null.");
            }
            var requisicao = await _context.Requisicao.FindAsync(id);
            if (requisicao != null)
            {
                _context.Requisicao.Remove(requisicao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequisicaoExists(Guid id)
        {
            return (_context.Requisicao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
