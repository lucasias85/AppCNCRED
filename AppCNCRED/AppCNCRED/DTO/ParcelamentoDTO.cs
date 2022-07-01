using System;
using System.Collections.Generic;
using System.Text;

namespace AppCNCRED.DTO
{
    class ParcelamentoDTO
    {
        public decimal ValorEmprestimo { get; set; }
        public decimal ValorTaxa { get; set; }
        public int NParcela { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
