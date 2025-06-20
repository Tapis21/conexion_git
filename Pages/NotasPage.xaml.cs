namespace MiAgendaEscolar.Pages;

public partial class NotasPage : ContentPage
{
    private string ultimaNota = "";

    public NotasPage()
    {
        InitializeComponent();
    }

    private void GuardarNota_Clicked(object sender, EventArgs e)
    {
        ultimaNota = NotaEditor.Text;
        NotaMostrada.Text = ultimaNota;
        DisplayAlert("Nota guardada", "Tu nota ha sido guardada temporalmente.", "OK");
    }
}
