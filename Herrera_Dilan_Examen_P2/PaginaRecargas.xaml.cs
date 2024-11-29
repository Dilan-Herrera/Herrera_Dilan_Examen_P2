using Herrera_Dilan_Examen_P2.Models;
using Herrera_Dilan_Examen_P2.Repositories;

namespace Herrera_Dilan_Examen_P2;

public partial class PaginaRecargas : ContentPage
{
    RecargasFilesRepository _repository;

    public PaginaRecargas()
    {
        InitializeComponent();

        _repository = new RecargasFilesRepository();
        UltimaRecargaLabel.Text = _repository.ObtenerUltimaRecargaFormateada();
    }

    private void OnAgregarClicked(object sender, EventArgs e)
    {
        var nombre = NombreEntry.Text;
        var numero = NumeroEntry.Text;

        if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(numero))
        {
            DisplayAlert("Error", "Por favor complete ambos campos", "OK");
            return;
        }

        var nuevaRecarga = new Recarga
        {
            Nombre = nombre,
            Numero = numero
        };

        var guardado = _repository.CrearRecarga(nuevaRecarga);

        if (guardado)
        {
            DisplayAlert("Éxito", "Recarga realizada correctamente", "OK");
            UltimaRecargaLabel.Text = _repository.ObtenerUltimaRecargaFormateada();
        }
        else
        {
            DisplayAlert("Error", "No se pudo realizar la recarga", "OK");
        }
    }
}
