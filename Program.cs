using jim_membership.Admin;
using jim_membership.models;
using jim_membership.TrainerScenario;
namespace jim_membership
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}