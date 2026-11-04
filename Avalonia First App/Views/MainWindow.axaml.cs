using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace Avalonia_First_App.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private
        void Button_Onclick(object sender, KeyEventArgs e) {
        if (e.Key == Key.Enter && sender is TextBox Celsius)
        {
            if (double.TryParse(Celsius.Text, out double C))
            {
                var F = C * (9d / 5d) + 32;
                Fahrenheit.Text = F.ToString("0.0");
            }
            else
            {
                Celsius.Text = "0";
                Fahrenheit.Text = "0";
            }
        }
    }

    void FahrenheitConverter(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter && sender is TextBox Fahrenheit)
        {
            if (double.TryParse(Fahrenheit.Text, out double F))
            {
                var C = (F - 32) * (5d / 9d);
                Celsius.Text = C.ToString("0.0");
            }
            else
            {
                Celsius.Text = "0";
                Fahrenheit.Text = "0";
            }
        }
    }
}