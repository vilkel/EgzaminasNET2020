using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EgzaminasSVS.Data;
using EgzaminasSVS.Models;

namespace EgzaminasSVS.Controllers
{
    public class StorageItemsController : Controller
    {
        private readonly StorageContext _context;

        public StorageItemsController(StorageContext context)
        {
            _context = context;
        }

        // GET: StorageItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.StorageItem.ToListAsync());
        }

        // GET: StorageItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storageItem = await _context.StorageItem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (storageItem == null)
            {
                return NotFound();
            }

            return View(storageItem);
        }

        // GET: StorageItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StorageItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ItemName,ItemWeight,StorageSector,PlacementDate")] StorageItem storageItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(storageItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(storageItem);
        }

        private bool StorageItemExists(int id)
        {
            return _context.StorageItem.Any(e => e.Id == id);
        }
    }
}
