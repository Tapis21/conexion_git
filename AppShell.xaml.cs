using MiAgendaEscolar;
using MiAgendaEscolar.Pages;

namespace MiAgendaEscolar;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        //Rutas de navegación
        Routing.RegisterRoute(nameof(InicioPage), typeof(InicioPage));
        Routing.RegisterRoute(nameof(MateriasPage), typeof(MateriasPage));
        Routing.RegisterRoute(nameof(TareasPage), typeof(TareasPage));
        Routing.RegisterRoute(nameof(CalenarioPage), typeof(CalendarioPage));
        Routing.RegisterRoute(nameof(NotasPage), typeof(NotasPage));
    }
}
