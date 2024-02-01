using System.Windows;
using System.Windows.Controls.Primitives;

namespace obfuscation_demo;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void RepeatButton_OnClick(object sender, RoutedEventArgs e)
    {
        var repeatButton = (RepeatButton)sender;
        switch (repeatButton.Name)
        {
            case "LeftButton":
                Slider.Value -= 10;
                break;
            case "RightButton":
                Slider.Value += 10;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}