namespace XiGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.SetDefaultFont(new Font("Consolas", 15));
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}