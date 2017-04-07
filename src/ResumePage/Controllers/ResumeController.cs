using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ResumePage.Data;
using ResumePage.Models;
using Microsoft.AspNetCore.Http;

namespace ResumePage.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResumeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Resume
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: Resume/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var resume = new ResumeViewModel();
            resume.Contact = await _context.People.FirstOrDefaultAsync(p => p.ID == id);
            resume.Educations = await _context.Education.Where(e => e.ID == id).ToListAsync();
            resume.Jobs = await _context.Job.Where(j => j.ID == id).ToListAsync();
            return View(resume);
        }

        // GET: Resume/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resume/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Resume/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Resume/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Resume/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Resume/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}