using AppCNCRED.DAL;
using AppCNCRED.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCNCRED
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Clicked(object sender, EventArgs e)
        {
            double resultado;
            double valor = Convert.ToDouble(textBoxValor.Text);
            double[] valorTaxa = new double[12];

            List<String> item = new List<string>();
            String texto;

            valorTaxa[00] = 0.083700;
            valorTaxa[01] = 0.121080;
            valorTaxa[02] = 0.155080;
            valorTaxa[03] = 0.185447;
            valorTaxa[04] = 0.211953;
            valorTaxa[05] = 0.234393;
            valorTaxa[06] = 0.252607;
            valorTaxa[07] = 0.266453;
            valorTaxa[08] = 0.275813;
            valorTaxa[09] = 0.280620;
            valorTaxa[10] = 0.280820;
            valorTaxa[11] = 0.276400;

            for (int i = 0; i < 12; i++)
            {
                resultado = (valor * valorTaxa[i]) + valor;
                texto = Convert.ToString("Parcelamento em " + (i+1) + "X: " + "\n Total a pagar: R$" + resultado);
                item.Add(texto);
            }
            myList.ItemsSource = item;
        }
    }
}