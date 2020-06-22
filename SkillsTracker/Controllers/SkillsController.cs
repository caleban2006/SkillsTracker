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
                          "<ol>" +
                            "<li>C#</li>" +
                            "<li>JavaScript</li>" +
                            "<li>Python</li>" +
                          "</ol>" +
                          "</form>";

            return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/skills/form")]
        public IActionResult FormResult(string date, string cLanguage, string javaScript, string python)
        {
            string html = $"<h1>{date}</h1>" +
                          $"<ol>" +
                            $"<li>C#: {cLanguage}</li>" +
                            $"<li>JavaScript: {javaScript}</li>" +
                            $"<li>Python: {python}</li>" +
                          $"</ol>";
            
            return Content(html, "text/html");
        }

        [HttpGet]
        [Route("/skills/form")]
        public IActionResult FormSelect()
        {
            string html = "<form method='post' action='/skills/form'>" +
                          "<label>Date:</label>" +
                          "<br>" +
                          "<input type= 'date' name = 'date' value = 'mm / dd / yyy'>" +
                          "<br>" +
                          "<label>C#:</label>" +
                          "<br>" +
                          "<select name = 'cLanguage':>" +
                            "<option>making apps</option>" +
                            "<option>master coder</option>" +
                            "<option>learning basics</option>" +
                          "</select>" +
                          "<br>" +
                          "<label>JavaScript:</label>" +
                          "<br>" +
                          "<select name = 'javaScript':>" +
                            "<option>making apps</option>" +
                            "<option>master coder</option>" +
                            "<option>learning basics</option>" +
                          "</select>" +
                          "<br>" +
                          "<label>Python:</label>" +
                          "<br>" +
                          "<select name = 'python':>" +
                            "<option>making apps</option>" +
                            "<option>master coder</option>" +
                            "<option>learning basics</option>" +
                          "</select>" +
                          "<br>" +
                          "<input type='submit' value='Submit'/>";

            return Content(html, "text/html");
        }
    }
}
