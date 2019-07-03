using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verificadorIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ip;
        string[] ipseg;
        Int32[] ipint;
        private void bConvertir_Click(object sender, EventArgs e)
        {
            if (tbIP.Text == "")
            {
                bConvertir.Enabled = false;
                MessageBox.Show("INGRESE UNA IP");
            }
            else
            {
                if (rbDecimal.Checked)
                {
                    string bin = "";
                    for (int i = 3; i >= 0; i--)
                    {
                        errorIP.SetError(tbIP, "");
                        if (ipint[i] == 0)
                        {
                            bin = "0" + bin;
                        }
                        else
                        {
                            while (ipint[i] > 0)
                            {
                                bin = ipint[i] % 2 + bin;
                                ipint[i] /= 2;
                            }
                        }
                        if (i != 0)
                        {
                            bin = "." + bin;
                        }
                        lResultado.Text = bin;
                    }
                    bConvertir.Enabled = false;
                }
                else
                {
                    string dec = "";
                    for (int i = 3; i >= 0; i--)
                    {
                        errorIP.SetError(tbIP, "");
                        Int32 residuo = 0, exp = 0, r = 0;
                        do
                        {
                            residuo = ipint[i] % 10;
                            ipint[i] /= 10;
                            r += (Int32)(residuo * Math.Pow(2, exp));
                            exp++;
                        } while (ipint[i] != 0);
                        if (i != 0)
                        {
                            dec = "." + dec;
                        }
                        lResultado.Text = dec;
                    }
                    bConvertir.Enabled = false;
                }
            }
        }

        private void bVerificar_Click(object sender, EventArgs e)
        {
            int errores;
            if (tbIP.Text == "")
            {
                MessageBox.Show("INGRESE UNA IP");
            }
            else
            {
                if (rbDecimal.Checked)
                {
                    errores = 0;
                    ip = tbIP.Text;
                    ipseg = ip.Split('.');
                    if (ipseg.Length == 4)
                    {
                        try
                        {
                            ipint = Array.ConvertAll(ipseg, int.Parse);
                            for (int i = 0; i < ipint.Length; i++)
                            {
                                if (ipint[i] < 0 && ipint[i] > 255)
                                {
                                    errores++;
                                }
                            }
                            if (errores == 0)
                            {
                                errorIP.SetError(tbIP, "");
                                MessageBox.Show("IP CORRECTA");
                                bConvertir.Enabled = true;
                            }
                            else
                            {
                                errorIP.SetError(tbIP, "IP INVALIDA");
                            }
                        }
                        catch (Exception)
                        {
                            bConvertir.Enabled = false;
                            errorIP.SetError(tbIP, "IP INVALIDA");
                        }
                    }
                    else
                    {
                        errorIP.SetError(tbIP, "IP INVALIDA");
                    }
                }
                else
                {
                    string cad;
                    errores = 0;
                    ip = tbIP.Text;
                    ipseg = ip.Split('.');
                    if (ipseg.Length == 4)
                    {
                        try
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (ipseg[i].Length > 8)
                                {
                                    errores++;
                                }
                                else
                                {
                                    cad = ipseg[i];
                                    for (int j = 0; j < cad.Length; j++)
                                    {
                                        if (cad[j].Equals("1") || cad[j].Equals("0"))
                                        {

                                        }
                                        else
                                        {
                                            errores++;
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                            bConvertir.Enabled = false;
                            errores++;
                        }
                    }
                    else
                    {
                        errores++;
                    }
                    if (errores == 0)
                    {
                        errorIP.SetError(tbIP, "");
                        MessageBox.Show("IP CORRECTA");
                        bConvertir.Enabled = true;
                    }
                    else
                    {
                        errorIP.SetError(tbIP, "IP INVALIDA");
                    }
                }
            }
        }

        private void rbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            tbIP.Clear();
            bConvertir.Text = "CONVERTIR A BINARIO";
        }

        private void rbBinario_CheckedChanged(object sender, EventArgs e)
        {
            tbIP.Clear();
            bConvertir.Text = "CONVERTIR A DECIMAL";
        }
    }
}
