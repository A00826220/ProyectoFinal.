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
        public void AlgoritmoPrincipal(int NumeroMaquinas,int limiteInferior, int limiteSuperior, int CantidadDemanda) 
        {
            List<Maquina> listMaquinas = new List<Maquina>();
            List<Demanda> listDemandas = new List<Demanda>();

             Ambiente1 alg1 = new Ambiente1();
            alg1.LlenarDatosAletoriosMaq1(NumeroMaquinas, listMaquinas,limiteInferior, limiteSuperior);
            alg1.LLenarDatosAleatoriosDem(CantidadDemanda, listDemandas, limiteInferior, limiteSuperior);
            AsignacionAlgoritmos(listDemandas,listMaquinas);
        
        }
        public double AsignacionAlgoritmos( List<Demanda> listaDemandas, List<Maquina> listaMaquinas)
        {
            double valor = 0;
            listaDemandas = listaDemandas.OrderBy(x => x.FechaDia).ToList();
            foreach (Demanda Demanda in listaDemandas)
            {
                Random aleatorio=new Random(Environment.TickCount);
                int MaquinaAsignada= aleatorio.Next(0,listaMaquinas.Count()-1);
                listaMaquinas.Sort();
                listaMaquinas=listaMaquinas.OrderBy(x=>x.AvFecha).ToList();
                Maquina MaquinaAsignada2 = listaMaquinas[0];
                MaquinaAsignada2.ListaDemandasMaquina.Add(Demanda);
                double tiempoTotal = Demanda.CantidadRequerida / MaquinaAsignada2.RateMaquina;
                MaquinaAsignada2.AvFecha = MaquinaAsignada2.AvFecha + tiempoTotal;

            }
            return valor;
        }
    }
}
