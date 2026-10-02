namespace Reto2RutaTesoro;

static class Program
{
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmRutaTesoro());
    }    
}