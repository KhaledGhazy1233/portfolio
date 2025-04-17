using KhaledGhazy.Models;
using Microsoft.AspNetCore.Mvc;

namespace KhaledGhazy.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            List<Project> projects = new List<Project>
            {
                    new Project
                    {
                       ProjectName = "Laptop E-Commerce ",
                       Image = "/Img/laptopphotojpeg.jpeg",
                       Description = "An online store built using ASP.NET MVC.",
                       GitHubLink = "https://github.com/KhaledGhazy1233/LaptopE-commerce"
                    },
                    new Project
                    {
                       ProjectName = "RestaurantSystem",
                       Image = "/img/RestaurantSystem.jpeg",
                       Description = "Restaurant System Building With Python(oop)" +
                       "TkinterLibrary",
                       GitHubLink = "https://github.com/KhaledGhazy1233/RestaurantSystem"
                    },
                    new Project
                    {
                       ProjectName = "CafeAndDesert Website",
                       Image = "/img/CafeAndDesert.PNG",
                       Description = "CafeAndDesertFrontEndWebSite",
                       GitHubLink = "https://github.com/KhaledGhazy1233/Cafe-Dessert"
                    },
                    new Project
                    {
                       ProjectName = "SocialMedia Website",
                       Image = "/Img/Capture090.PNG",
                       Description = "SocialMediaWebSiteUsingApis",
                       GitHubLink = "https://github.com/twoaxis/social-media-backend"
                    },
                     new Project
                    {
                       ProjectName = "DataBaseSchema,Implement",
                       Image = "/Img/Apis300.PNG",
                       Description = "DataBaseSchema,Implement" ,
                      
                       GitHubLink = "https://github.com/KhaledGhazy1233/Tasks"
                    },
            };
            return View(projects);
        }
    }
}
