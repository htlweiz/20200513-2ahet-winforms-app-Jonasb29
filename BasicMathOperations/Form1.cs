using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMathOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Zahl1, Zahl2, result;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            try
            {
                Zahl1 = Convert.ToDouble(txtNum1.Text);
                Zahl2 = Convert.ToDouble(txtNum2.Text);
                result = Zahl1 + Zahl2;
                lblResult.Text = Convert.ToString(result);
                lblErgebnis.Text = "Summe";
            }
            catch (Exception ex)
            {
                lblErgebnis.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNum1.Focus();
                txtNum1.SelectAll();
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            try
            {
                Zahl1 = Convert.ToDouble(txtNum1.Text);
                Zahl2 = Convert.ToDouble(txtNum2.Text);
                result = Zahl1 - Zahl2;
                lblResult.Text = Convert.ToString(result);
                lblErgebnis.Text = "Ergebnis";
            }
            catch (Exception ex)
            {
                lblErgebnis.Text = "Fehler";
                lblResult.Text = "keine Gültige Zahl";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNum1.Focus();
                txtNum1.SelectAll();
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                Zahl1 = Convert.ToDouble(txtNum1.Text);
                Zahl2 = Convert.ToDouble(txtNum2.Text);
                if (Zahl2 == 0)
                {
                    lblErgebnis.Text = "Fehler";
                    lblResult.Text = "Nicht Definiert";

                    MessageBox.Show("Zahl 2 darf nicht 0 sein.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNum1.Focus();
                    txtNum1.SelectAll();
                }
                else
                {
                    result = Zahl1 / Zahl2;
                    lblResult.Text = Convert.ToString(result);
                    lblErgebnis.Text = "Ergebnis";
                }
            }

            catch (Exception ex)
            {

                lblErgebnis.Text = "Fehler";
                lblResult.Text = "Keine gültige Zahl";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNum1.Focus();
                txtNum1.SelectAll();
            }
        }

        private void BtnPotentiate_Click(object sender, EventArgs e)
        {
            try
            {
                    Zahl1 = Convert.ToDouble(txtNum1.Text);
                    Zahl2 = Convert.ToDouble(txtNum2.Text);
                    result = Math.Pow(Zahl1, Zahl2);
                    lblResult.Text = Convert.ToString(result);
                    lblErgebnis.Text = "Ergebnis";
                
            }
            catch (Exception ex)
            {
                lblErgebnis.Text = "Fehler";
                lblResult.Text = "Keine gültige Zahl";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNum1.Focus();
                txtNum1.SelectAll();
            }
        }

        private void BtnWurzel_Click(object sender, EventArgs e)
        {
            Zahl1 = Convert.ToDouble(txtNum1.Text);
            Zahl2 = Convert.ToDouble(txtNum2.Text);
            try
            {
                if ((Zahl1 == 0)&&(Zahl2 < 0))
                {
                    lblResult.Text = "Error";
                    lblErgebnis.Text = "Ergebnis";
                    MessageBox.Show("Zahl 1 darf nicht 0 sein, oder negativ sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNum1.Focus();
                    txtNum2.Focus();
                    lblResult.Text = Convert.ToString("Error");
                }
                else
                {
                    result = Math.Pow(Zahl2, 1 / Zahl1);
                    lblResult.Text = Convert.ToString(result);
                    lblErgebnis.Text = "Ergebnis";
                }
            }
            catch (Exception ex)
            {
                lblErgebnis.Text = "Fehler";
                lblResult.Text = "keine Gültige Zahl";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNum1.Focus();
                txtNum1.SelectAll();
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "0";
            txtNum2.Text = "0";
            lblErgebnis.Text = "Ergebnis";
            lblResult.Text = "";
            txtNum1.Focus();
            txtNum1.SelectAll();
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                Zahl1 = Convert.ToDouble(txtNum1.Text);
                Zahl2 = Convert.ToDouble(txtNum2.Text);
                result = Zahl1 * Zahl2;
                lblResult.Text = Convert.ToString(result);
                lblErgebnis.Text = "Ergebnis";
            }
            catch (Exception ex)
            {
                lblErgebnis.Text = "Fehler";
                lblResult.Text = "keine Gültige Zahl";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNum1.Focus();
                txtNum1.SelectAll();
            }
        }

    }
}