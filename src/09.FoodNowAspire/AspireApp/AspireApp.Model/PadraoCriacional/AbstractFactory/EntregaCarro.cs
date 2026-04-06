namespace AspireApp.Model.PadraoCriacional.AbstractFactory; 

public class EntregaCarro : EntregaAbstractFactory
{
    public override void EfetuarEntrega(){
        VerificarGasolinaTanque();
    }

    private void VerificarGasolinaTanque()
    {
        //
    }
}
