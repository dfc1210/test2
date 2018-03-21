using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ejemploPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool control;
        private Boolean validar()
        {
            if (txtA1.Text == "")
            {
                MessageBox.Show("No ingreso la parte real de A");
                txtA1.Focus();
                return true;
            }
            else
            {
                if (txtA2.Text == "")
                {
                    MessageBox.Show("No ingreso la parte imaginaria de A");
                    txtA2.Focus();
                    return true;
                }
                else
                {
                    if (txtB1.Text == "")
                    {
                        MessageBox.Show("No ingreso la parte real de B");
                        txtB1.Focus();
                        return true;
                    }
                    else
                    {
                        if (txtB2.Text == "")
                        {
                            MessageBox.Show("No ingreso la parte imaginaria de B");
                            txtB2.Focus();
                            return true;
                        }
                        else
                        { return false; }
                    }
                }
            }
        
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

                control= validar();
                if (control == false)
                {
                    Complejos A = new Complejos(int.Parse(txtA1.Text), int.Parse(txtB1.Text));
                    Complejos B = new Complejos(int.Parse(txtA2.Text), int.Parse(txtB2.Text));
                    var igual = A.Suma(B);

                    lblresultado.Text = (System.Convert.ToString(igual.partR) + "+" + System.Convert.ToString(igual.partI) + "i");

                    txtA1.Text = System.Convert.ToString(igual.partR);
                    txtB1.Text = System.Convert.ToString(igual.partI);
                    txtA2.Clear();
                    txtB2.Clear();
                    txtA2.Focus();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             control= validar();
             if (control == false)
             {
                 Complejos A = new Complejos(int.Parse(txtA1.Text), int.Parse(txtB1.Text));
                 Complejos B = new Complejos(int.Parse(txtA2.Text), int.Parse(txtB2.Text));
                 var igual = A.Resta(B);

                 lblresultado.Text = (System.Convert.ToString(igual.partR) + "+" + System.Convert.ToString(igual.partI) + "i");

                 txtB1.Text = System.Convert.ToString(igual.partR);
                 txtA1.Text = System.Convert.ToString(igual.partI);
                 txtB1.Clear();
                 txtB2.Clear();
                 txtA2.Focus();
             }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             control= validar();
             if (control == false)
             {
                 Complejos A = new Complejos(int.Parse(txtA1.Text), int.Parse(txtB1.Text));
                 Complejos B = new Complejos(int.Parse(txtA2.Text), int.Parse(txtB2.Text));
                 var igual = A.Multiplicar(B);

                 lblresultado.Text = (System.Convert.ToString(igual.partR) + "+" + System.Convert.ToString(igual.partI) + "i");


                 txtA1.Text = System.Convert.ToString(igual.partR);
                 txtB1.Text = System.Convert.ToString(igual.partI);
                 txtA2.Clear();
                 txtB2.Clear();
                 txtA2.Focus();
             }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             control= validar();
             if (control == false)
             {
                 Complejos A = new Complejos(int.Parse(txtA1.Text), int.Parse(txtB1.Text));
                 Complejos B = new Complejos(int.Parse(txtA2.Text), int.Parse(txtB2.Text));
                 var igual = A.Division(B);
                
                 lblresultado.Text = (System.Convert.ToString(igual.partR) + "+" + System.Convert.ToString(igual.partI) + "i");
                 txtA1.Text = System.Convert.ToString(igual.partR);
                 txtB1.Text = System.Convert.ToString(igual.partI);
                 txtA2.Clear();
                 txtB2.Clear();
                 txtA2.Focus();
             }
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            txtA1.Clear();
            txtA2.Clear();
            txtB1.Clear();
            txtB2.Clear();
            lblresultado.Text = "";
        }

    }
}
