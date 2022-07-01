using AppCNCRED.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCNCRED.DAL
{
    class TaxaInfoDAL
    {
        public static decimal[] valorTaxa = new decimal[12];

        public decimal PegarTaxa(int i)
        {
            decimal taxa;

            valorTaxa[00] = Convert.ToDecimal(0.083700);
            valorTaxa[01] = Convert.ToDecimal(0.121080);
            valorTaxa[02] = Convert.ToDecimal(0.155080);
            valorTaxa[03] = Convert.ToDecimal(0.185447);
            valorTaxa[04] = Convert.ToDecimal(0.211953);
            valorTaxa[05] = Convert.ToDecimal(0.234393);
            valorTaxa[06] = Convert.ToDecimal(0.252607);
            valorTaxa[07] = Convert.ToDecimal(0.266453);
            valorTaxa[08] = Convert.ToDecimal(0.275813);
            valorTaxa[09] = Convert.ToDecimal(0.280620);
            valorTaxa[10] = Convert.ToDecimal(0.280820);
            valorTaxa[11] = Convert.ToDecimal(0.276400);

            taxa = valorTaxa[i];

            return taxa;
        }
    }
}
