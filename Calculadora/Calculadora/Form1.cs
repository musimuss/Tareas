using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal a, b, res;
        double ang;
        Int32 con;
        string operador;
        bool ban = true, cal = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text = "1";
                    ban = false;
                }
                else
                {
                    tbPantalla.Text = "1";
                    ban = false;
                }
            }
            else
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text += "1";
                }
                else
                {
                    tbPantalla.Text += "1";
                }
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text = "2";
                    ban = false;
                }
                else
                {
                    tbPantalla.Text = "2";
                    ban = false;
                }
            }
            else
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text += "2";
                }
                else
                {
                    tbPantalla.Text += "2";
                }
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text = "3";
                    ban = false;
                }
                else
                {
                    tbPantalla.Text = "3";
                    ban = false;
                }
            }
            else
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text += "3";
                }
                else
                {
                    tbPantalla.Text += "3";
                }
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text = "4";
                    ban = false;
                }
                else
                {
                    tbPantalla.Text = "4";
                    ban = false;
                }
            }
            else
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text += "4";
                }
                else
                {
                    tbPantalla.Text += "4";
                }
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text = "5";
                    ban = false;
                }
                else
                {
                    tbPantalla.Text = "5";
                    ban = false;
                }
            }
            else
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text += "5";
                }
                else
                {
                    tbPantalla.Text += "5";
                }
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text = "6";
                    ban = false;
                }
                else
                {
                    tbPantalla.Text = "6";
                    ban = false;
                }
            }
            else
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text += "6";
                }
                else
                {
                    tbPantalla.Text += "6";
                }
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text = "7";
                    ban = false;
                }
                else
                {
                    tbPantalla.Text = "7";
                    ban = false;
                }
            }
            else
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text += "7";
                }
                else
                {
                    tbPantalla.Text += "7";
                }
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text = "8";
                    ban = false;
                }
                else
                {
                    tbPantalla.Text = "8";
                    ban = false;
                }
            }
            else
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text += "8";
                }
                else
                {
                    tbPantalla.Text += "8";
                }
            }
        }
        private void b9_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text = "9";
                    ban = false;
                }
                else
                {
                    tbPantalla.Text = "9";
                    ban = false;
                }
            }
            else
            {
                if (tbPantalla.Text == "0")
                {
                    tbPantalla.Clear();
                    tbPantalla.Text += "9";
                }
                else
                {
                    tbPantalla.Text += "9";
                }
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                tbPantalla.Clear();
                tbPantalla.Text = "0";
                ban = false;
            }
            else
            {
                tbPantalla.Text += "0";
            }
        }

        private void bMas_Click(object sender, EventArgs e)
        {
            try
            {
                ban = true;
                if (cal)
                {
                    operador = "+";
                    lOperacion.Text = operador;
                    a = Convert.ToDecimal(tbPantalla.Text);
                    tbPantalla.Clear();
                    cal = false;
                }
                else
                {
                    if (tbPantalla.Text == null)
                    { }
                    else
                    {
                        b = Convert.ToDecimal(tbPantalla.Text);
                        a += b;
                        tbPantalla.Text = a.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("INGRESE VALORES");
            }
        }

        private void bMenos_Click(object sender, EventArgs e)
        {
            try
            {
                ban = true;
                if (cal)
                {
                    operador = "-";
                    lOperacion.Text = operador;
                    a = Convert.ToDecimal(tbPantalla.Text);
                    tbPantalla.Clear();
                    cal = false;
                }
                else
                {
                    if (tbPantalla.Text == null)
                    { }
                    else
                    {
                        b = Convert.ToDecimal(tbPantalla.Text);
                        a -= b;
                        tbPantalla.Text = a.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("INGRESE VALORES");
            }
        }

        private void bMult_Click(object sender, EventArgs e)
        {
            try
            {
                ban = true;
                if (cal)
                {
                    operador = "*";
                    lOperacion.Text = operador;
                    a = Convert.ToDecimal(tbPantalla.Text);
                    tbPantalla.Clear();
                    cal = false;
                }
                else
                {
                    if (tbPantalla.Text == null)
                    { }
                    else
                    {
                        b = Convert.ToDecimal(tbPantalla.Text);
                        a *= b;
                        tbPantalla.Text = a.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("INGRESE VALORES");
            }
        }

        private void dDiv_Click(object sender, EventArgs e)
        {
            try
            {
                ban = true;
                if (cal)
                {
                    operador = "/";
                    lOperacion.Text = operador;
                    a = Convert.ToDecimal(tbPantalla.Text);
                    tbPantalla.Clear();
                    cal = false;
                }
                else
                {
                    if (tbPantalla.Text == null)
                    { }
                    else
                    {
                        try
                        {
                            b = Convert.ToDecimal(tbPantalla.Text);
                            a /= b;
                            tbPantalla.Text = a.ToString();
                        }
                        catch (Exception)
                        {
                            tbPantalla.Text = "MATH ERROR";
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("INGRESE VALORES");
            }
        }

        private void bCos_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDecimal(tbPantalla.Text);
                ang = Math.Cos(Convert.ToDouble(a));
                tbPantalla.Text = ang.ToString();
                b0.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                b6.Enabled = false;
                b7.Enabled = false;
                b8.Enabled = false;
                b9.Enabled = false;
                b0.Enabled = false;
                bMas.Enabled = false;
                bMenos.Enabled = false;
                bMult.Enabled = false;
                dDiv.Enabled = false;
                bPunto.Enabled = false;
                bPorc.Enabled = false;
                bSen.Enabled = false;
                bCos.Enabled = false;
                bLog.Enabled = false;
                bDec.Enabled = false;
                bBin.Enabled = false;
                bIgual.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("INGRESE VALORES");
            }
        }

        private void bSen_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDecimal(tbPantalla.Text);
                ang = Math.Sin(Convert.ToDouble(a));
                tbPantalla.Text = ang.ToString();
                b0.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                b6.Enabled = false;
                b7.Enabled = false;
                b8.Enabled = false;
                b9.Enabled = false;
                b0.Enabled = false;
                bMas.Enabled = false;
                bMenos.Enabled = false;
                bMult.Enabled = false;
                dDiv.Enabled = false;
                bPunto.Enabled = false;
                bPorc.Enabled = false;
                bSen.Enabled = false;
                bCos.Enabled = false;
                bLog.Enabled = false;
                bDec.Enabled = false;
                bBin.Enabled = false;
                bIgual.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("INGRESE VALORES");
            }
        }

        private void bLog_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDecimal(tbPantalla.Text);
                ang = Math.Log(Convert.ToDouble(a));
                tbPantalla.Text = ang.ToString();
                b0.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                b6.Enabled = false;
                b7.Enabled = false;
                b8.Enabled = false;
                b9.Enabled = false;
                b0.Enabled = false;
                bMas.Enabled = false;
                bMenos.Enabled = false;
                bMult.Enabled = false;
                dDiv.Enabled = false;
                bPunto.Enabled = false;
                bPorc.Enabled = false;
                bSen.Enabled = false;
                bCos.Enabled = false;
                bLog.Enabled = false;
                bDec.Enabled = false;
                bBin.Enabled = false;
                bIgual.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("INGRESE VALORES");
            }
        }

        private void bDec_Click(object sender, EventArgs e)
        {
            bMas.Enabled = false;
            bMenos.Enabled = false;
            bMult.Enabled = false;
            dDiv.Enabled = false;
            bPunto.Enabled = false;
            bPorc.Enabled = false;
            bSen.Enabled = false;
            bCos.Enabled = false;
            bLog.Enabled = false;
            bDec.Enabled = false;
            bBin.Enabled = false;
            tbPantalla.Clear();
            lOperacion.Text = "DEC";
        }

        private void bBin_Click(object sender, EventArgs e)
        {
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = false;
            b6.Enabled = false;
            b7.Enabled = false;
            b8.Enabled = false;
            b9.Enabled = false;
            bMas.Enabled = false;
            bMenos.Enabled = false;
            bMult.Enabled = false;
            dDiv.Enabled = false;
            bPunto.Enabled = false;
            bPorc.Enabled = false;
            bSen.Enabled = false;
            bCos.Enabled = false;
            bLog.Enabled = false;
            bDec.Enabled = false;
            bBin.Enabled = false;
            tbPantalla.Clear();
            lOperacion.Text = "BIN";
        }

        private void bPorc_Click(object sender, EventArgs e)
        {
            try
            {
                ban = true;
                if (cal)
                {
                    operador = "%";
                    lOperacion.Text = operador;
                    a = Convert.ToDecimal(tbPantalla.Text);
                    tbPantalla.Clear();
                    cal = false;
                }
                else
                {
                    if (tbPantalla.Text == null)
                    { }
                    else
                    {
                        try
                        {
                            b = Convert.ToDecimal(tbPantalla.Text);
                            a %= b;
                            tbPantalla.Text = a.ToString();
                        }
                        catch (Exception)
                        {
                            tbPantalla.Text = "MATH ERROR";
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("INGRESE VALORES");
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            tbPantalla.Clear();
        }

        private void bIgual_Click(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDecimal(tbPantalla.Text);
                switch (lOperacion.Text)
                {
                    case "+":
                        res = a + b;
                        tbPantalla.Text = res.ToString();
                        lOperacion.ResetText();
                        cal = true;
                        ban = true;
                        break;
                    case "-":
                        res = a - b;
                        tbPantalla.Text = res.ToString();
                        lOperacion.ResetText();
                        cal = true;
                        ban = true;
                        break;
                    case "*":
                        res = a * b;
                        tbPantalla.Text = res.ToString();
                        lOperacion.ResetText();
                        cal = true;
                        ban = true;
                        break;
                    case "/":
                        try
                        {
                            res = a / b;
                            tbPantalla.Text = res.ToString();
                            lOperacion.ResetText();
                            cal = true;
                            ban = true;
                        }
                        catch (Exception)
                        {
                            tbPantalla.Text = "MATH ERROR";
                            cal = true;
                            ban = true;
                        }
                        break;
                    case "DEC":
                        string bin = "";
                        con = Convert.ToInt32(b);
                        while (con > 0)
                        {
                            bin = con % 2 + bin;
                            con /= 2;
                        }
                        tbPantalla.Text = bin;
                        b0.Enabled = false;
                        b1.Enabled = false;
                        b2.Enabled = false;
                        b3.Enabled = false;
                        b4.Enabled = false;
                        b5.Enabled = false;
                        b6.Enabled = false;
                        b7.Enabled = false;
                        b8.Enabled = false;
                        b9.Enabled = false;
                        b0.Enabled = false;
                        bIgual.Enabled = false;
                        cal = true;
                        ban = true;
                        break;
                    case "BIN":
                        con = Convert.ToInt32(b);
                        Int32 residuo = 0, exp = 0, r = 0;
                        do
                        {
                            residuo = con % 10;
                            con /= 10;
                            r += (Int32)(residuo * Math.Pow(2, exp));
                            exp++;
                        } while (con != 0);
                        tbPantalla.Text = r.ToString();
                        b0.Enabled = false;
                        b1.Enabled = false;
                        bIgual.Enabled = false;
                        cal = true;
                        ban = true;
                        break;
                    case "%":
                        try
                        {
                            res = a % b;
                            tbPantalla.Text = res.ToString();
                            lOperacion.ResetText();
                            cal = true;
                            ban = true;
                        }
                        catch (Exception)
                        {
                            tbPantalla.Text = "MATH ERROR";
                            cal = true;
                            ban = true;
                        }
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("NO HAY OPERACION EN CURSO");
            }
        }

        private void bPunto_Click(object sender, EventArgs e)
        {
            if (tbPantalla.Text == "")
            {
                tbPantalla.Text = "0.";
            }
            else
            {
                if (tbPantalla.Text.Contains("."))
                { }
                else
                {
                    tbPantalla.Text += ".";
                }
            }
        }
        private void bBorrar_Click(object sender, EventArgs e)
        {
            tbPantalla.Clear();
            cal = true;
            ban = true;
            lOperacion.ResetText();
            b0.Enabled = true;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            b0.Enabled = true;
            bMas.Enabled = true;
            bMenos.Enabled = true;
            bMult.Enabled = true;
            dDiv.Enabled = true;
            bPunto.Enabled = true;
            bPorc.Enabled = true;
            bSen.Enabled = true;
            bCos.Enabled = true;
            bLog.Enabled = true;
            bDec.Enabled = true;
            bBin.Enabled = true;
            bIgual.Enabled = true;
        }

    }
}
