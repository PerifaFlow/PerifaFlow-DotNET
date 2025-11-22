namespace PerifaFlowReal.Application.Dtos.Response;

public class UserResponse
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } =  string.Empty;
    
    public UserResponse(Guid id, string username, string email, string password)
    {
        Id = id;
        Username = username;
        Email = email;
        Password = password;
    }
}