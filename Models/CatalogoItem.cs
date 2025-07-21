namespace FamiliaRojanAmaralApi.Models;

public class CatalogoItem
{
    public long Id { get; set; }
    public long Cultura { get; set; }
    
    public required string Produto { get; set; }
    public required string Descricao { get; set; }
    public int Estoque { get; set; }
    public decimal Valor { get; set; }
    public string? UrlImage { get; set; }

    public string Unidade { get; set; } = "Kg";
    public int Ordem { get; set; } = 99;
}