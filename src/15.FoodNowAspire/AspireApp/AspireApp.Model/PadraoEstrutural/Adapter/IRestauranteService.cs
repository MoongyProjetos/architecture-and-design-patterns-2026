namespace AspireApp.Model.PadraoEstrutural.Adapter; 


// Interface padrão do sistema
public interface IRestauranteService
{
     RestauranteDetalhe ObterRestaurante(Guid id);
}