using AppCNCRED.DAL;
using AppCNCRED.DTO;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCNCRED
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        ParcelamentoDTO dto = new ParcelamentoDTO();
        TaxaInfoDAL dal = new TaxaInfoDAL();
        ObservableCollection<ParcelamentoDTO> item = new ObservableCollection<ParcelamentoDTO>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Clicked(object sender, EventArgs e)
        {
            item.Clear();

            dto.ValorEmprestimo = Convert.ToDecimal(textBoxValor.Text);

            for (int i = 0; i < 12; i++)
            {
                dto.NParcela = i + 1;
                dto.ValorTaxa = dal.PegarTaxa(i);
                dto.ValorTotal = (dto.ValorEmprestimo * dto.ValorTaxa) + dto.ValorEmprestimo ;
                dto.ValorParcela = dto.ValorTotal / dto.NParcela;
                item.Add(new ParcelamentoDTO { ValorEmprestimo = dto.ValorEmprestimo, NParcela = dto.NParcela, ValorTaxa = dto.ValorTaxa, ValorParcela = dto.ValorParcela, ValorTotal = dto.ValorTotal });
            }
            myList.ItemsSource = item;
        }

        private void MyList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var parcela = e.Item as ParcelamentoDTO;
            DisplayAlert("Mais Informações...", $"Número de Parcela: {parcela.NParcela} \n Valor da Parcela: R$ {parcela.ValorParcela:N} \n Taxa Total de: {(parcela.ValorTaxa) * 100}% \n Total a cobrar: R$ {parcela.ValorTotal:N}", "OK");
        }
    }
}