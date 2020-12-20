using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KluCareer.BusineesLayer.Abstract;
using KluCareer.BusineesLayer.Concrate;
using KluCareer.BusineesLayer.Result;
using KluCareer.Entities.Concrate.Models;
using Microsoft.AspNetCore.Mvc;

namespace KluCareer.WebMvc.Controllers
{
    public class UserController : Controller
    {
        private IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var user = new User
            {
                UserName = "reşit",
                Password = "123",
            };
            IResult checkResult = _userManager.Add(user);


            return View();
        }

      
      
        public JsonResult GetListFullInclude()
        {
            var checList = _userManager.GetListFullInclude();
            return Json(checList.Data);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            var isAdded = _userManager.Add(user);

            if (!isAdded.IsSuccess)
            {
                ViewBag.error = isAdded.Messages;
            }

            return View();
        }


    }
}
