// Index.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ResumeTemplater.Pages
{
    public class IndexModel : PageModel
    {
        //Properties
        public string FullName { get; set; }
        public string LinkedInUsername { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> Languages { get; set; }
        public string GithubUsername { get; set; }

        //Method
        public void OnGet()
        {
            FullName = "Makiko Vaughan";
            LinkedInUsername = "makiko-vaughan";
            YearsOfExperience = 8;
            Languages = new List<string> { "JavaScript", "Java", "HTML" };
            GithubUsername = "makikovaughan";
        }
    }
}