using AppCNCRED.DAL;
using AppCNCRED.DTO;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCNCRED
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        ParcelamentoDTO dto = new ParcelamentoDTO();
        TaxaInfoDAL dal = new TaxaInfoDAL();
        List<ParcelamentoDTO> item = new List<ParcelamentoDTO>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Clicked(object sender, EventArgs e)
        {
            dto.ValorEmprestimo = Convert.ToDecimal(textBoxValor.Text);

            for(int i = 0; i < 12; i++)
            {
                dto.NParcela = i + 1;
                dto.ValorTaxa = dal.PegarTaxa(i);
                dto.ValorEmprestimo = dto.ValorEmprestimo * dto.ValorTaxa;
                dto.ValorParcela = dto.ValorEmprestimo / dto.NParcela;
                item.Add(dto);
            }
            myList.ItemsSource = item;
        }
    }
}