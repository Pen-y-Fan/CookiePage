using CookiePage.Enums;
using CookiePage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookiePage.Pages.Footer;
public class Cookie : PageModel
{
    [BindProperty] public CookieModel AcceptCookies { get; set; } = new() { Permission = YesNoEnum.No };
    public CookieModel? Result { get; private set; }
    public void OnGet()
    {
        var cookieValue = Request.Cookies["permission-cookie"];
        if (cookieValue != null && Enum.TryParse(cookieValue, out YesNoEnum cookieValueResult))
        {
            AcceptCookies.Permission = cookieValueResult;
        }
        else
        {
            AcceptCookies.Permission = YesNoEnum.No;
        }
    }
    
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        SetPermissionCookie(AcceptCookies.Permission.ToString());

        Result = AcceptCookies;
        return Page();
    }
    private void SetPermissionCookie(string permission)
    {
        Response.Cookies.Append("permission-cookie", permission, new CookieOptions
        {
            HttpOnly = false,
            Secure = true,
            SameSite = SameSiteMode.Lax,
            Expires = DateTimeOffset.UtcNow.AddMonths(6)
        });
    }
}