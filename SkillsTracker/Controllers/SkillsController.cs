using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/skills'>" +
                          "<h1>Skills Tracker</h1>" +
                          "<h2>Coding skils to learn:</h2>" +
                          "<ol>1. C#</ol>" +
                          "<ol>2. JavaScript</ol>" +
                          "<ol>3. Python</ol>" +
                          "</form>";

            return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/skills/form")]
        public IActionResult FormResult(string date, string cLanguage, string javaScript, string python)
        {
            return Content("<h1>" + date + " C#: " + cLanguage + " JavaScript: " + javaScript + " Python: " + python + "</h1>", "text/html");
        }

        [HttpGet]
        [Route("/skills/form")]
        public IActionResult FormSelect()
        {
            string html = "<form method='post' action='/skills/form'>" +
                          "<label>Date:</label>\n" +
                          "<input type= 'date' name = 'date' value = 'mm / dd / yyy'>\n" +
                          "<label>C#:</label>\n" +
                          "<select name = 'cLanguage':>" +
                            "<option>making apps</option>" +
                            "<option>master coder</option>" +
                            "<option>learning basics</option>" +
                          "</select>\n" +
                          "<label>JavaScript:</label>\n" +
                          "<select name = 'javaScript':>" +
                            "<option>making apps</option>" +
                            "<option>master coder</option>" +
                            "<option>learning basics</option>" +
                          "</select>\n" +
                          "<label>Python:</label>\n" +
                          "<select name = 'python':>" +
                            "<option>making apps</option>" +
                            "<option>master coder</option>" +
                            "<option>learning basics</option>" +
                          "</select>\n" +
                          "<input type='submit' value='Submit' />";

            return Content(html, "text/html");
        }
    }
}
