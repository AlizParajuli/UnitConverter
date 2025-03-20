using Microsoft.Maui.Controls;

namespace UnitConversionApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void ConvertButton_Clicked(object sender, EventArgs e)
    {
        double input;
        if (double.TryParse(InputEntry.Text, out input))
        {
            double result = 0;

            if (FromUnitPicker.SelectedItem.ToString() == "MPH" && ToUnitPicker.SelectedItem.ToString() == "KPH")
            {
                result = input * 1.60934; // Convert MPH to KPH
            }
            else if (FromUnitPicker.SelectedItem.ToString() == "KPH" && ToUnitPicker.SelectedItem.ToString() == "MPH")
            {
                result = input * 0.621371; // Convert KPH to MPH
            }

            ResultLabel.Text = $"Result: {result:F2}";
        }
        else
        {
            ResultLabel.Text = "Invalid input, please enter a valid number.";
        }
    }
}
