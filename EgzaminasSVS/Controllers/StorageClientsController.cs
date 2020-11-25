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
    public class StorageClientsController : Controller
    {
        private readonly StorageContext _context;

        public StorageClientsController(StorageContext context)
        {
            _context = context;
        }

        // GET: StorageClients
        public async Task<IActionResult> Index()
        {
            return View(await _context.StorageClient.ToListAsync());
        }

        // GET: StorageClients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storageClient = await _context.StorageClient
                .FirstOrDefaultAsync(m => m.Id == id);
            if (storageClient == null)
            {
                return NotFound();
            }

            return View(storageClient);
        }

        // GET: StorageClients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StorageClients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,DateOfBirth,Phone,ClientType")] StorageClient storageClient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(storageClient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(storageClient);
        }

        private bool StorageClientExists(int id)
        {
            return _context.StorageClient.Any(e => e.Id == id);
        }
    }
}
