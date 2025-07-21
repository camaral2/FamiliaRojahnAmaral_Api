namespace FamiliaRojanAmaralApi.Models;

public class User
{
    public int id { get; set; }
    public string email { get; set; } = string.Empty;
    public string password { get; set; } = string.Empty;
    public bool isActive { get; set; } = true;
    public DateTime created_at { get; set;}
    public string? phone { get; set; } = string.Empty;

}
