// src/Sia-DC-09-Server/Models/RefreshToken.cs
namespace Sia_DC_09_Server.Models;

public class RefreshToken
{
    public int Id { get; set; }
    public string Token { get; set; } = Guid.NewGuid().ToString(); // уникальный токен
    public string Username { get; set; } = string.Empty;
    public DateTime Expiry { get; set; }
    public bool IsRevoked { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}