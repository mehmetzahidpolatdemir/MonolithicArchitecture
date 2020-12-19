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
        private IUserManager _userManager = new UserManager();
      
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetList()
        {
            var checList = _userManager.GetList();
            return Json(checList.Data);
        }

        public IActionResult Add(User user)
        {
            var isAdded = _userManager.Add(user);

            if (!isAdded.IsSuccess)
            {
                foreach (var message in isAdded.Messages)
                {
                    ModelState.AddModelError(message.Key, message.Message);
                }
            }
            
           return View();
        }
         

    }
}
