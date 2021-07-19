using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()

        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding skills to learn</h2>" +
                "<ol>" +
                "<li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>JavaScriptn</li>";

            return Content(html, "text/html");
        }

        [HttpGet]
        public IActionResult Form()
        {
            string html = "<form method='post' action='/skills/form'>" +
                "<label>Date</label>" +
                "<input type='date' name='date' />" +
                "<label style='display:block;padding:5px;'>C#</label>" + "<select name='skillLevelCSharp'><option selected>Learning Basics</option><option>Intermediate</option>" +
                "<option>Superstar</option></select>" +
                "<label style='display:block;padding:5px;'>JavaScript</label>" + "<select name='skillLevelJavaScript'><option selected>Learning Basics</option><option>Intermediate</option>" +
                "<option>Superstar</option></select>" +
                "<label style='display:block;padding:5px;'>Python</label>" + "<select name='skillLevelPython'><option selected>Learning Basics</option><option'>Intermediate</option>" +
                "<option>Superstar</option></select>" +
                "<input type='submit' value='Submit' style='display:block;margin:5px;' />" +
                "</form>";

            return Content(html, "text/html");
        }

        [HttpPost("/skills/form")]
        public IActionResult PostForm(string date, string skillLevelCSharp, string skillLevelJavaScript, string skillLevelPython)
        {
            string html = "<h1>" + date + "</h1>" +
               
                "<ol>" +
                "<li>C#: " + skillLevelCSharp  + "</li>" +
                "<li>JavaScript: " + skillLevelJavaScript + "</li>" +
                "<li>Python: " + skillLevelPython + "</li>";

            return Content(html, "text/html");
        }


    }
}
