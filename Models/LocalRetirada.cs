namespace FamiliaRojanAmaralApi.Models;

public class LocalRetirada
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    public string Dias_horarios { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;

}
