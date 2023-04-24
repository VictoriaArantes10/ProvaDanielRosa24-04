using Microsoft.AspNetCore.Identity;

namespace Prova.Models;

public class ApplicationUser : IdentityUser
{
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
}
