using MauiPractica.View;

namespace MauiPractica
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("departamentoDetalle", typeof(DepartamentoDetalleView));
            Routing.RegisterRoute("empleadoDetalle", typeof(MainDetalleView));

        }
    }
}
