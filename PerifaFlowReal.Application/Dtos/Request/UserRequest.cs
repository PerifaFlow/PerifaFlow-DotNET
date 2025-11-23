using System.ComponentModel.DataAnnotations;
using PerifaFlow.Domain.Entities;

namespace PerifaFlowReal.Application.Dtos.Request;

public class UserRequest
{
    [Required(ErrorMessage = "É necessário um nome de Usuário")]
    public string Username { get; set; }
    
    [Required(ErrorMessage = "É necessário um nome de Usuário")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "É necessário um nome de Usuário")]
    public string Password { get; set; }

    public User ToDomain()
    {
        return new User(Username, Email, Password);
    }
}