namespace FamiliaRojanAmaralApi.Models;

public class PedidoItem
{
    public long Id { get; set; }
    public required Pedido Pedido { get; set; }
    public required CatalogoItem Item { get; set; }
    public required decimal Quantidade { get; set; }
    public required decimal ValorUnitario { get; set; }
}