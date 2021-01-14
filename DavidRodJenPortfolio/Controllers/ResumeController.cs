using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DavidRodJenPortfolio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace DavidRodJenPortfolio.Controllers
{
    public class ResumeController : Controller
    {

        public IActionResult Resume()
        {
            ViewBag.ResumeBag = GetAllExperience<IList>();
            return View();
        }

        public IList<Resume> GetAllExperience<IList>()
        {
            List<Resume> FullResume = new List<Resume>()
        {
            new Resume{Company = "CompanyTest", Position = "PositionTest", Description = "DescriptionTest"},
            new Resume{Company = "CompanyTest2", Position = "PositionTest2", Description = "DescriptionTest2"}
        };

            return FullResume;

        }

    }
}
