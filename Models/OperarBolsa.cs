using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pc1.Models
{
    public class OperarBolsa
    {
        public string? NombreApellido { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? Fecha { get; set; }
        public string? Instrumento { get; set; }
        public decimal IGV { get; set; }
        public decimal Monto { get; set; }

        public decimal Comision { get; set; }

        public void CalcularOperacion()
        {
            IGV = Monto * 0.18m;
            Comision = Monto <= 300 ? 1 : 3;
        }
    }


}