using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Ambiente1
    {
        public Ambiente1() { }
        public object MaquinasProduccion { get; private set; }
        public void LlenarDatosAletoriosMaq1(int NumeroDatos, List<Maquina>MaquinasProduccion,int limiteInferior, int limiteSuperior)
        {
            Random aleatorios = new Random(Environment.TickCount);
            for (int i = 0; i < NumeroDatos; i++)
            {
                double value = (double)aleatorios.NextDouble();
                int value0 = aleatorios.Next(limiteInferior, limiteSuperior);
                Maquina Maquinas = new Maquina();
                Maquinas.RateMaquina = value0;
                MaquinasProduccion.Add(Maquinas);

            }
        }
        public object DemandaGeneral { get; private set; }
        public void LLenarDatosAleatoriosDem(int NumeroDatos,List<Demanda>DemandaGeneral,int limiteInferior, int limiteSuperior)
        {
            Random aleatorios = new Random(Environment.TickCount);
            for (int i = 0; i < NumeroDatos; i++)
            {
                double value = (double)aleatorios.NextDouble();
                double value1 = aleatorios.Next(limiteInferior, limiteSuperior);
                double value2 = aleatorios.Next(limiteInferior, limiteSuperior);
                int value3 = aleatorios.Next(limiteInferior, limiteSuperior);
                double value4 = aleatorios.Next(limiteInferior, limiteSuperior);            
                Demanda Demandas = new Demanda();
                Demandas.IdDemanda = value1;
                Demandas.CantidadRequerida = value2;
                Demandas.FechaDia = value3;
                Demandas.CantidadProgramada = value4;
                DemandaGeneral.Add(Demandas);

            }


        } 


    }
    
}
