using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rekenmachiene
{
    public partial class Telraam : Form
    {
        public Telraam()
        {
            InitializeComponent(); // Initialiseer de componenten van de form
        }
        string operatie; // Variabele om de geselecteerde operatie op te slaan
        int Eerstenummer; // Variabele om het eerste nummer op te slaan
        private void btnPunt_Click(object sender, EventArgs e)
        {
            // Controleer of er al een komma aanwezig is in het tekstveld
            char[] letters = { ',' };

            bool containsAnyLetter = txtrekenen.Text.IndexOfAny(letters) >=0;
            if (containsAnyLetter == true)
            {
                // Toon een foutmelding als er al een komma is
                MessageBox.Show("your word contains comma");
            }
            else
            {
                // Voeg een komma toe aan het tekstveld
                txtrekenen.Text += ",";
            }

        }
        // Methodes voor elk cijferknopje om het bijbehorende nummer aan het tekstveld toe te voegen
        private void btnNr7_Click(object sender, EventArgs e)
        {
            txtrekenen.Text += "7";
        }

        private void btnNR8_Click(object sender, EventArgs e)
        {
            txtrekenen.Text += "8";
        }

        private void btnNR9_Click(object sender, EventArgs e)
        {
            txtrekenen.Text += "9";
        }

        private void btnNR4_Click(object sender, EventArgs e)
        {
            txtrekenen.Text += "4";
        }

        private void btnNR5_Click(object sender, EventArgs e)
        {
            txtrekenen.Text += "5";
        }

        private void btnNR6_Click(object sender, EventArgs e)
        {
            txtrekenen.Text += "6";
        }

        private void btnNR1_Click(object sender, EventArgs e)
        {
            txtrekenen.Text += "1";
        }

        private void btnNR2_Click(object sender, EventArgs e)
        {
            txtrekenen.Text += "2";
        }

        private void btnNR3_Click(object sender, EventArgs e)
        {
            txtrekenen.Text += "3";
        }

        private void btnNR0_Click(object sender, EventArgs e)
        {
            txtrekenen.Text += "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Maak het tekstveld leeg
            txtrekenen.Text = " ";
        }
        // Methode om een operatie (zoals optellen of aftrekken) te selecteren
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Eerstenummer = Convert.ToInt32(txtrekenen.Text); // Sla het eerste nummer op
            txtrekenen.ResetText(); // Maak het tekstveld leeg
            operatie = "+";  // Stel de operatie in

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Eerstenummer = Convert.ToInt32(txtrekenen.Text);
            txtrekenen.ResetText();
            operatie = "-";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Eerstenummer = Convert.ToInt32(txtrekenen.Text);
            txtrekenen.ResetText();
            operatie = "/";
        }
        private void btnKeer_Click(object sender, EventArgs e)
        {
            Eerstenummer = Convert.ToInt32(txtrekenen.Text);
            txtrekenen.ResetText();
            operatie = "x";
        }
        private void btnTotDeMacht_Click(object sender, EventArgs e)
        {
            Eerstenummer = Convert.ToInt32(txtrekenen.Text);
            txtrekenen.ResetText();
            operatie = "^"; // Operatie voor machtsverheffing
        }
        private void btnis_Click(object sender, EventArgs e)
        {
            int Tweedenummer = Convert.ToInt32(txtrekenen.Text);  // Sla het tweede nummer op
            int Resultaat; // Variabele voor het resultaat

            if (operatie == "+")
            {
                // Voer optelling uit
                Resultaat = Eerstenummer + Tweedenummer;
                txtrekenen.Text = Resultaat.ToString();
                Eerstenummer = Resultaat;  // Update het eerste nummer

            }
            if (operatie == "-")
            {
                // Voer aftrekking uit
                Resultaat = Eerstenummer - Tweedenummer;
                txtrekenen.Text = Resultaat.ToString();
                Eerstenummer = Resultaat;
            }
            if (operatie == "x")
            {
                // Voer vermenigvuldiging uit
                Resultaat = Eerstenummer * Tweedenummer;
                txtrekenen.Text = Resultaat.ToString();
                Eerstenummer = Resultaat;
            }
            if (operatie == "/")
            {
                if (Tweedenummer != 0)
                {
                    // Voer deling uit als de deler niet nul is
                    Resultaat = Eerstenummer / Tweedenummer;
                    txtrekenen.Text = Resultaat.ToString();
                    Eerstenummer = Resultaat;
                }
                else
                {
                    // Toon foutmelding als er gedeeld wordt door nul
                    MessageBox.Show("error");
                }
             if (operatie == "^")
                {
                    // Voer machtsverheffing uit (vierkantswortel)
                    Resultaat = Eerstenummer * Eerstenummer;
                    txtrekenen.Text = Resultaat.ToString();
                    Eerstenummer = Resultaat;
                }

            }
        }
    }
}
