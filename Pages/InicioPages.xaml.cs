namespace MiAgendaEscolar.Pages;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        InitializeComponent();
    }
    private async void IrMaterias_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MateriasPage));
    }
}