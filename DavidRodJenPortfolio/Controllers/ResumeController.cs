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
            new Resume{Company = Company1, Position = Company2, Description = Company3},
            new Resume{Company = "CompanyTest2", Position = "PositionTest2", Description = "DescriptionTest2"}
        };

            return FullResume;

        }

        string Company1 = "DXC Technologies- Redmond Microsoft Campus-Seattle, WA February 2020- Present";
        string Company2 = "Senior Field Technician IT/Audio Visual";
        string Company3 = "Self-managing time and equipment under directive of senior regional managers. " +
            "Engage in remote and onsite IT solutions, Quick Assist and streamlined " +
            "solutions via accessible assortment of technical libraries of documentation. " +
            "Solve a variety of issues regarding VPN connections and application hang/crash/freeze. " +
            "Perform client and contract requests by traveling abroad to perform onsite training. " +
            "Flexibility and team leadership roles pertaining to special onsite conference support and " +
            "understanding of technical documents.Signal flow expertise pertaining to Microsoft Conference " +
            "standardization with both new and legacy control devices.Remote services through " +
            "Crestron system programming utilizing IP address notation.";

        string Position1 = "";
        string Position2 = "";
        string Position3 = "";

        string Description1 = "";
        string Description2 = "";
        string Description3 = "";



    }
}
