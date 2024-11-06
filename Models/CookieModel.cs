using System.ComponentModel.DataAnnotations;
using CookiePage.Enums;

namespace CookiePage.Models;

public class CookieModel
{
    [Required]
    public YesNoEnum Permission { get; set; }
}