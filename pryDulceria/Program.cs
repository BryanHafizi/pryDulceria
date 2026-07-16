namespace pryDulceria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new frmMenuPrincipal());
            /* To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (frmInicioSesion login = new frmInicioSesion())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmMenuPrincipal());
                }
            }
            */
        }
    }
}