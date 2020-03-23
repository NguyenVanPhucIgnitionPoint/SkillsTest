using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillsTest.Data;
using SkillsTest.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillsTest.Controllers
{
    public class SkillsTestsController : Controller
    {
        private readonly SkillsTestContext _context;

        public SkillsTestsController(SkillsTestContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index(int numberQuestion, int totalQuestion)
        {
            ViewBag.numberQuestion = numberQuestion;
            ViewBag.totalQuestion = totalQuestion;
            return View();
        }

        public IActionResult Create(int CategoryId)
        {
            ViewBag.CategoryTest = CategoryId;

            var category = _context.Categories.Find(CategoryId);
            var questions = _context.Questions.Where(x => x.Category == category).ToList();
            ViewBag.Questions = questions;



            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Results")] Result result)
        {



            _context.Add(result);
            await _context.SaveChangesAsync();

            var numberQuestion = 1;
            var totalQuestion = 2;
            return RedirectToAction(nameof(Index), new { numberQuestion = numberQuestion, totalQuestion = totalQuestion });
        }
    }
}
