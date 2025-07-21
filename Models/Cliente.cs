namespace FamiliaRojanAmaralApi.Models;

public class Cliente
{
    public long Id { get; set; }
    public long? LocalRetirada { get; set; }
    public required string Nome { get; set; }
    public required string Telefone { get; set; }
}