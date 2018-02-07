using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HereAreTheClothesYouWant.Services;
using HereAreTheClothesYouWant.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HereAreTheClothesYouWant.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Products()
        {
            ViewBag.Title = "Our Products";
            return View();
        }

        [HttpGet("SignUp")]
        public IActionResult Signup()
        {
            ViewBag.Title = "Sign Up Here";
            return View();
        }


        [HttpPost("SignUp")]
        public IActionResult Signup(SignupViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.sendMessage("me@gmail.com", model.FirstName, model.Address);
            }
            
            return View();
        }
    }
}
