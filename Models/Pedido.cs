namespace FamiliaRojanAmaralApi.Models;

public class Pedido
{
    public long Id { get; set; }
    public required LocalRetirada LocalRetirada { get; set; }
    public required Cliente Cliente { get; set; }
    public required DateTime Nome { get; set; }
    public required Boolean Entregue { get; set; }
}