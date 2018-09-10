using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeSystem.Models;

namespace EmployeeSystem.Controllers
{
    public class EmployeeDatasController : Controller
    {
        private readonly EmployeeSystemContext _context;

        public EmployeeDatasController(EmployeeSystemContext context)
        {
            _context = context;
        }

        // GET: EmployeeDatas
        public async Task<IActionResult> Index()
        {
            var employeeSystemContext = _context.EmployeeData.Include(e => e.Department);
            return View(await employeeSystemContext.ToListAsync());
        }

        // GET: EmployeeDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeData = await _context.EmployeeData
                .Include(e => e.Department)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (employeeData == null)
            {
                return NotFound();
            }

            return View(employeeData);
        }

        // GET: EmployeeDatas/Create
        public IActionResult Create()
        {
            ViewData["DepartmentID"] = new SelectList(_context.Set<Department>(), "ID", "ID");
            return View();
        }

        // POST: EmployeeDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Surname,Address,Qualification,Phnno,DepartmentID")] EmployeeData employeeData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentID"] = new SelectList(_context.Set<Department>(), "ID", "ID", employeeData.DepartmentID);
            return View(employeeData);
        }

        // GET: EmployeeDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeData = await _context.EmployeeData.FindAsync(id);
            if (employeeData == null)
            {
                return NotFound();
            }
            ViewData["DepartmentID"] = new SelectList(_context.Set<Department>(), "ID", "ID", employeeData.DepartmentID);
            return View(employeeData);
        }

        // POST: EmployeeDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Surname,Address,Qualification,Phnno,DepartmentID")] EmployeeData employeeData)
        {
            if (id != employeeData.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeDataExists(employeeData.ID))
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
            ViewData["DepartmentID"] = new SelectList(_context.Set<Department>(), "ID", "ID", employeeData.DepartmentID);
            return View(employeeData);
        }

        // GET: EmployeeDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeData = await _context.EmployeeData
                .Include(e => e.Department)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (employeeData == null)
            {
                return NotFound();
            }

            return View(employeeData);
        }

        // POST: EmployeeDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeData = await _context.EmployeeData.FindAsync(id);
            _context.EmployeeData.Remove(employeeData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeDataExists(int id)
        {
            return _context.EmployeeData.Any(e => e.ID == id);
        }
    }
}
