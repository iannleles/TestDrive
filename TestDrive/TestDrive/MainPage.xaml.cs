using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestDrive
{

    //public class Pais
    //{
    //    public string Nome { get; set; }
    //}

    public class Veiculo
    {
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string PrecoFormatado
        {

            get { return string.Format("R$ {0}", Preco); }

        }




    }


    //public partial class MainPage : ContentPage

    //{
    //    public List<Pais> Paises { get; set; }

    //    public MainPage()
    //    {
    //        InitializeComponent();

    //        this.Paises = new List<Pais>
    //                {
    //                    new Pais {Nome = "Brasil"},
    //                    new Pais {Nome = "Argentina"},
    //                    new Pais {Nome = "Colômbia"}

    //                };

    //        this.BindingContext = this;
    //    }

    //    private void listViewPaises_ItemTapped(object sender, ItemTappedEventArgs e)
    //    {
    //        var paises = (Pais)e.Item;
    //        DisplayAlert("Atenção", string.Format("Você tocou no país '{0}', ", paises.Nome), "OK");
    //    }
    //}

    public partial class MainPage : ContentPage
    {

        public List<Veiculo> Veiculos { get; set; }

        public MainPage()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculo>
            {
                new Veiculo {Nome = "Azera V6", Preco = 60000},
                new Veiculo {Nome = "Fiesta 2.0", Preco = 50000},
                new Veiculo {Nome = "HB20 s", Preco = 40000}

            };

            this.BindingContext = this;
        }

        private void ListViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            DisplayAlert("Test Drive", string.Format("Você tocou no modelo '{0}', que custa {1}", veiculo.Nome, veiculo.PrecoFormatado), "Ok");

        }
    }
}
