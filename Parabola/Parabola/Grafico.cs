using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Parabola
{
    class Grafico
    {
        //LAPIZ NEGRO PARA DIBUJAR EL EJE DE COORDENADAS
        Pen lapiz1 = new Pen(Color.Black);
       
        //LAPIZ ROJO PARA DIBUJAR LA PARABOLA
        Pen lapiz2 = new Pen(Color.Red);
        
        //LIENZO PARA EL TRAZADO DEL EJE DE COORDENADAS Y LA PARABOLA
        Graphics dibujo;
        
        //VALORES DE LOS PUNTOS 
        int valorx, valory;
        
        //ASIGNACION DE VALOR PARA X
        public void p_valor (int valor)
        {
            valorx = valor;
        }
        
        //ASIGNACION DE VALOR PARA Y
        public void p_valorY (int a, int b, int c)
        {
            valory = a * (valorx * valorx) + b * valorx + c;
        }

        //FUNCION PARA EL EJE DE COORDENADAS
        public void plano (PictureBox cuadro)
        {
            //ASIGNACION DEL CENTRO DEL EJE DE COORDENADAS CON RESPECTO AL TAMAÑO DEL LIENZO
            int x = cuadro.Width / 2;
            int y = cuadro.Height / 2;

            //ASIGNA EL AREA DE TRABAJO, LAS COORDENADAS EN LA QUE SE TRABAJARA Y LA ESCALA QUE SE TOMARA
            dibujo = cuadro.CreateGraphics();
            dibujo.TranslateTransform(x,y);
            dibujo.ScaleTransform(1, -1);

            //TRAZADO DEL EJE "X" Y DEL EJE "Y"
            dibujo.DrawLine(lapiz1, x * -1, 0, x * 1, 0);
            dibujo.DrawLine(lapiz1, 0, y * -1, 0, y * 1);
        }

        //FUNCION PARA EL TRAZADO DE PUNTOS DE REFERENCIA Y LA PARABOLA
        public void coordenadas (PictureBox cuadro, int a, int b, int c)
        {
            //LIMPIADO DEL AREA DE TRABAJO Y TRAZO DEL EJE DE COORDENADAS
            cuadro.Refresh();
            plano(cuadro);

            int x = cuadro.Width / 2;
            int y = cuadro.Height / 2;

            dibujo = cuadro.CreateGraphics();
            dibujo.TranslateTransform(x, y);
            dibujo.ScaleTransform(1, -1);

            //CREACION DE VECTORES PARA GUARDAR LOS PUNTOS DE LA PARABOLA

            int[] vx1 = new int[100];
            int[] vy1 = new int[100];

            int[] vx2 = new int[100];
            int[] vy2 = new int[100];

           
            //TRAZADO DE LOS PUNTOS DE REFERENCIA EN EL EJE DE COORDENADAS
            for (int i = -x; i < x; i = i + 5)
            {
                dibujo.DrawLine(lapiz1, 3, i*5, -3, i*5);
                dibujo.DrawLine(lapiz1, i*5, 2, i*5, -2);
            }

            //VARIABLES PARA CREAR LOS PUNTOS DE LA PARABOLA A PARTIR DEL VERTICE DE LA MISMA
            int v1 = valorx;
            int v2 = valorx;

            //ASIGNACION DE PUNTOS DE LA PARABOLA PARA "Y" EN BASE A "X" CON LA FORMULA "y = ax^2 + bx + c"
            for (int i = 0; i < 100; i++)
            {
                vx1[i] = v1;
                vy1[i] = a * (vx1[i] * vx1[i]) + b * vx1[i] + c;
                v1++;
            }

            for (int i = 0; i < 100; i++)
            {
                vx2[i] = v2;
                vy2[i] = a * (vx2[i] * vx2[i]) + b * vx2[i] + c;
                v2--;
            }

            //TRAZADO DE LA PARABOLA 
            for (int i = 0; i < 100-1; i++)
            {
                dibujo.DrawLine(lapiz2, vx1[i] * 5, vy1[i] * 5, vx1[i + 1] * 5, vy1[i + 1] * 5);
                dibujo.DrawLine(lapiz2, vx2[i] * 5, vy2[i] * 5, vx2[i + 1] * 5, vy2[i + 1] * 5);
            }

        }
    }
}
