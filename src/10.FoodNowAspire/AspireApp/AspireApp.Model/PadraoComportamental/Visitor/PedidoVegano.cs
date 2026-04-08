namespace AspireApp.Model.PadraoComportamental.Visitor;

//Pedido tradicional
public class PedidoVegano : IPedido
{
    public string Descricao { get; set; } = "Lanche Vegano";
    public void Encomendar(IVisitor visitor)=> visitor.Visitar(this);

}