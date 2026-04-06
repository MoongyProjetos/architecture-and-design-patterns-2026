namespace AspireApp.Model.PadraoComportamental.Visitor;

//Pedido tradicional
public class PedidoNormal : IPedido
{
    public string Descricao { get; set; } = "Lanche Normal";
    public void Encomendar(IVisitor visitor)=> visitor.Visitar(this);

}