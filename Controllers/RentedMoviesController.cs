using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspVideoRental.Models;

namespace AspVideoRental.Controllers
{
    public class RentedMoviesController : Controller
    {
        private readonly MovieContext _context;

        public RentedMoviesController(MovieContext context)
        {
            _context = context;
        }

        // GET: RentedMovies
        public async Task<IActionResult> Index()
        {
            return View(await _context.RentedMovies.ToListAsync());
        }

        // GET: RentedMovies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentedMovies = await _context.RentedMovies
                .FirstOrDefaultAsync(m => m.RMID == id);
            if (rentedMovies == null)
            {
                return NotFound();
            }

            return View(rentedMovies);
        }

        // GET: RentedMovies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RentedMovies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RMID,MovieIDFK,CustIDFK,DateRented,DateReturned")] RentedMovies rentedMovies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentedMovies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rentedMovies);
        }

        // GET: RentedMovies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentedMovies = await _context.RentedMovies.FindAsync(id);
            if (rentedMovies == null)
            {
                return NotFound();
            }
            return View(rentedMovies);
        }

        // POST: RentedMovies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RMID,MovieIDFK,CustIDFK,DateRented,DateReturned")] RentedMovies rentedMovies)
        {
            if (id != rentedMovies.RMID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentedMovies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentedMoviesExists(rentedMovies.RMID))
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
            return View(rentedMovies);
        }

        // GET: RentedMovies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentedMovies = await _context.RentedMovies
                .FirstOrDefaultAsync(m => m.RMID == id);
            if (rentedMovies == null)
            {
                return NotFound();
            }

            return View(rentedMovies);
        }

        // POST: RentedMovies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentedMovies = await _context.RentedMovies.FindAsync(id);
            _context.RentedMovies.Remove(rentedMovies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentedMoviesExists(int id)
        {
            return _context.RentedMovies.Any(e => e.RMID == id);
        }
    }
}
