namespace  AspireApp.Services.Entrega; 

public class EntregaBicicleta : EntregaAbstractFactory
{
    public override void EfetuarEntrega(){
        VerificarPressaoPneu();
        VerificarCapacidadeCaixa();
    }

    private void VerificarPressaoPneu()
    {
        //
    }

    private void VerificarCapacidadeCaixa()
    {
        //
    }
}
