namespace MiAgendaEscolar.Pages;

public partial class CalendarioPage : ContentPage
{
    public CalendarioPage()
    {
        InitializeComponent();
    }
    private void SelectorFecha_DateSelected(object sender, DateChangedEventArgs e)
    {
        var fechaSeleccionada = e.NewDate.ToString("dddd, dd MMMM yyyy");
        LabelInfo.Text = $"No hay tareas programadas para {fechaSeleccionada}";
    }
}
