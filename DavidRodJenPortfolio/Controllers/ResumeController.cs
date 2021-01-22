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
            new Resume{Company = Company1, Position = Position1, Description = Description1},
            new Resume{Company = Company2, Position = Position2, Description = Description2},
            new Resume{Company = Company3, Position = Position3, Description = Description3},
            new Resume{Company = Company4, Position = Position4, Description = Description4}
        };

            return FullResume;

        }

        readonly string Company1 = "DXC Technologies- Redmond Microsoft Campus-Seattle, WA February 2020- Present";
        readonly string Position1 = "Senior Field Technician IT/Audio Visual";
        readonly string Description1 = "     Self-managing time and equipment under directive of senior regional managers. " +
            "Engage in remote and onsite IT solutions, Quick Assist and streamlined " +
            "solutions via accessible assortment of technical libraries of documentation. " +
            "Solve a variety of issues regarding VPN connections and application hang/crash/freeze. " +
            "Perform client and contract requests by traveling abroad to perform onsite training. " +
            "Flexibility and team leadership roles pertaining to special onsite conference support and " +
            "understanding of technical documents.Signal flow expertise pertaining to Microsoft Conference " +
            "standardization with both new and legacy control devices.Remote services through " +
            "Crestron system programming utilizing IP address notation.";



        readonly string Company2 = "Compass Group PLC- Redmond Microsoft Campus-Seattle, WA July 2015- March 2020";
        readonly string Position2 = "Audio Visual Technician/Preventative Maintenance Tier 1";
        readonly string Description2 = "     Inspect technologies and electrical equipment to insure first time quality.Daily use of " +
            "company inventory control programs.Manage personal equipment inventory utilizing basic coding " +
            "applications for programming behind network services. Provides onsite technical support for the " +
            "Microsoft Campus ensuring seamless utilization of conference and private spaces.Having a thorough " +
            "understanding of audio and visual systems.Troubleshoot and problem solve breaks in connection and " +
            "repair systems; use of network tools to correct connection issues.Connect and network with clients " +
            "from both national and international sites, assist in client day-to-day functions and provide immediate support when necessary";



        readonly string Company3 = "The Seattle Gym- Seattle, WA September 2013- June 2015";
        readonly string Position3 = "Resident Videographer";
        readonly string Description3 = "     Conduct LiveStream Media Studio capturing real-time footage for exercise video programs. " +
            "Manage all teams associated with Videography program. " +
            "Assembled and fixed exercise equipment using various types of hand, power and pneumatic tools." +
            "Participated in complete studio remodel including replacing flooring and structural repairs. " +
            "Supported the team by setting up video equipment using power and pneumatic tools. " +
            "Inspected videos and used live editing software to direct, cut and assemble footage to insure 100% customer satisfaction.";


        readonly string Company4 = "The Seattle Gym- Seattle, WA";
        readonly string Position4 = "General Manager/Billing Coordinator";
        readonly string Description4 = "     Led a service team of 35 employees.Worked with team members to streamline processes and improvements. " +
                "Led monthly safety meetings, and daily stand-up meetings. " +
                "Daily use of Microsoft Excel, Word and Outlook. " +
                "Ran individual improvement meetings for each team member and verified each employee had appropriate certifications. " +
                "Monitored, inspected and engaged in over 3200 billing accounts. " +
                "Boosted team morale by recognizing individuals.";

    }
}

       
