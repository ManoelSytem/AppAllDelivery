using AllDelivery.Models;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Controls;

namespace AllDelivery.Pages;

public partial class FuncionalidadePage : ContentPage
{
    public List<Funcionalidades> Funcionalidades { get; set; }
    public List<string> Addresses { get; set; }
    private double height = 0;
    private double width = 0;

    public FuncionalidadePage()
    {
       
        InitializeComponent();
        LoadData();
        BindingContext = this;
    }
    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        this.width = width;
        this.height = height;
    }

    private void LoadData()
    {


        Funcionalidades = new List<Funcionalidades>
          {
               new Funcionalidades
               {
                    Id = 1,
                    Header = "header1.jpg",
                    Name = "Gerenciar Mesa",
                   
               },
               new Funcionalidades
               {
                    Id = 2,
                    Header = "header2.jpg",
                    Name = "Conta",
               },
              
          };

        lstfuncs.ItemsSource = Funcionalidades;


        Addresses = new List<string>()
          {
               "Manhã",
               "Tarde",
               "Noite",
               "Madrugada"
          };

        CurrentAddress.Text = Addresses.FirstOrDefault();

    }

    private void SelectAddress_Clicked(object sender, EventArgs e)
    {
        addressesList.TranslateTo(0, height, 500, Easing.SinIn);
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        addressesList.TranslateTo(0, 0, 500, Easing.SinOut);
    }

    private void Address_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var selectedAddress = (RadioButton)sender;
        CurrentAddress.Text = selectedAddress.Content.ToString();
    }

    private void lstStores_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Navigation.PushAsync(new StorePage());
    }

}