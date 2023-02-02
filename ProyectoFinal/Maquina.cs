using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Maquina
    {
        public double RateMaquina { get; set; }//unidades por hora
        public double AvFecha { get; set; }//disponibilidad de fechas
        public string IdMaquina { get; set; }
        public List<Demanda> ListaDemandasMaquina { get; set; }
       
        public Maquina(double rate, double fechaDisp, string idMaquina, List<Demanda> ListaDemandasMaquina)
        {
            RateMaquina = rate;
            AvFecha = fechaDisp;
            IdMaquina = idMaquina;

        }

        public Maquina()
        {
        }
    }
}
