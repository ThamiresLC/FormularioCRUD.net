#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVC.Data;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    [Authorize]
    public class AtuacaoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AtuacaoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Atuacao
        public async Task<IActionResult> Index()
        {
            return View(await _context.Atuacao.ToListAsync());
        }

        // GET: Atuacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atuacao = await _context.Atuacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atuacao == null)
            {
                return NotFound();
            }

            return View(atuacao);
        }

        // GET: Atuacao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Atuacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao")] Atuacao atuacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(atuacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(atuacao);
        }

        // GET: Atuacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atuacao = await _context.Atuacao.FindAsync(id);
            if (atuacao == null)
            {
                return NotFound();
            }
            return View(atuacao);
        }

        // POST: Atuacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao")] Atuacao atuacao)
        {
            if (id != atuacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(atuacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtuacaoExists(atuacao.Id))
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
            return View(atuacao);
        }

        // GET: Atuacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atuacao = await _context.Atuacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atuacao == null)
            {
                return NotFound();
            }

            return View(atuacao);
        }

        // POST: Atuacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var atuacao = await _context.Atuacao.FindAsync(id);
            _context.Atuacao.Remove(atuacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtuacaoExists(int id)
        {
            return _context.Atuacao.Any(e => e.Id == id);
        }
    }
}
