using BookLibrary.Infrastructure.Commands.User;
using BookLibrary.Infrastructure.Services.Interfaces;
using BookLibrary.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            _logger.LogInformation($"Connected by: {HttpContext.Connection.Id}");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LogInUser command)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", command);
            }

            var areCredentialsValid = await _userService.IsValid(command);

            if (areCredentialsValid)
            {
                var id = await _userService.GetIdByLogin(command.Login);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, command.Login),
                    new Claim(ClaimTypes.NameIdentifier, id.ToString())
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties();

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                return Redirect("Index");
            }

            return Ok(command);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}