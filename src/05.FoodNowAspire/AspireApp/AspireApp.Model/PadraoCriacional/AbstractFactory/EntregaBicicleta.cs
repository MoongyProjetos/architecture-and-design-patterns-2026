namespace AspireApp.Model.PadraoCriacional.AbstractFactory; 

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
