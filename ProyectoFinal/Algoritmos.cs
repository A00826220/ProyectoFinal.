using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Algoritmos
    {

        public Algoritmos()
        {

        }
        public double AsignacionAlgoritmos(List<Demanda> listaDemandas, List<Maquina> listaMaquinas)
        {
            double valor = 0;
            listaDemandas = listaDemandas.OrderBy(x => x.FechaDia).ToList();
            foreach (Demanda Demandas in listaDemandas)
            {

            }
        }
    }
}
