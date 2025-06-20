namespace MiAgendaEscolar.Pages;

public partial class MateriasPage : ContentPage
{
    public MateriasPage()
    {
        InitializeComponent();

        // Materias simuladas (luego las cargaremos desde base de datos)
        var materiasEjemplo = new List<Materia>
        {
            new Materia { Nombre = "Matemáticas", Profesor = "Prof. López" },
            new Materia { Nombre = "Historia", Profesor = "Lic. Ramírez" },
            new Materia { Nombre = "Programación", Profesor = "Ing. Torres" }
        };

        MateriasList.ItemsSource = materiasEjemplo;
    }

    private async void AgregarMateria_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Agregar", "Aquí se agregará una nueva materia (pronto)", "OK");
    }
}

// Clase de ejemplo (modelo básico)
public class Materia
{
    public string Nombre { get; set; }
    public string Profesor { get; set; }
}