using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticoVectoresCodeGunner1y225pro
{
    public partial class Form1 : Form
    {
        Vector v1, v2, v3, v4; NEnt n1;
        //entero n1;

        ArchBin a1, a2, a3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();
            v4 = new Vector();
            n1 = new NEnt();
            a1 = new ArchBin();
            a2 = new ArchBin();
            a3 = new ArchBin();
        }
        //CD1
        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.CargarRnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();
        }

        private void cargarEleXEleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargardato(int.Parse(textBox1.Text));

            textBox5.Text = v1.Descargar();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = v1.Descargar();
        }
        //CD2
        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2.CargarRnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox6.Text = v2.Descargar();
        }

        private void cargarEleXEleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2.cargardato(int.Parse(textBox1.Text));
            textBox6.Text = v2.Descargar();
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox8.Text = v2.Descargar();
        }
        //CD3
        private void cargarRNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cargarEleXEleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
          
        }
        //CD4
        private void cargarRNDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void descargarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }
        //P1
        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ejercicio11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ejercicio12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ejercicio13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //p2
        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void ejercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         

        }

        private void ejercicio4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void ejercicio5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        private void ejercicio6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void ejercicio7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           

        }



        private void ejercicio8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ejercicio9ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }



        private void ejercicio10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }




        //archivos

        private void grabarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            v1.GrabarV(saveFileDialog1.FileName);
        }



        private void leerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            v1.Leer(openFileDialog1.FileName);
        }

        private void ordenarInterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.OrdInter();
            v2.OrdInter();
        }



        private void grabarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            v2.GrabarV(saveFileDialog1.FileName);
        }



        private void leerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            v2.Leer(openFileDialog1.FileName);
        }

       

        private void seleccionParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void selecPosMultToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        

        // EJERCICIO 1
        private void elemntsMayoresALaMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            a1.SelectElemsMayoresAlaMedia(openFileDialog1.FileName, saveFileDialog1.FileName, ref a2);
        }



        // EJERCICIO 2 
        private void purgarArchivoOrdenadoAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); 
            saveFileDialog1.ShowDialog(); 
            a1.PurgarAsc(openFileDialog1.FileName, saveFileDialog1.FileName, ref a2);
        }

        // EJERCICIO 3 
        private void unir2ArchivosOrdenadosEnOtroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog2.ShowDialog();
            saveFileDialog1.ShowDialog();
            a1.UnirAsc(openFileDialog1.FileName, openFileDialog2.FileName, saveFileDialog1.FileName, ref a2, ref a3);
        }


        
        // EJERCICIO 4 
        private void encontrarElElemMayorDePosicionesMúltiplosDeMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            int m = int.Parse(textBox4.Text); 

            int mayor = a1.MayorPosM(openFileDialog1.FileName, m);
            MessageBox.Show("El mayor en posiciones múltiplos de " + m + " es: " + mayor);
        }
        // EJERCICIO 5 
        private void búsquedaBinariaEnElArchivoOrdenadoAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            int x = int.Parse(textBox4.Text);

            int pos = a1.BusqBinaria(openFileDialog1.FileName, x);
            MessageBox.Show("Resultado: Pos = " + pos);
        }
        // EJERCICIO 6 
        private void invertirLosElementosDePosicionesMúltiplosDeMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();                
            int m = int.Parse(textBox4.Text);             

            a1.Ejercicio6_MismoArchivo(openFileDialog1.FileName, m);

            MessageBox.Show("Proceso terminado.\nLos elementos en posiciones múltiplos de " +
                             m + " fueron invertidos en el mismo archivo.");
        }


        private void ejercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //LLAMADA ARCHIVOS 
            openFileDialog1.ShowDialog();

            int ele = 0, frec = 0;

            a1.ElemMayorFrec(openFileDialog1.FileName, ref ele, ref frec);

            MessageBox.Show("Elemento = " + ele + "\nFrecuencia = " + frec);
        }


    }
}
