using System.Threading.Tasks;

namespace pmonterosExamen.views;

public partial class registro : ContentPage
{
	public registro(string usuario)
	{
		InitializeComponent();
        usuarioLabel.Text = "Usuario conectado: " +usuario;
    }

    private async Task Button_Clicked(object sender, EventArgs e)
    {
        
    }

    private void OnCalcularPagoClicked(object sender, EventArgs e)
    {
        const decimal costoCurso = 1500m;
        const decimal interes = 0.04m; // 4%

        if (decimal.TryParse(montoInicialEntry.Text, out decimal montoInicial))
        {
            if (montoInicial < 0 || montoInicial >= costoCurso)
            {
                DisplayAlert("Error", "El monto inicial debe ser menor a $1500 y mayor a 0.", "Aceptar");
                return;
            }

            decimal montoRestante = costoCurso - montoInicial;
            decimal interesTotal = costoCurso * interes; // 4% del total
            decimal totalCuotas = montoRestante + interesTotal;
            decimal pagoMensual = totalCuotas / 4;

            pagoMensualEntry.Text = pagoMensual.ToString("F2");
        }
        else
        {
            DisplayAlert("Error", "Ingrese un monto inicial válido.", "Aceptar");
        }
    
    }

    private async void ResumenClicked(object sender, EventArgs e)
    {
        string nombre = nombreEntry.Text?.Trim();
        string apellido = apellidoEntry.Text?.Trim();
        string edad = edadEntry.Text?.Trim();
        string pais = paisPicker.SelectedItem?.ToString();
        string ciudad = ciudadPicker.SelectedItem?.ToString();
        string fecha = fechaPicker.Date.ToString("dd/MM/yyyy");
        string pagoMensual = pagoMensualEntry.Text;


        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(edad))
        {
            await DisplayAlert("Faltan datos", "Por favor complete todos los datos", "Aceptar");
            return;
        }

        await Navigation.PushAsync(new views.resumen(nombre, apellido, edad, pais, ciudad, fecha, pagoMensual));
    }
}