using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repechaje_si
{
    public partial class Form1 : Form
    {
        Matriz x1, x2, x3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = new Matriz();
            x2 = new Matriz();
            x3 = new Matriz();

        }


        //cargar x1
        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.CargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox5.Text = x1.Descargar();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = x1.Descargar();
        }
        //cargar x2
        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }


        //descargar x3
        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }



        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }


        private void mayorFrecuanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //aqui pone la llamada

            //LLAMADA
            int ele = 0, frec = 0;

            x1.MayorFrecuenciaTriangularInferiorIzq(ref ele, ref frec);

            textBox7.Text = "ele = " + ele + "   frec = " + frec;

        }
    }
}
