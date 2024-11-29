using Herrera_Dilan_Examen_P2.Models;
using Herrera_Dilan_Examen_P2.Repositories;

namespace Herrera_Dilan_Examen_P2;

public partial class PaginaRecargas : ContentPage
{
    public Recarga recarga;
    RecargasFilesRepository _repository;
	public PaginaRecargas()
	{
		InitializeComponent();
        _repository = new RecargasFilesRepository();
        recarga = _repository.ObtenerUltimaRecarga();

        BindingContext = recarga;
	}

    private void OnAgregarClicked(object sender, EventArgs e)
    {
        DisplayAlert("Aviso", "Recarga realizada correctamente", "OK");
        _repository.CrearRecarga(recarga);
    }
}