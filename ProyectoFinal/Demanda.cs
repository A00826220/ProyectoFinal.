using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Demanda
    {
        public double IdDemanda { get; set; }
        public double CantidadRequerida { get; set; }
        public double CantidadProgramada { get; set; }
        public int FechaDia { get; set; }
        public string IdProducto { get; set; }
        public string IdCliente { get; set; }

        public Demanda() { }
        public Demanda(Demanda d1)
        {
            IdDemanda = d1.IdDemanda;
            CantidadRequerida = d1.CantidadRequerida;
            FechaDia = d1.FechaDia;
            IdProducto = d1.IdProducto;
            IdCliente = d1.IdCliente;
            CantidadProgramada= d1.CantidadProgramada;

        }
    }
}
