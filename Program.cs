using jim_membership.Admin;
using jim_membership.models;
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