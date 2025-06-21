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

    protected override void OnStart()
    {
        // Aquí puedes iniciar cosas como notificaciones o configuración
        Console.WriteLine("📱 App iniciada");
    }

    protected override void OnSleep()
    {
        // Aquí puedes guardar configuraciones temporales
        Console.WriteLine("😴 App en segundo plano");
    }

    protected override void OnResume()
    {
        // Aquí puedes recargar datos
        Console.WriteLine("🔄 App reanudada");
    }
}
