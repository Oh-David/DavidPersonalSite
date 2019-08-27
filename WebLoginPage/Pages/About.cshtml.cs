using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebLoginPage.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Passionate about gathering data and learning about the world around us through data. I am experienced in gathering data using tools such as web scraping and data mining from various sources.Developing databases to house data. Cleaning data so it can be analyzed.And either creating data visualization dashobards, or further processing data using various statistical models and machine learning algorithms to learn about what the data can tell us. There are amazing stories to be told that may be hidden in the data you posses, contact me if you'd like me to discover your data's story.";
        }
    }
}
