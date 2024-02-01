using System.Windows;
using System.Windows.Threading;

namespace obfuscation_demo;

public partial class App
{
    public App()
    {
        Current.DispatcherUnhandledException += HandleException;
    }

    private static void HandleException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        MessageBox.Show(e.Exception.Message);
        e.Handled = true;
    }
}