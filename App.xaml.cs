namespace MiAgendaEscolar;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Inicializar la base de datos
        // Database.Initialize();

        // Establecer la página principal
        MainPage = new AppShell();
    }    
}