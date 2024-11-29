namespace Herrera_Dilan_Examen_P2;

public partial class PaginaRecargas : ContentPage
{
	public PaginaRecargas()
	{
		InitializeComponent();
	}

    private void OnAgregarClicked(object sender, EventArgs e)
    {
        DisplayAlert("Aviso", "Recarga realizada correctamente", "OK");
    }
}