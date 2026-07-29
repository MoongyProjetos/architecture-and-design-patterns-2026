namespace AspireApp.Model.PadraoComportamental.Visitor;

//Pedido tradicional
public class HappyMeal : IPedido
{
    public string Descricao { get; set; } = "Lanche Infantil";
    public string Brinquedo { get; set; } = "Bonequinho";
    //.... outras propriedades específicas dessa classe
    public void Encomendar(IVisitor visitor)=> visitor.Visitar(this);

}