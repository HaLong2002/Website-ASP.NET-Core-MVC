﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Website_ASP.NET_Core_MVC.Areas.Admin.Controllers
{
	public class HomeController : Controller
	{
        [Area("Admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
		{
			return View();
		}
	}
}
