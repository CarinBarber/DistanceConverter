using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Views;

public partial class WeightPage : ContentPage
{
    private double KeyValue = 0;

    private double g2g = 1.0;
    private double g2o = 0.0352733686;
    private double g2p = 0.00220462;
    private double g2k = 0.001;
    public WeightPage()
    {
        InitializeComponent();
        Title = "Weight Converter";
        
        ToolbarItem tbi = new ToolbarItem();
        tbi.Text = "About";
        this.ToolbarItems.Add(tbi);

        tbi.Clicked += delegate
        {
            Navigation.PushAsync(new AboutPage());
        };
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtGrams.Text = "";
        txtOunces.Text = "";
        txtPounds.Text = "";
        txtKilograms.Text = "";
    }

    private void TxtGrams_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        var isValid = double.TryParse(txtGrams.Text, out number);

        if (isValid && number != 0)
        {
            KeyValue = number / g2g;
        }
        else
        {
            KeyValue = 0;
        }    
    }

    private void TxtOunces_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        var isValid = double.TryParse(txtOunces.Text, out number);

        if (isValid && number != 0)
        {
            KeyValue = number / g2o;
        }
        else
        {
            KeyValue = 0;
        }    
    }

    private void TxtPounds_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        var isValid = double.TryParse(txtPounds.Text, out number);

        if (isValid && number != 0)
        {
            KeyValue = number / g2p;
        }
        else
        {
            KeyValue = 0;
        }    
    }

    private void TxtKilograms_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        var isValid = double.TryParse(txtKilograms.Text, out number);

        if (isValid && number != 0)
        {
            KeyValue = number / g2k;
        }
        else
        {
            KeyValue = 0;
        }    
    }

    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtGrams.Text = (KeyValue * g2g).ToString("g9");
        txtOunces.Text = (KeyValue * g2o).ToString("g9");
        txtPounds.Text = (KeyValue * g2p).ToString("g9");
        txtKilograms.Text = (KeyValue * g2k).ToString("g9");
   }
}