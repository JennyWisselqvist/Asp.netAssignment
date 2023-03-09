using Bmerketo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bmerketo.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserService _userService;

        public AccountController(UserService userService)
        {
            _userService = userService;
        }


        public async Task<IActionResult> Index(string id)
        {
            var userAccount = await _userService.GetUserAccountAsync(id);
            return View(userAccount);
        }
    }
}