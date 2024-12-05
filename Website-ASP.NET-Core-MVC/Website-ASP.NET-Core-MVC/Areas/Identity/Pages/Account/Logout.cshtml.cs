﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Website_ASP.NET_Core_MVC.Models;

namespace Website_ASP.NET_Core_MVC.Areas.Identity.Pages.Account
{
	public class LogoutModel : PageModel
	{
		private readonly SignInManager<User> _signInManager;
		private readonly ILogger<LogoutModel> _logger;

		public LogoutModel(SignInManager<User> signInManager, ILogger<LogoutModel> logger)
		{
			_signInManager = signInManager;
			_logger = logger;
		}

		public async Task<IActionResult> OnPost(string returnUrl = null)
		{
			await _signInManager.SignOutAsync();
			_logger.LogInformation("User logged out.");
			//return RedirectToAction("Index", "Home");

			if (returnUrl != null)
			{
				return LocalRedirect(returnUrl);
			}
			else
			{
				return RedirectToAction("Index", "Home", new { area = "" });
			}
		}
	}
}
