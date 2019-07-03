using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parabola
{
    public partial class pbFormula : Form
    {
        public pbFormula()
        {
            InitializeComponent();
        }

        //CREACION DE UN OBJETO DE LA CLASE Grafico
        Grafico obj = new Grafico();

        private void bGraficar_Click(object sender, EventArgs e)
        {
            //RECUPERACION DE VARIABLES DE LOS TEXTBOX
            int a, b, c, x, y;
            int.TryParse(tba.Text, out a);
            int.TryParse(tbb.Text, out b);
            int.TryParse(tbc.Text, out c);

            //ENCONTRANDO EL VERTICE DE LA PARABOLA
            x = (-b) / (2 * a);

            //ENVIO DE PARAMETROS A LA CLASE Grafico.cs
            //ENVIO DE VALOR PARA X
            obj.p_valor(x);
            //ENVIO DE VALOR PARA Y
            obj.p_valorY(a, b, c);
            //ENVIO DEL PictureBox DONDE SE VA A GRAFICAR (TOMESE COMO LIENZO DE TRABAJO)
            obj.coordenadas(pbCuadro, a, b, c);
        }
    }
}
