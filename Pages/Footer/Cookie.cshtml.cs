namespace CookiePage.Pages.Footer;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class Cookie : PageModel
{
    [BindProperty] public string? AcceptCookies { get; set; }

    public string? Result { get; private set; }

    public void OnGet()
    {
        var cookieValue = Request.Cookies["permission-cookie"];
        if (cookieValue != null)
        {
            AcceptCookies = cookieValue == "true" ? "yes" : "no";
        }
        else
        {
            AcceptCookies = "yes";
        }

        // Logic for GET
    }

    public IActionResult OnPost()
    {
        SetPermissionCookie(AcceptCookies?.ToLower() == "yes" ? "true" : "false");

        Result = AcceptCookies;
        return Page();
    }

    private void SetPermissionCookie(string permission)
    {
        Response.Cookies.Append("permission-cookie", permission, new CookieOptions
        {
            Path = "/",
            HttpOnly = false,
            Secure = true,
            SameSite = SameSiteMode.Lax
        });
    }
}