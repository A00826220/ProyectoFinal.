using PruebaClases.AlgoritmoInicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using objExcel = Microsoft.Office.Interop.Excel;

namespace ProyectoFinal.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (textBox1.Text.Equals("") ||
                    textBox2.Text.Equals("") || textBox3.Text.Equals(""))
                {
                    MessageBox.Show("Los números tiene      n que ser MAYOR que cero, NO VACÍOS");
                    return;
                }
                int NumeroMaquinas = Convert.ToInt32(textBox1.Text);
                int limiteInferior = Convert.ToInt32(textBox2.Text);
                int limiteSuperior = Convert.ToInt32(textBox3.Text);
                int CantidadDemanda = Convert.ToInt32(textBox4.Text);
                
            
                
                if (limiteInferior >= limiteSuperior)
                {
                    MessageBox.Show("Los límites tienen error");
                    return;
                }
                if (limiteInferior > 0 && limiteSuperior > 0 && numeroDatos > 0)
                {
                    AlgoritmoPrincipal algoritmo = new AlgoritmoPrincipal();
                    media = algoritmo.AlgoritmoGenerarAleatoriosMedia(numeroDatos, limiteInferior, limiteSuperior);
                    llenarGrid(numeroDatos, algoritmo);
                    textBox4.Text = .ToString();
                }
                else
                {
                    MessageBox.Show("Vuelve a intentar (Núnca te rindas)");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vuelve a intentar");
            }
        }

        public void llenarGrid(int numeroDatos, AlgoritmoPrincipal algoritmo)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Algoritmo 1");
            dataGridView1.Columns.Add(numeroColumna2, "ID");
            for (int i = 0; i < numeroDatos; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = algoritmo.listaDemandas[i].CantidadRequerida.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = algoritmo.listaDemandas[i].IdDemanda.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }
        public void DescargaExcel(DataGridView data)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna = indiceColumna + 1;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }
            
            int indiceFila = 0;
            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;
        }
    }
}
