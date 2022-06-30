using AppCNCRED.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppCNCRED.DAL
{
    public class TaxaInfo
    {
        TaxaDTO ValorTaxas(TaxaDTO dto)
        {
            dto.ValorTaxa[00] = 0.083700;
            dto.ValorTaxa[01] = 0.121080;
            dto.ValorTaxa[02] = 0.155080;
            dto.ValorTaxa[03] = 0.185447;
            dto.ValorTaxa[04] = 0.211953;
            dto.ValorTaxa[05] = 0.234393;
            dto.ValorTaxa[06] = 0.252607;
            dto.ValorTaxa[07] = 0.266453;
            dto.ValorTaxa[08] = 0.275813;
            dto.ValorTaxa[09] = 0.280620;
            dto.ValorTaxa[10] = 0.280820;
            dto.ValorTaxa[11] = 0.276400;

            return dto;
        }
    }
}
