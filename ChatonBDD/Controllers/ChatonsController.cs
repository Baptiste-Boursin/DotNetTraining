using System.Linq;
using System.Threading.Tasks;
using ChatonBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChatonBDD.Controllers
{
    public class ChatonsController : Controller
    {
        private readonly ContexteBDD _context = new ContexteBDD();
        
        // GET: Chatons
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chatons.ToListAsync());
        }
        
        // GET: Chatons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chaton = await _context.Chatons.FirstOrDefaultAsync(m => m.Id == id);
            if (chaton == null)
            {
                return NotFound();
            }

            return View(chaton);
        }
        
        // GET: Chatons/Create
        public IActionResult Create()
        {
            return View();
        }
        
        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Libelle,Description")] Chaton chaton)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chaton);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chaton);
        }
        
        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chatons = await _context.Chatons.FindAsync(id);
            if (chatons == null)
            {
                return NotFound();
            }
            return View(chatons);
        }
        
        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Libelle,Description")] Chaton chaton)
        {
            if (id != chaton.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chaton);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChatonExist(chaton.Id))
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
            return View(chaton);
        }
        
        // GET: Chaton/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chaton = await _context.Chatons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chaton == null)
            {
                return NotFound();
            }

            return View(chaton);
        }
        
        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chaton = await _context.Chatons.FindAsync(id);
            _context.Chatons.Remove(chaton);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        private bool ChatonExist(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}