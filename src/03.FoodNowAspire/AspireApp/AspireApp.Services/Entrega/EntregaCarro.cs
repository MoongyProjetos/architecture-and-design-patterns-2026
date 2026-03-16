namespace  AspireApp.Services.Entrega; 

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
