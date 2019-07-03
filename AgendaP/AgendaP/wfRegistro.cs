using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaP
{
    public partial class wfRegistro : Form
    {
        public wfRegistro()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Evento evReg = new Evento();
            Form1 datos = new Form1();
            if (tbDesc.Text == "")
            {
                MessageBox.Show("INGRESE DESCRIPCION");
            }
            else
            {
                evReg.fecha = dtpFecha.Text;
                evReg.desc = tbDesc.Text;

                datos.dgvAgenda.DataSource = evReg;
            }
        }
    }
}
