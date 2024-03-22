using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unifaat.ProjetoTeste.Data;
using Unifaat.ProjetoTeste.Models;

namespace Unifaat.ProjetoTeste.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        public readonly UserManager<Usuario> _userManager;
        public readonly SignInManager<Usuario> _signInManager;
        public readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            var usuarios = await _userManager.Users.OrderBy(u => u.NomeCompleto).ToListAsync();
            return View(usuarios);
        }

        //HTTPGET fazer o login do usuário 
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            //logout
            await _signInManager.SignOutAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string senha)
        {
            var user = await _userManager.FindByEmailAsync(email);

            var result = await _signInManager.PasswordSignInAsync(user, senha, false, false);
            if (result.Succeeded)
            {
               
                return  RedirectToAction(nameof(Index), "Home");
            }
            else
            {
                return View();
            }
        }


    }
}
