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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            wfRegistro reg = new wfRegistro();
            reg.ShowDialog();
        }

        private void bVer_Click(object sender, EventArgs e)
        {
            dgvAgenda.DataSource = dgvAgenda.DataSource;
        }
    }
}
