namespace MiAgendaEscolar.Pages;

public partial class TareasPage : ContentPage
{
    public TareasPage()
    {
        InitializeComponent();
        // Tareas simuladas (luego irán desde base de datos)
        var tareas = new List<Tarea>
        {
            new Tarea { Titulo = "Ejercicio 5", Materia = "Matemáticas", FechaEntrega = "2025-06-20" },
            new Tarea { Titulo = "Ensayo Revolución", Materia = "Historia", FechaEntrega = "2025-06-22" },
            new Tarea { Titulo = "App ToDo", Materia = "Programación", FechaEntrega = "2025-06-25" }
        };

        TareasList.ItemsSource = tareas;
    }

}
