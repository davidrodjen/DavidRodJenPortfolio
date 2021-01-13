using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DavidRodJenPortfolio.Models;

namespace DavidRodJenPortfolio.Controllers
{
    public class ResumeController : Controller
    {
        //private readonly ApplicationDbContext _Context;

        //public ResumeController(ApplicationDbContext Context)
        //{
        //    _Context = Context;
        //}
        //public async Task<IActionResult> Resume()
        //{
        //    ViewBag.ResumeBag = await ResumeDB.GetAllExperience(_Context);
        //    return View();
        //}

        public IActionResult Resume()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Add(Resume resume)
        {
            //if (ModelState.IsValid)
            //{
            //    await resumeDB.Add(resume, _Context);
            //    //TempData["Message"] = $"{resume.Title} added successfully";
            //    return RedirectToAction(nameof(ResumeIndex));
            //}

            return View();
        }


        public async Task<IActionResult> ResumeIndex()
        {
            //ViewBag.ResumeBag = await ResumeDB.GetAllExperience(_Context);
            return View();
        }
    }
}
