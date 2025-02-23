using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Views;


public partial class DistancePage : ContentPage
{     
    private double KeyValue = 0;
    private double m2f = 3.280839; 
    private double m2i = 39.37007874; 
    private double m2mi = 0.00062137119; 
    private double m2m = 1.0; 
    private double m2nm = 0.0005399568034557; 
    private double m2y = 1.093613298; 
    private double m2k = 0.001;
         
    public DistancePage()
    {
        InitializeComponent();
        Title = "Distance Converter";

        ToolbarItem tbi = new ToolbarItem();
        tbi.Text = "About";
        this.ToolbarItems.Add(tbi);

        tbi.Clicked += delegate
        {
            Navigation.PushAsync(new AboutPage());
        };
    }

    private void BtnClear_OnClicked(object sender, EventArgs e)
    {
        txtFeet.Text = "";
        txtInches.Text = "";
        txtMeters.Text = "";
        txtYards.Text = "";
        txtMiles.Text = "";
        txtNautical.Text = "";
        txtKilometers.Text = "";
    }

    private void TxtYards_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        var isValid = double.TryParse(txtYards.Text, out number);

        if (isValid && number != 0)
        {
            KeyValue = number / m2y;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtMiles_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        var isValid = double.TryParse(txtMiles.Text, out number);

        if (isValid && number != 0)
        {
            KeyValue = number / m2mi;
        }
        else
        {
            KeyValue = 0;
        }    }

    private void TxtNautical_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        var isValid = double.TryParse(txtNautical.Text, out number);

        if (isValid && number != 0)
        {
            KeyValue = number / m2nm;
        }
        else
        {
            KeyValue = 0;
        }    
    }

    private void TxtKilometers_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        var isValid = double.TryParse(txtKilometers.Text, out number);

        if (isValid && number != 0)
        {
            KeyValue = number / m2k;
        }
        else
        {
            KeyValue = 0;
        }    
    }

    private void TxtFeet_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        var isValid = double.TryParse(txtFeet.Text, out number);

        if (isValid && number != 0)
        {
            KeyValue = number / m2f;
        }
        else
        {
            KeyValue = 0;
        }    }

    private void TxtInches_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        var isValid = double.TryParse(txtInches.Text, out number);

        if (isValid && number != 0)
        {
            KeyValue = number / m2i;
        }
        else
        {
            KeyValue = 0;
        }    }

    private void TxtMeters_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        var isValid = double.TryParse(txtMeters.Text, out number);

        if (isValid && number != 0 )
        {
            KeyValue = number / m2m;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void BtnConvert_OnClicked(object sender, EventArgs e)
    {
        txtFeet.Text = (KeyValue * m2f).ToString("g9");
        txtInches.Text = (KeyValue * m2i).ToString("g9");
        txtMeters.Text = (KeyValue * m2m).ToString("g9");
        txtYards.Text = (KeyValue * m2y).ToString("g9");
        txtMiles.Text = (KeyValue * m2mi).ToString("g9");
        txtNautical.Text = (KeyValue * m2nm).ToString("g9");
        txtKilometers.Text = (KeyValue * m2k).ToString("g9");
    }
}