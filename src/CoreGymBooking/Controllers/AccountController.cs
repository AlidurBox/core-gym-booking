using CoreGymBooking.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreGymBooking.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var user = new IdentityUser
        {
            UserName = model.Email,
            Email = model.Email
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            TempData["Bekraftelse"] = "Kontot har skapats. Du kan nu logga in.";

            return RedirectToAction(nameof(Login));
        }

        foreach (var message in result.Errors.Select(TranslateError).Distinct())
        {
            ModelState.AddModelError(string.Empty, message);
        }

        return View(model);
    }

    [HttpGet]
    public IActionResult Login(string? returnUrl = null)
    {
        ViewData["ReturnUrl"] = returnUrl;

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null)
    {
        ViewData["ReturnUrl"] = returnUrl;

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var result = await _signInManager.PasswordSignInAsync(
            model.Email,
            model.Password,
            isPersistent: false,
            lockoutOnFailure: false);

        if (result.Succeeded)
        {
            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "Home");
        }

        ModelState.AddModelError(string.Empty, "Fel e-postadress eller lösenord.");

        return View(model);
    }

    [HttpGet]
    public IActionResult AccessDenied()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();

        return RedirectToAction("Index", "Home");
    }

    private static string TranslateError(IdentityError error)
    {
        return error.Code switch
        {
            "DuplicateUserName" or "DuplicateEmail" => "E-postadressen används redan.",
            "PasswordTooShort" => "Lösenordet måste vara minst sex tecken långt.",
            "PasswordRequiresDigit" => "Lösenordet måste innehålla minst en siffra.",
            "PasswordRequiresUpper" => "Lösenordet måste innehålla minst en stor bokstav.",
            "PasswordRequiresLower" => "Lösenordet måste innehålla minst en liten bokstav.",
            "PasswordRequiresNonAlphanumeric" => "Lösenordet måste innehålla minst ett specialtecken, till exempel !",
            _ => error.Description
        };
    }
}
