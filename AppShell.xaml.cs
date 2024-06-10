using RezeptRadar.Pages;

namespace RezeptRadar
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("RezeptSeite", typeof(RezeptSeite));
           
        }
    }
}
