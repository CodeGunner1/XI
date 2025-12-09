using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensg
{
    class Matriz
    {
        //atributos
        const int MAXF = 50;
        const int MAXC = 50;

        private int[,] x;

        private int f, c;

        //contructor

        public Matriz()
        {

            x = new int[MAXF, MAXC];
            f = 0;
            c = 0;

        }

        //cargar y descargar

        public void CargarRandom(int nf, int nc, int a, int b)

        {
            int f1, c1;
            Random r = new Random();
            f = nf;
            c = nc;


            for (f1 = 1; f1 <= f; f1++)

            {
                for (c1 = 1; c1 <= c; c1++)

                {
                    x[f1, c1] = r.Next(a, b + 1);

                }

            }

        }


        public string Descargar()

        {
            string s = "";
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)

            {
                for (c1 = 1; c1 <= c; c1++)

                {
                    s = s + x[f1, c1] + "\x9";


                }
                s = s + "\xd" + "\xa";

            }

            return s;

        }


        //examen

        //pregunta 1 - Matrices
        public void MayorFrecuenciaTSupDer(ref int ele, ref int frec)
        {
            ele = 0;
            frec = 0;

            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = f1; c1 <= c; c1++)   // SOLO triangular superior derecha
                {
                    int cont = 0;
                    int val = x[f1, c1];

                    // Contar frecuencia del valor en TODA la triangular sup. der.
                    for (int f2 = 1; f2 <= f; f2++)
                    {
                        for (int c2 = f2; c2 <= c; c2++)
                        {
                            if (x[f2, c2] == val)
                                cont++;
                        }
                    }

                    if (cont > frec)
                    {
                        frec = cont;
                        ele = val;
                    }
                }
            }
        }



    }
}
