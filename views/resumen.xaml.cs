namespace pmonterosExamen.views;

public partial class resumen : ContentPage
{
	public resumen(string nombre,string apellido,string edad,string pais,string ciudad,string fecha,string pagoMensual)
	{
		InitializeComponent();
		lblResumen.Text = "Nombre: "+ nombre + "\n" +
			"Apellido: " + apellido + "\n" +
			"Edad: " + edad + "\n" + 
			"Pais: " + pais + "\n" +
			"Ciudad" + ciudad + "\n" + 
			"Fecha: " + fecha + "\n"
			+ "Pago Mensual: " + pagoMensual;
	}
}