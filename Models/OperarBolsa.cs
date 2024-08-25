using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pc1.Models
{
    public class OperarBolsa
    {
        public string? Instrumento { get; set; }
        public decimal? IGV { get; set; }
        public decimal? Monto { get; set; }

        public decimal? Comision { get; set; }

        public OperarBolsa(string instrumento, decimal igv, decimal monto, decimal comision)
        {
            Instrumento = instrumento;
            IGV = igv;
            Monto = monto;
            Comision = comision <= 300 ? 1 : 3;
        }
    }


}