namespace pmonterosExamen.views;

public partial class login : ContentPage
{
    string[,] credenciales = new string[2, 2]
    {
        { "estudiante", "moviles" },
        { "uisrael", "2024" }
    };
    public login()
	{
		InitializeComponent();
	}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string usuario = usuarioEntry.Text;
        string contrasena = contrasenaEntry.Text?.Trim();
        bool encontrado = false;

        for (int i = 0; i < 2; i++)
        {
            if (credenciales[i, 0] == usuario && credenciales[i, 1] == contrasena)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            await Navigation.PushAsync(new views.registro(usuario));
        }
        else
        {
            await DisplayAlert("Error", "Dato incorrecto", "Aceptar");
        }
    }
}