using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystem.Data;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Controllers
{
    public class RoomStatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RoomStatus
        public async Task<IActionResult> Index()
        {
              return _context.RoomStatusModel != null ? 
                          View(await _context.RoomStatusModel.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.RoomStatusModel'  is null.");
        }

        // GET: RoomStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RoomStatusModel == null)
            {
                return NotFound();
            }

            var roomStatusModel = await _context.RoomStatusModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomStatusModel == null)
            {
                return NotFound();
            }

            return View(roomStatusModel);
        }

        // GET: RoomStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoomStatusId,RoomStatusName")] RoomStatusModel roomStatusModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomStatusModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomStatusModel);
        }

        // GET: RoomStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RoomStatusModel == null)
            {
                return NotFound();
            }

            var roomStatusModel = await _context.RoomStatusModel.FindAsync(id);
            if (roomStatusModel == null)
            {
                return NotFound();
            }
            return View(roomStatusModel);
        }

        // POST: RoomStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoomStatusId,RoomStatusName")] RoomStatusModel roomStatusModel)
        {
            if (id != roomStatusModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomStatusModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomStatusModelExists(roomStatusModel.Id))
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
            return View(roomStatusModel);
        }

        // GET: RoomStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RoomStatusModel == null)
            {
                return NotFound();
            }

            var roomStatusModel = await _context.RoomStatusModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomStatusModel == null)
            {
                return NotFound();
            }

            return View(roomStatusModel);
        }

        // POST: RoomStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RoomStatusModel == null)
            {
                return Problem("Entity set 'ApplicationDbContext.RoomStatusModel'  is null.");
            }
            var roomStatusModel = await _context.RoomStatusModel.FindAsync(id);
            if (roomStatusModel != null)
            {
                _context.RoomStatusModel.Remove(roomStatusModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomStatusModelExists(int id)
        {
          return (_context.RoomStatusModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
